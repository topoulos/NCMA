namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cert
    {
        public int ID { get; set; }

        public int? MemberID { get; set; }

        public int? InstructorID { get; set; }

        public int? CertTypeID { get; set; }

        public bool? Completed { get; set; }

        public int? MemberActivityID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CertDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }

        public int? TourneyID { get; set; }
    }
}
