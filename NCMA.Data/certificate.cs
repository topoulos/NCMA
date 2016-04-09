namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("certificate")]
    public partial class certificate
    {
        public int id { get; set; }

        public int? MemberID { get; set; }

        [StringLength(50)]
        public string CertType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThruDate { get; set; }

        [StringLength(800)]
        public string RankText { get; set; }

        [StringLength(100)]
        public string InstructorType { get; set; }
    }
}
