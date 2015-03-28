using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxGridView;
using System.Collections;

namespace NcmaMembership.Admin
{
    public partial class MemberCerts : System.Web.UI.Page
    {
        public vwCertificate cert = new vwCertificate();

      

        public bool ShowFilterRow
        {
            get { return (Session["ShowFilterRow"] == null ? false : (bool)Session["ShowFilterRow"]); }
            set { Session["ShowFilterRow"] = value; }
        }
        


        protected void Page_Load(object sender, EventArgs e)
        {
            ASPxGridView1.Settings.ShowFilterRow = ShowFilterRow;
        }
        protected void ASPxGridView1_CustomCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs e)
        {
            ASPxGridView1.Settings.ShowFilterRow = !ASPxGridView1.Settings.ShowFilterRow;
            ShowFilterRow = ASPxGridView1.Settings.ShowFilterRow;
        }
        protected void ASPxGridView1_HtmlRowPrepared(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs e)
        {
            if (e.RowType != GridViewRowType.Data) return;

            cert = GetCertificate((int)e.GetValue("ID"));




        }
        protected void ASPxGridView1_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {

            int memID = int.Parse(e.NewValues["MemberID"].ToString());
            member thisMember = GetMember(memID);
            e.NewValues["DojoID"] = thisMember.DojoID;
            e.NewValues["InstructorID"] = GetInstructor(memID).ID;


        }
        protected void ASPxGridView1_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {

            int memID = int.Parse(e.NewValues["MemberID"].ToString());
            member thisMember = GetMember(memID);
            e.NewValues["DojoID"] = thisMember.DojoID;
            e.NewValues["InstructorID"] = GetInstructor(memID).ID;
            e.NewValues["Completed"] = bool.Parse(e.NewValues["Completed"].ToString());

        }
        protected void ASPxGridView1_HtmlDataCellPrepared(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableDataCellEventArgs e)
        {

            if (e.DataColumn.FieldName == "MemberID")
            {
                ASPxLabel lbl = ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, e.DataColumn, "lblMember") as ASPxLabel;
                lbl.Text = cert.FullName;
            }
            if (e.DataColumn.FieldName == "InstructorID")
            {
                ASPxLabel lbl = ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, e.DataColumn, "lblInstructor") as ASPxLabel;
                lbl.Text = cert.InstructorsName;
            }
            if (e.DataColumn.FieldName == "DojoID")
            {
                ASPxLabel lbl = ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, e.DataColumn, "lblDojo") as ASPxLabel;
                lbl.Text = cert.Dojo;
            }
        }
        Hashtable copiedValues = null;
        string[] copiedFields = new string[] { "MemberID", "CertificateTypeID", "DojoID", "InstructorID", "InstructorTypeID", "RankText", "TournamentDate", "FromDate", "ThruDate" };
        protected void ASPxGridView1_CustomButtonCallback(object sender, ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            if (e.ButtonID != "Clone") return;
            copiedValues = new Hashtable();
            foreach (string fieldName in copiedFields)
            {
                copiedValues[fieldName] = ASPxGridView1.GetRowValues(e.VisibleIndex, fieldName);
            }
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
            LargeSetsDataContext lscontext = new LargeSetsDataContext();
            MyNcmaEntities context = new MyNcmaEntities();
            var instructorQuery = from m1 in context.dojoinstructors
            where m1.DojoID == (from m in lscontext.members
                                where m.ID == memberid
                                select m).FirstOrDefault().DojoID
            select m1.InstructorID;

            int? instructorid = instructorQuery.FirstOrDefault() as int?;

            return (instructorid==null? new member() : GetMember((int)instructorid));
        }

    }
}