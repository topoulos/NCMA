namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vwInactiveGridLookup")]
    public partial class vwInactiveGridLookup
    {
        [Key]
        [Column(Order = 0)]
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

        [StringLength(2)]
        public string State { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateJoined { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfRank { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Active { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateLastPaid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(500)]
        public string RankText { get; set; }
    }
}
