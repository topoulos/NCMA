using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportLibrary.MemberReports
{
    public class Member
    {
        public string FullName { get; set; }
        public string Last { get; set; }
        public string First { get; set; }
        public string Country { get; set; }
        public string Dojo { get; set; }
        public string MemType { get; set; }
        public string State { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? DateOfRank { get; set; }
        public int? Active { get; set; }
        public DateTime? DateLastPaid { get; set; }
        public int? ID { get; set; }
        public string RankText { get; set; } 

    }
}
