//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCMAWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class membercert
    {
        public int ID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<int> DojoID { get; set; }
        public Nullable<int> CertificateTypeID { get; set; }
        public string RankText { get; set; }
        public Nullable<int> InstructorID { get; set; }
        public Nullable<int> InstructorTypeID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ThruDate { get; set; }
        public Nullable<bool> Completed { get; set; }
        public Nullable<int> TourneyID { get; set; }
    }
}
