using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPxGridViewTableRowEventArgsAlias = DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs;
using DevExpress.Web.ASPxGridLookup;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;
using System.Collections;
using System.Reflection;
using System.Collections.Specialized;
using System.Threading;

namespace NcmaMembership
{
    public partial class Members : System.Web.UI.Page
    {

        public member MyMember
        {
            get
            {
                if (Session["MyMember"] == null)
                {
                    return new member();
                }
                else
                {
                    return (member)Session["MyMember"];
                }
            }
            set 
            { 
                Session["MyMember"] = value; 
            }
        }
        
        MyNcmaEntities ctx = new MyNcmaEntities();
        public bool ShowFilterRow
        {
            get { return (Session["ShowFilterRow"] == null ? false : (bool)Session["ShowFilterRow"]); }
            set { Session["ShowFilterRow"] = value; }
        }
        public string ViewType
        {
            get { return Request.QueryString["viewType"]; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ASPxGridView1.Settings.ShowFilterRow = ShowFilterRow;
        }

        protected void ASPxGridView1_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            var context = new LargeSetsDataContext();
            var m = context.members.First(i => i.ID == (int)e.Keys[0]);
            var dict = e.NewValues;

            HashToObject(ref m, dict);

            context.SubmitChanges();
            e.Cancel = true;

            EndEditing(sender);

        }

        private void EndEditing(object sender)
        {
            ((ASPxGridView)sender).CancelEdit();
            ((ASPxGridView)sender).DataBind();
        }
        protected void ASPxGridView1_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            var context = new LargeSetsDataContext();
            var m = context.members.First(i => i.ID == (int)e.Keys[0]);

            context.members.DeleteOnSubmit(m);
            context.SubmitChanges();
            e.Cancel = true;

            EndEditing(sender);

        }
        protected void ASPxGridView1_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            var context = new LargeSetsDataContext();
            member m = new member();

            var dict = e.NewValues;

            HashToObject(ref m, dict);
            MyMember = m;

            context.members.InsertOnSubmit(m);
            context.SubmitChanges();
            e.Cancel = true;

            EndEditing(sender);

        }

        private void HashToObject(ref member o, OrderedDictionary dict)
        {
            PropertyInfo[] properties = o.GetType().GetProperties();

            foreach (var pi in properties.Where(i => i.Name != "ID"))
            {
                PropertySet(o, pi.Name, dict[pi.Name]);
            }

            
        }
        static void PropertySet(object p, string propName, object value)
        {
            var t = p.GetType();
            var info = t.GetProperty(propName);
            if (info == null)
                return;
            if (!info.CanWrite)
                return;
            info.SetValue(p, value, null);
        }

   
        private void SetTableLabel()
        {
            
            switch (ViewType)
            {
                case null:
                    lblTableName.Text = "All Members";
                    break;
                case "all":
                    lblTableName.Text = "All Members";
                    break;
                case "false":
                    lblTableName.Text = "Inactive Members";
                    break;
                default:
                    lblTableName.Text = "Active Members";
                    break;
            }
            
        }


     
        
        protected void ASPxGridView1_CustomCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs e)
        {
            ASPxGridView1.Settings.ShowFilterRow = !ASPxGridView1.Settings.ShowFilterRow;
            ShowFilterRow = ASPxGridView1.Settings.ShowFilterRow;
            if (e.Parameters == "Refresh")
                ASPxGridView1.DataBind();
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            this.ASPxGridViewExporter1.WritePdfToResponse();
        }
        protected void btnXlsExport_Click(object sender, EventArgs e)
        {
            this.ASPxGridViewExporter1.WriteXlsToResponse();

        }
        protected void btnXlsxExport_Click(object sender, EventArgs e)
        {
            this.ASPxGridViewExporter1.WriteXlsxToResponse();
        }
        protected void btnRtfExport_Click(object sender, EventArgs e)
        {
            this.ASPxGridViewExporter1.WriteRtfToResponse();
        }
        protected void btnCsvExport_Click(object sender, EventArgs e)
        {
            this.ASPxGridViewExporter1.WriteCsvToResponse();
        }
        protected void ASPxGridView1_HtmlRowPrepared(object sender, ASPxGridViewTableRowEventArgsAlias e)
        {
            if (e.RowType == DevExpress.Web.ASPxGridView.GridViewRowType.Data)
            {
                bool isActive;
                object activeField = e.GetValue("Active");

                if (activeField != null && activeField.ToString() != "0")
                    isActive = true;
                else
                    isActive = false;
                if (!(isActive))
                {
                    e.Row.Font.Italic = true;
                    e.Row.ForeColor = System.Drawing.Color.Gray;
                    e.Row.Font.Strikeout = true;
                }
            }
        }
        protected void ASPxGridView1_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
        {
            
            if (Session["MyMember"] == null)
            {
                e.NewValues["CountryID"] = 185;
                e.NewValues["Active"] = 1;
            }
            else
            {
                member m = MyMember;
                e.NewValues["Active"] = m.Active;
                e.NewValues["Address1"] = m.Address1;
                e.NewValues["Address2"] = m.Address2;
                e.NewValues["Address3"] = m.Address3;
                e.NewValues["CellPhone"] = m.CellPhone;
                e.NewValues["City"] = m.City;
                e.NewValues["Comments"] = m.Comments;
                e.NewValues["CountryID"] = m.CountryID;

                e.NewValues["DateInactive"] = m.DateInactive;
                e.NewValues["DateJoined"] = m.DateJoined;
                e.NewValues["DateLastPaid"] = m.DateLastPaid;
                e.NewValues["DateOfRank"] = m.DateOfRank;
                e.NewValues["DOB"] = m.DOB;
                e.NewValues["DojoID"] = m.DojoID;
                e.NewValues["Email"] = m.Email;
                e.NewValues["FirstName"] = m.FirstName;
                e.NewValues["HomePhone"] = m.HomePhone;
                e.NewValues["LastName"] = m.LastName;
                e.NewValues["MemberTypeID"] = m.MemberTypeID;
                e.NewValues["MiddleName"] = m.MiddleName;
                e.NewValues["PostalCode"] = m.PostalCode;
                e.NewValues["RankText"] = m.RankText;
                e.NewValues["StateID"] = m.StateID;
                e.NewValues["Suffix"] = m.Suffix;
            }
        }

        protected void LinqServerModeDataSource1_Selecting(object sender, DevExpress.Data.Linq.LinqServerModeDataSourceSelectEventArgs e)
        {
            int? t = null;

            switch (ViewType)
            {
                case "true":
                    t = 1;
                    break;
                case "false":
                    t = 0;
                    break;
                default:
                    t = null;
                    break;

            }
            var query = from q in new LargeSetsDataContext().members
                select q;

            if (t != null)
            {
                query = query.Where( m=> m.Active == (int)t);
            }
            e.QueryableSource = query;
            SetTableLabel();
        }
    }
}
