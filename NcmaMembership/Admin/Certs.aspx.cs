using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxGridView;

namespace NcmaMembership
{
    public partial class Certs : System.Web.UI.Page
    {
        public vwCertificate cert = new vwCertificate();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ASPxGridView1_HtmlRowPrepared(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs e)
        {
            if (e.RowType != GridViewRowType.Data) return;

            cert = GetCertificate((int)e.GetValue("ID"));



            
        }
        protected void ASPxGridView1_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            e.Cancel = true;
        }
        protected void ASPxGridView1_HtmlDataCellPrepared(object sender,DevExpress.Web.ASPxGridView.ASPxGridViewTableDataCellEventArgs e)
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
        }
        // Handles the data callback 
        protected void ASPxGridView1_CustomDataCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomDataCallbackEventArgs e)
        {
            //int retParam = 0;
            //int.TryParse(e.Parameters, out retParam);
            //if (retParam != 0)
            //{
            //    var query1 = from m in context.members
            //                where m.ID == retParam
            //                select m;

            //    member thisMember = query1.ToList().FirstOrDefault();

            //    var query2 = from m in context.dojoinstructors
            //                 where m.DojoID == thisMember.DojoID
            //                 select m.InstructorID;

            //    int instID = query2.ToList().FirstOrDefault() == null ? 0 : query2.ToList().FirstOrDefault().Value;

            //    string retVal = string.Format("{0}|{1}", thisMember.DojoID, instID);

            //    e.Result = retVal; 

            MyNcmaEntities context = new MyNcmaEntities();
            LargeSetsDataContext lscontext = new LargeSetsDataContext();
            if (ASPxGridView1.IsEditing)
            {
                int retParam = 0;
                int.TryParse(e.Parameters, out retParam);
                if (retParam != 0)
                {
                    var query2 = from m1 in context.dojoinstructors
                                 where m1.DojoID == (from m in lscontext.members
                                                     where m.ID == retParam
                                                     select m).FirstOrDefault().DojoID
                                 select m1;

                    dojoinstructor thisMember = query2.FirstOrDefault() as dojoinstructor;

                    int instID = thisMember == null ? 0 : thisMember.InstructorID.Value;

                    //string retVal = string.Format("{0}|{1}", thisMember.DojoID, instID);

                    e.Result = "3|5";//retVal; 
                }
                    
 
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
         protected string GetMemberName(int id)
        {
            LargeSetsDataContext Context = new LargeSetsDataContext();
            var query1 = from m in Context.members
                         where m.ID == id
                         select m;
            member thisMember = query1.ToList().FirstOrDefault();

            return String.Format("{0} {1}", thisMember.FirstName, thisMember.LastName);
        }
         protected string GetDojoName(int id)
         {
             LargeSetsDataContext Context = new LargeSetsDataContext();
             var query1 = from m in Context.members
                          where m.ID == id
                          select m;
             member thisMember = query1.ToList().FirstOrDefault();

             return String.Format("{0} {1}", thisMember.FirstName, thisMember.LastName);
         }

}


   
    
}