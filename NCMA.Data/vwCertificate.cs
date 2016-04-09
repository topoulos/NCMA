namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vwCertificate
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1023)]
        public string FullName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1023)]
        public string InstructorsName { get; set; }

        [StringLength(255)]
        public string Dojo { get; set; }

        public string RankText { get; set; }

        [StringLength(255)]
        public string InstructorType { get; set; }

        [StringLength(255)]
        public string CertType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TournamentDate { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public bool? Completed { get; set; }

        public int? InstructorTypeID { get; set; }

        public int? TournamentID { get; set; }

        public int? MemberID { get; set; }

        public int? DojoID { get; set; }

        public int? InstructorID { get; set; }

        public int? CertificateTypeID { get; set; }
    }
}
