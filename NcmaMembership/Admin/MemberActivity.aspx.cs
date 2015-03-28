using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridLookup;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;
namespace NcmaMembership
{
    public partial class MemberActivity : System.Web.UI.Page
    {
        LargeSetsDataContext context = new LargeSetsDataContext();
        MyNcmaEntities ctx = new MyNcmaEntities();
        public bool ShowFilterRow
        {
            get { return (Session["ShowFilterRow"] == null ? false : (bool)Session["ShowFilterRow"]); }
            set { Session["ShowFilterRow"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ASPxGridView1.Settings.ShowFilterRow = ShowFilterRow;
        }
        protected void ASPxGridView1_HtmlDataCellPrepared(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableDataCellEventArgs e)
        {

            if (e.DataColumn.FieldName == "MemberID")
            {
                int id = Convert.ToInt32(e.CellValue);
                var memq = context.members.First(i => i.ID == id);

                member lu = memq as member;

                ASPxLabel lbl = ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, e.DataColumn, "lblMember") as ASPxLabel;
                lbl.Text = String.Format("{0} {1}", lu.FirstName, lu.LastName);
            }
        }

        protected void ASPxGridView1_CustomCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs e)
        {
            ASPxGridView1.Settings.ShowFilterRow = !ASPxGridView1.Settings.ShowFilterRow;
            ShowFilterRow = ASPxGridView1.Settings.ShowFilterRow;
        }





    }
}
