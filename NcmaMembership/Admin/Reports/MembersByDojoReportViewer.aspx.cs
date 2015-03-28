using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReportLibrary;
using MemberReport = ReportLibrary.MemberReports.MembersByDojoReport;
using ReportParameter = DevExpress.XtraReports.Parameters.Parameter;
using System.Reflection;
using AutoMapper;
using ReportMember = ReportLibrary.MemberReports.Member;
using DevExpress.XtraReports.UI;

namespace NcmaMembership.Admin.Reports
{
    public partial class MembersByDojoReportViewer : System.Web.UI.Page
    {
        
        public DateTime FromDate { get; set; }
        public DateTime ThruDate { get; set; }
        public string ReportType { get; set; }
        public string ReportTitle { get; set; }
        public string ReportSubTitle { get; set; }
        public LargeSetsDataContext db = new LargeSetsDataContext();

        public MemberReport MyReport
        {
            get { return (MemberReport)Session["report"]; }
            set { Session["report"] = value; }
        }
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                FromDate = (DateTime)dtFrom.Value;
                ThruDate = (DateTime)dtThru.Value;
                ReportType = cboReportType.Value.ToString();

                MyReport = GetReport();
                ReportViewer1.Report = MyReport;
                
            }
            else
            {
                dtFrom.Value = DateTime.Now.AddMonths(-1);
                dtThru.Value = DateTime.Now;
                cboReportType.Value = "Rank";
            }
        }

        MemberReport GetReport()
        {
            MemberReport report = new MemberReport();
            
            //ReportParameter reportTitleParam = new ReportParameter() { Type = typeof(string), Value = ReportTitle, Name="ReportTitle" };
            //report.Parameters.Add(reportTitleParam);
            //ReportParameter reportTypeParam = new ReportParameter() { Type = typeof(DateTime), Value = ReportType, Name="DateType" };
            //report.Parameters.Add(reportTypeParam);
            report.DateType.Value = ReportType;
            report.DataSource = GetData();
            report.ReportTitle.Value = ReportTitle;
            report.ReportSubTitle.Value = ReportSubTitle;
            report.CreateDocument();
            return report;
        }

        List<ReportMember> GetData()
        {
            switch (ReportType)
            {
                case "Join":
                    ReportTitle = "Members By Dojo";
                    ReportSubTitle = String.Format("Date Joined Report - {0} - {1}", FromDate.ToShortDateString(),ThruDate.ToShortDateString());
                    return GetJoined();
                   
                case "Paid":
                    ReportTitle = "Members By Dojo";
                    ReportSubTitle = String.Format("Date Paid Report - {0} - {1}", FromDate.ToShortDateString(),ThruDate.ToShortDateString());
                    return GetPaid();
                   
                case "Rank":
                    ReportTitle = "Members By Dojo";
                    ReportSubTitle = String.Format("Date Of Rank Report - {0} - {1}", FromDate.ToShortDateString(),ThruDate.ToShortDateString());
                    return GetRank();
                   
                default:
                   ReportTitle = "Members By Dojo - Date Joined";
                   ReportSubTitle = String.Format("Date Joined Report - {0} - {1}", FromDate.ToShortDateString(),ThruDate.ToShortDateString());
                   return GetAll();
            }
        }


        List<ReportMember> GetRank()
        {
            var query = from m in db.vwMemberGridLookups
                        where m.DateOfRank >= FromDate && m.DateOfRank <= ThruDate && m.Active == 1
                        select m;
            List<vwMemberGridLookup> theseMembers = query.ToList();
            return ConvertToReportType(theseMembers);

        }
        
        List<ReportMember> GetJoined()
        {
            var query = from m in db.vwMemberGridLookups
                        where m.DateJoined >= FromDate && m.DateJoined <= ThruDate
                        select m;
            return GetMembersFromLinqQuery(query);
        }

        private List<ReportMember> GetMembersFromLinqQuery(IQueryable<vwMemberGridLookup> query)
        {
            List<vwMemberGridLookup> theseMembers = query.ToList();
            return ConvertToReportType(theseMembers);
        }

        List<ReportMember> GetPaid()
        {
            var query = from m in db.vwMemberGridLookups
                        where m.DateLastPaid >= FromDate && m.DateLastPaid <= ThruDate
                        select m;
            return GetMembersFromLinqQuery(query);
        }

        List<ReportMember> GetAll()
        {
            var query = from m in db.vwMemberGridLookups
                        select m;
            return GetMembersFromLinqQuery(query);
        }
        protected void ReportViewer1_Unload(object sender, EventArgs e)
        {
            ReportViewer1.Report = null;
        }

        List<ReportMember> ConvertToReportType(List<vwMemberGridLookup> originalRecords)
        {

            List<ReportMember> mems = new List<ReportMember>();
            
            Mapper.CreateMap<vwMemberGridLookup,ReportMember>();
            if (originalRecords != null)
            {
                foreach (vwMemberGridLookup memglu in originalRecords)
                {
                    ReportMember mem = Mapper.Map<vwMemberGridLookup, ReportMember>(memglu);
                    mems.Add(mem);
                }
            }
            return mems;

        }

    }
}