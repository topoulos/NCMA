namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class membercert
    {
        public int ID { get; set; }

        public int? MemberID { get; set; }

        public int? DojoID { get; set; }

        public int? CertificateTypeID { get; set; }

        public string RankText { get; set; }

        public int? InstructorID { get; set; }

        public int? InstructorTypeID { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public bool? Completed { get; set; }

        public int? TourneyID { get; set; }
    }
}
