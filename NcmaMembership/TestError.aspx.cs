using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NcmaMembership
{
    public partial class TestError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                asm.GetTypes();
                foreach (Type t in asm.GetTypes())
                {

                    Response.Write(t.Name + "<br />");
                }
            }
        }
    }
}