using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NcmaMembership
{
    public partial class InstructorType : System.Web.UI.Page
    {
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

    }
}
