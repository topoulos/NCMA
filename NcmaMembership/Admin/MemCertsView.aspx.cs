using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxGridLookup;
using System.Collections;
using System.Drawing;
using System.Xml;

namespace NcmaMembership.Admin
{
    public partial class MemCertsView : System.Web.UI.Page
    {
        public vwCertificate cert = new vwCertificate();



        public bool ShowFilterRow
        {
            get { return (Session["ShowFilterRow"] == null ? false : (bool)Session["ShowFilterRow"]); }
            set { Session["ShowFilterRow"] = value; }
        }
        public bool IsCopy
        {
            get { return (Session["IsCopy"] == null ? false : (bool)Session["IsCopy"]); }
            set { Session["IsCopy"] = value; }
        }
        public int CopyType
        {
            get { return (Session["CopyType"] == null ? 0 : (int)Session["CopyType"]); }
            set { Session["CopyType"] = value; }
        }
        public int OriginalID
        {
            get { return (Session["OriginalID"] == null ? 0 : (int)Session["OriginalID"]); }
            set { Session["OriginalID"] = value; }
        }
        

        protected void Page_Load(object sender, EventArgs e)
        {
            SetGridDataSource();

            
        }

        private void SetGridDataSource()
        {
            MyNcmaEntities context = new MyNcmaEntities();
            ASPxGridView1.Settings.ShowFilterRow = ShowFilterRow;
            string viewType = Request.QueryString["viewType"];

            var qCompleted = from c in context.vwCertificates
                             where c.Completed == true
                             select c;
            List<vwCertificate> certs = qCompleted.ToList();
            var qIncomplete = from c in context.vwCertificates
                              where c.Completed == false || c.Completed == null
                              select c;
            List<vwCertificate> icerts = qIncomplete.ToList();

            List<vwCertificate> acerts = qCompleted.Union(qIncomplete).ToList();

            switch (viewType)
            {
                case null:
                    ASPxGridView1.DataSource = acerts;
                    lblTableName.Text = "All Certificates";
                    break;
                case "all":
                    ASPxGridView1.DataSource = acerts;
                    lblTableName.Text = "All Certificates";
                    break;
                case "completed":
                    ASPxGridView1.DataSource = certs;
                    lblTableName.Text = "Completed Certificates";
                    break;
                default:
                    ASPxGridView1.DataSource = icerts;
                    lblTableName.Text = "New Certificates";
                    break;
            }



            ASPxGridView1.DataBind();
        }
        private List<vwCertificate> GetGridDataSource()
        {
            MyNcmaEntities context = new MyNcmaEntities();
            string viewType = Request.QueryString["viewType"];

            var qCompleted = from c in context.vwCertificates
                             where c.Completed == true
                             select c;
            List<vwCertificate> certs = qCompleted.ToList();
            var qIncomplete = from c in context.vwCertificates
                              where c.Completed == false || c.Completed == null
                              select c;
            List<vwCertificate> icerts = qIncomplete.ToList();

            List<vwCertificate> acerts = qCompleted.Union(qIncomplete).ToList();

            switch (viewType)
            {
                case null:
                    return acerts;
                    break;
                case "all":
                    return acerts;
                    break;
                case "completed":
                    return certs;
                    break;
                default:
                    return icerts;
                    break;
            }



            
        }
        protected void ASPxGridView1_CustomCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs e)
        {
            ASPxGridView1.Settings.ShowFilterRow = !ASPxGridView1.Settings.ShowFilterRow;
            ShowFilterRow = ASPxGridView1.Settings.ShowFilterRow;
        }
        protected void ASPxGridView1_HtmlRowPrepared(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs e)
        {
            //if (e.RowType != GridViewRowType.Data) return;

            //cert = GetCertificate((int)e.GetValue("ID"));
            //e.Row.BackColor = GetRowBackColor(cert.CertType);



        }
        protected void ASPxGridView1_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            MyNcmaEntities context = new MyNcmaEntities();
            membercert mc = GetRowData(false);
            context.membercerts.AddObject(mc);
            context.SaveChanges();
            e.Cancel = true;
            EndEditing(sender);





        }
        protected object GetDateOnError(object date)
        {
            if (date == null )
                return null;
            else
                return date;
        }
        protected void ASPxGridView1_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            
            MyNcmaEntities context = new MyNcmaEntities();
            membercert mc = GetRowData(true);

            membercert c = context.membercerts.First(i => (int)i.MemberID == (int)mc.MemberID);
            c.MemberID = mc.MemberID;
            c.DojoID = mc.DojoID;
            c.CertificateTypeID = mc.CertificateTypeID;
            c.RankText = mc.RankText;
            c.InstructorID = mc.InstructorID;
            c.InstructorTypeID = mc.InstructorTypeID;
            c.FromDate = mc.FromDate;
            c.ThruDate = mc.ThruDate;
            c.Completed = mc.Completed;
            c.TourneyID = mc.TourneyID;
            context.SaveChanges();
            e.Cancel = true;
            EndEditing(sender);

        }

        private void EndEditing(object sender)
        {
            ((ASPxGridView)sender).CancelEdit();
            ((ASPxGridView)sender).DataSource = GetGridDataSource();
            ((ASPxGridView)sender).DataBind();
        }

        protected void ASPxGridView1_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            MyNcmaEntities context = new MyNcmaEntities();
            int id = (int)e.Keys[ASPxGridView1.KeyFieldName];

            membercert c = context.membercerts.First(i => i.ID == id);
            context.membercerts.DeleteObject(c);
            context.SaveChanges();
            e.Cancel = true;
            EndEditing(sender);
        }
        protected membercert GetRowData(bool update)
        {
            membercert mc = new membercert();

            if (update)
            {
                ASPxTextBox txID = ASPxGridView1.FindEditFormTemplateControl("txtID") as ASPxTextBox;
                mc.ID = int.Parse(txID.Text);
            }
            ASPxGridLookup luMember = ASPxGridView1.FindEditFormTemplateControl("ASPxGridLookup1") as ASPxGridLookup;
            mc.MemberID = int.Parse(luMember.Value.ToString());
            ASPxComboBox cbCertType = ASPxGridView1.FindEditFormTemplateControl("cboCertType") as ASPxComboBox;
            mc.CertificateTypeID = int.Parse(cbCertType.Value.ToString());
            ASPxTextBox txRank = ASPxGridView1.FindEditFormTemplateControl("txtRank") as ASPxTextBox;
            mc.RankText = txRank.Text;
            ASPxComboBox cbInstType = ASPxGridView1.FindEditFormTemplateControl("cboInstructorType") as ASPxComboBox;
            mc.InstructorTypeID = cbInstType.Value==null?0:int.Parse(cbInstType.Value.ToString());
            ASPxDateEdit dFrom = ASPxGridView1.FindEditFormTemplateControl("dtFrom") as ASPxDateEdit;
            mc.FromDate = DateTime.Parse(dFrom.Value.ToString());
            if (mc.CertificateTypeID != 1 && mc.CertificateTypeID != 5 && mc.CertificateTypeID != 10)
            {
                ASPxDateEdit dThru = ASPxGridView1.FindEditFormTemplateControl("dtThru") as ASPxDateEdit;
                mc.ThruDate = DateTime.Parse(dThru.Value.ToString());
            }
            ASPxCheckBox cCompleted = ASPxGridView1.FindEditFormTemplateControl("chkCompleted") as ASPxCheckBox;
            mc.Completed = cCompleted.Checked;
            ASPxComboBox cbTourney = ASPxGridView1.FindEditFormTemplateControl("cboTourney") as ASPxComboBox;
            mc.TourneyID = cbTourney.Value==null?0:int.Parse(cbTourney.Value.ToString());
            mc.DojoID = (int)(GetMember((int)mc.MemberID).DojoID);
            mc.InstructorID = (int)(GetInstructor((int)mc.MemberID).ID);

            return mc;

        }
        protected Color GetRowBackColor(string certType)
        {
            Color c = Color.Black;
            switch (certType)
            {
                case "Rank": case "Tenshi Rank":
                    c = ColorTranslator.FromHtml("#941B1B");
                    break;
                case "Instructor" : case "Tenshi Instructor": case "Chief Instructor":
                    c = ColorTranslator.FromHtml("#848914");
                    break;
                case "Membership": case "Tenshi Membership":
                    c = ColorTranslator.FromHtml("#1C6795");
                    break;
                case "School Charter": case "Tenshi School Charter":
                    c = ColorTranslator.FromHtml("#2B6C39");
                    break;
                default:
                    c = ColorTranslator.FromHtml("#000000");
                    break;
            }
            return c;

            
        }
        protected Color GetRowForeColor(string certType)
        {
            Color c = Color.Black;
            switch (certType)
            {
                case "Rank": case "Tenshi Rank":
                    c = Color.Yellow;
                    break;
                case "Instructor" : case "Tenshi Instructor": case "Cheif Instructor":
                    c = Color.Yellow;
                    break;
                case "Member": case "Tenshi Member":
                    c = Color.Yellow;
                    break;
                case "School Charter": case "Tenshi School Charter":
                    c = Color.Yellow;
                    break;
                default:
                    c = Color.Yellow;
                    break;
            }
            return c;

          

        }
        protected void dlblTextFullName_OnInit(object sender, EventArgs e)
        {
            //Color Yellow = ColorTranslator.FromHtml("#EBEE0E");
            ASPxLabel lbl = (ASPxLabel)sender;
            GridViewDataRowTemplateContainer container = lbl.NamingContainer as GridViewDataRowTemplateContainer;
            string certType = container.Grid.GetRowValues(container.VisibleIndex, "CertType").ToString();
            lbl.ForeColor = GetRowForeColor(certType);
            string txt = container.Grid.GetRowValues(container.VisibleIndex, "FullName").ToString();
            lbl.Text = txt;


        }
        protected void dimgCertType_OnInit(object sender, EventArgs e)
        {

            ASPxImage img = (ASPxImage)sender;
            GridViewDataRowTemplateContainer container = img.NamingContainer as GridViewDataRowTemplateContainer;

            string certType = container.Grid.GetRowValues(container.VisibleIndex, "CertType").ToString();
            img.ImageUrl = GetImageUrl(certType);
        }
        protected string GetImageUrl(string certType)
        {
            string url = @"~/images/{0}.PNG";
            string returnUrl = "";
            switch (certType)
            {
                case "Rank":
                    returnUrl = string.Format(url, "RANK");
                    break;
                case "Instructor":
                case "Chief Instructor":
                    returnUrl = string.Format(url, "INSTRUCTOR");
                    break;
                case "Tenshi Instructor":
                case "Tenshi Chief Instructor":
                    returnUrl = string.Format(url, "TENSHIINSTRUCTOR");
                    break;
                case "Membership":
                    returnUrl = string.Format(url, "MEMBER");
                    break;
                case "School Charter":
                    returnUrl = string.Format(url, "SCHOOL");
                    break;
                case "Hanshi Seminar":
                    returnUrl = string.Format(url, "SEMINAR");
                    break;
                case "Tenshi Rank":
                    returnUrl = string.Format(url, "TENSHIRANK");
                    break;
                case "Tenshi Membership":
                    returnUrl = string.Format(url, "TENSHIMEMBER");
                    break;
                case "Tenshi School Charter":
                    returnUrl = string.Format(url, "TENSHISCHOOL");
                    break;
                default:
                    break;

            }
            return returnUrl;
        }
        protected void dlblLabelFullName_OnInit(object sender, EventArgs e)
        {
            ASPxLabel lbl = (ASPxLabel)sender;
            GridViewDataRowTemplateContainer container = lbl.NamingContainer as GridViewDataRowTemplateContainer;
            string certType = container.Grid.GetRowValues(container.VisibleIndex, "CertType").ToString();
            lbl.ForeColor = GetRowForeColor(certType);
            //lbl.Text = cert.FullName;
        }

        protected void dlblLabelDate_OnInit(object sender, EventArgs e)
        {
            ASPxLabel lbl = (ASPxLabel)sender;
            GridViewDataRowTemplateContainer container = lbl.NamingContainer as GridViewDataRowTemplateContainer;
            string certType = container.Grid.GetRowValues(container.VisibleIndex, "CertType").ToString();

            lbl.ForeColor = GetRowForeColor(certType);
            //lbl.Text = cert.FullName;
        }

        protected void dlblLabelDojo_OnInit(object sender, EventArgs e)
        {
            ASPxLabel lbl = (ASPxLabel)sender;
            lbl.Font.Size = 16;
            lbl.Font.Bold = true;

            GridViewDataRowTemplateContainer container = lbl.NamingContainer as GridViewDataRowTemplateContainer;
            string certType = container.Grid.GetRowValues(container.VisibleIndex, "CertType").ToString();
            lbl.ForeColor = GetRowForeColor(certType);
            //lbl.Text = cert.FullName;
        }

        protected void dlblTextDojo_OnInit(object sender, EventArgs e)
        {
            ASPxLabel lbl = (ASPxLabel)sender;
            lbl.Font.Size = 16;
            lbl.Font.Bold = true;

            GridViewDataRowTemplateContainer container = lbl.NamingContainer as GridViewDataRowTemplateContainer;
            string txt = container.Grid.GetRowValues(container.VisibleIndex, "Dojo").ToString();
            string certType = container.Grid.GetRowValues(container.VisibleIndex, "CertType").ToString();
            lbl.ForeColor = GetRowForeColor(certType);
            lbl.Text = txt;
        
        }

        protected void dlblValidDates_OnInit(object sender, EventArgs e)
        {
            ASPxLabel lbl = (ASPxLabel)sender;
            GridViewDataRowTemplateContainer container = lbl.NamingContainer as GridViewDataRowTemplateContainer;
            string fromTxt = DateTime.Parse(container.Grid.GetRowValues(container.VisibleIndex, "FromDate").ToString()).ToShortDateString();
            string thruTxt = DateTime.Parse(container.Grid.GetRowValues(container.VisibleIndex, "ThruDate").ToString()).ToShortDateString();
            string certType = container.Grid.GetRowValues(container.VisibleIndex, "CertType").ToString();
            lbl.ForeColor = GetRowForeColor(certType);

            lbl.Text = fromTxt;
            lbl.Text += (certType != "Rank" && certType != "Seminar") ? " - " + thruTxt : string.Empty;
        }

        protected void dlblLabelInstName_OnInit(object sender, EventArgs e)
        {
            ASPxLabel lbl = (ASPxLabel)sender;
            GridViewDataRowTemplateContainer container = lbl.NamingContainer as GridViewDataRowTemplateContainer;
            lbl.Font.Size = 10;
            string certType = container.Grid.GetRowValues(container.VisibleIndex, "CertType").ToString();
            lbl.ForeColor = GetRowForeColor(certType);
            //lbl.Text = cert.FullName;
        }

        protected void dlblTextInstName_OnInit(object sender, EventArgs e)
        {
            ASPxLabel lbl = (ASPxLabel)sender;
            GridViewDataRowTemplateContainer container = lbl.NamingContainer as GridViewDataRowTemplateContainer;
            lbl.Font.Size = 10;
            string certType = container.Grid.GetRowValues(container.VisibleIndex, "CertType").ToString();
            string instText = container.Grid.GetRowValues(container.VisibleIndex, "InstructorsName").ToString();
            lbl.ForeColor = GetRowForeColor(certType);
            lbl.Text = instText;
        }

        protected void dlblRankText_OnInit(object sender, EventArgs e)
        {
            ASPxLabel lbl = (ASPxLabel)sender;
            GridViewDataRowTemplateContainer container = lbl.NamingContainer as GridViewDataRowTemplateContainer;
            string certType = container.Grid.GetRowValues(container.VisibleIndex, "CertType").ToString()??"";
            string rnkText = (container.Grid.GetRowValues(container.VisibleIndex, "RankText")??"").ToString();
            lbl.ForeColor = GetRowForeColor(certType);
            lbl.Text = rnkText;
            
        }


        protected void ASPxGridView1_HtmlDataCellPrepared(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableDataCellEventArgs e)
        {
            

        }
        Hashtable copiedValues = null;
        string[] copiedFields = new string[] { "MemberID", "CertificateTypeID", "DojoID", "InstructorID", "InstructorTypeID", "RankText", "TournamentDate", "FromDate", "ThruDate","Completed" };
        protected void ASPxGridView1_CustomButtonCallback(object sender, ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            //don't use hash, values are different.
            if (e.ButtonID != "Clone") return;
            copiedValues = new Hashtable();
            foreach (string fieldName in copiedFields)
            {
                copiedValues[fieldName] = ASPxGridView1.GetRowValues(e.VisibleIndex, fieldName);
            }
            IsCopy = true;
            CopyType = (int)copiedValues["CertificateTypeID"];
            OriginalID = (int)ASPxGridView1.GetRowValues(e.VisibleIndex,"ID");
            ASPxGridView1.AddNewRow();

        }
        protected void ASPxGridView1_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
        {
            if (copiedValues == null) return;
            foreach (string fieldName in copiedFields)
            {
                e.NewValues[fieldName] = copiedValues[fieldName];
            }
        }
        protected void ASPxGridView1_HtmlRowCreated(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs e)
        {
            bool isNew = ((ASPxGridView)sender).IsNewRowEditing;
            
            if (e.RowType == DevExpress.Web.ASPxGridView.GridViewRowType.EditForm && isNew && !IsCopy)
            {
                SetCertificateType(sender, 0, "");
            }
            else if (e.RowType == DevExpress.Web.ASPxGridView.GridViewRowType.EditForm)
            {
                var db = new MyNcmaEntities();
                int certTypeID;
                int id;

                if (IsCopy)
                {
                    certTypeID = CopyType;
                    id = OriginalID;
                }
                else
                {
                    certTypeID = int.Parse(e.GetValue("CertificateTypeID").ToString());
                    id = int.Parse(e.GetValue("ID").ToString());
                }
                

                var q = db.vwCertificates.First(c => c.ID == id);
                string instTypeText = q.InstructorType;

                SetCertificateType(sender, certTypeID, instTypeText);

            }
        }

        private static void SetCertificateType(object sender, int certTypeID, string instTypeText)
        {
            switch (certTypeID)
            {
                //Rank
                case 1:
                case 5:
                    SetEditors(sender, true, true, false, true, false, true, true, "Date of Rank", instTypeText);
                    break;
                //Instructor 
                case 3:
                case 6:
                case 9:
                    SetEditors(sender, true, false, true, true, true, false, true, "Valid From", instTypeText);
                    break;
                //school 
                case 2:
                case 8:
                    SetEditors(sender, true, false, false, true, true, false, true, "Valid From", instTypeText);
                    break;
                //member 
                case 4:
                case 7:
                    SetEditors(sender, true, false, false, true, true, false, true, "Valid From", instTypeText);
                    break;
                //seminar
                case 10:
                    SetEditors(sender, true, false, false, true, false, true, true, "Seminar Date", instTypeText);
                    break;
                default:
                    SetEditors(sender, false, false, false, false, false, false, false, "", "");
                    break;
            }
        }

        private static void SetEditors(object sender, bool showMember, bool showRank, bool showInstructor, bool showFromDate, bool showThruDate, bool showTourney, bool ShowCompleted, string fromDateText, string instructorTypeText )
        {
            (((ASPxGridView)sender).FindEditFormTemplateControl("ASPxGridLookup1") as ASPxGridLookup).ClientVisible = showMember;
            (((ASPxGridView)sender).FindEditFormTemplateControl("lblMember") as ASPxLabel).ClientVisible = showMember;
            (((ASPxGridView)sender).FindEditFormTemplateControl("lblRankText") as ASPxLabel).ClientVisible = showRank;
            (((ASPxGridView)sender).FindEditFormTemplateControl("txtRank") as ASPxTextBox).ClientVisible = showRank;
            (((ASPxGridView)sender).FindEditFormTemplateControl("lblInstructorType") as ASPxLabel).ClientVisible = showInstructor;
            (((ASPxGridView)sender).FindEditFormTemplateControl("cboInstructorType") as ASPxComboBox).ClientVisible = showInstructor;
            (((ASPxGridView)sender).FindEditFormTemplateControl("cboInstructorType") as ASPxComboBox).Text = instructorTypeText;
            (((ASPxGridView)sender).FindEditFormTemplateControl("lblFromDate") as ASPxLabel).ClientVisible = showFromDate;
            (((ASPxGridView)sender).FindEditFormTemplateControl("lblFromDate") as ASPxLabel).Text = fromDateText;
            (((ASPxGridView)sender).FindEditFormTemplateControl("dtFrom") as ASPxDateEdit).ClientVisible = showFromDate;
            (((ASPxGridView)sender).FindEditFormTemplateControl("lblThruDate") as ASPxLabel).ClientVisible = showThruDate;
            (((ASPxGridView)sender).FindEditFormTemplateControl("dtThru") as ASPxDateEdit).ClientVisible = showThruDate;
            (((ASPxGridView)sender).FindEditFormTemplateControl("lblTourney") as ASPxLabel).ClientVisible = showTourney;
            (((ASPxGridView)sender).FindEditFormTemplateControl("cboTourney") as ASPxComboBox).ClientVisible = showTourney;
            (((ASPxGridView)sender).FindEditFormTemplateControl("lblCompleted") as ASPxLabel).ClientVisible = ShowCompleted;
            (((ASPxGridView)sender).FindEditFormTemplateControl("chkCompleted") as ASPxCheckBox).ClientVisible = ShowCompleted;
        }
        protected void ASPxGridView1_CellEditorInitialize(object sender,  DevExpress.Web.ASPxGridView.ASPxGridViewEditorEventArgs e)
        {
            //if (e.Column.FieldName != "CertificateTypeID" && e.Column.FieldName != "MemberID")
            //{
            //    e.Editor.Visible = false;
            //}
            //MyNcmaEntities db = new MyNcmaEntities();

            //if (ASPxGridView1.IsNewRowEditing)
            //{
            //    switch (e.Column.FieldName)
            //    {
            //        case "CertificateTypeID":
                        
            //    }
            //}
            //else
            //{
                
            //    vwCertificate c = db.vwCertificates.First(i => i.ID == (int)e.KeyValue);
            //    switch (c.CertType)
            //    {
            //        case "Rank":
            //            if (e.Column.FieldName=="RankText") e.Editor.Visible =  true;
            //            if (e.Column.FieldName=="CertificateTypeID") e.Editor.Visible =  true;
            //            if (e.Column.FieldName=="InstructorTypeID") e.Editor.Visible =  true;
            //            if (e.Column.FieldName=="FromDate") e.Editor.Visible =  true;
            //            if (e.Column.FieldName=="ThruDate") e.Editor.Visible =  true;
            //            if (e.Column.FieldName=="RankText") e.Editor.Visible =  true;
            //            if (e.Column.FieldName=="RankText") e.Editor.Visible =  true;
            //            if (e.Column.FieldName=="RankText") e.Editor.Visible =  true;
            //            if (e.Column.FieldName=="RankText") e.Editor.Visible =  true;
            //            if (e.Column.FieldName=="RankText") e.Editor.Visible =  true;
            //                e.Editor
            //            switch (e.Column.FieldName)
            //            {
            //                case "RankText":
            //                    e.Editor.Visible = true;
            //                    break;
            //                case "InstructorTypeID":
            //                    e.Editor.Visible = false;
            //                    break;
            //                case "ThruDate":
            //                    e.Editor.

            //            }

            //    }
            //    if (e.Column.FieldName == "RankText")
            //        e.Editor.Visible = true;

            //}
        }
        protected vwCertificate GetCertificate(int id)
        {
            MyNcmaEntities context = new MyNcmaEntities();

            var query1 = from c in context.vwCertificates
                         where c.ID == id
                         select c;

            vwCertificate thisCert = query1.FirstOrDefault() as vwCertificate;
            return thisCert;

        }
        protected member GetMember(int id)
        {
            LargeSetsDataContext context = new LargeSetsDataContext();

            var memberQuery = from m in context.members
                              where m.ID == id
                              select m;
            member thisMember = memberQuery.FirstOrDefault() as member;
            return thisMember;

        }
        
        protected member GetInstructor(int memberid)
        {
            try
            {
                LargeSetsDataContext lscontext = new LargeSetsDataContext();
                MyNcmaEntities context = new MyNcmaEntities();
                var instructorQuery = from m1 in context.dojoinstructors
                                      where m1.DojoID == (from m in lscontext.members
                                                          where m.ID == memberid
                                                          select m).FirstOrDefault().DojoID
                                      select m1;

                int? instructorid = instructorQuery.FirstOrDefault().InstructorID as int?;

                return (instructorid == null ? new member() : GetMember((int)instructorid));
            }
            catch (Exception ex)
            {
                return new member();
            }
        }

    }
}