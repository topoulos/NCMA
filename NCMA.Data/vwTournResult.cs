namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vwTournResult")]
    public partial class vwTournResult
    {
        public int? MemberID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tournresultid { get; set; }

        public int? TournamentID { get; set; }

        public int? TournAcheivementTypeID { get; set; }

        public int? TournDivisionID { get; set; }

        public int? TournCompTypeID { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TournDate { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(1023)]
        public string FullName { get; set; }

        [StringLength(255)]
        public string Last { get; set; }

        [StringLength(255)]
        public string First { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        [StringLength(255)]
        public string Dojo { get; set; }

        [StringLength(255)]
        public string MemType { get; set; }

        [StringLength(255)]
        public string Rank { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateJoined { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfRank { get; set; }

        public int? Active { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateLastPaid { get; set; }

        [StringLength(255)]
        public string tourncomptypename { get; set; }

        [StringLength(2)]
        public string tournstate { get; set; }

        [StringLength(255)]
        public string tournachievementtypename { get; set; }

        [StringLength(255)]
        public string tournachievementtypedesc { get; set; }

        [StringLength(255)]
        public string tourndivisionname { get; set; }

        [StringLength(255)]
        public string tourndivisiondesc { get; set; }

        [StringLength(255)]
        public string tourncomptypedesc { get; set; }
    }
}
