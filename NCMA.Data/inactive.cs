namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("inactive")]
    public partial class inactive
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string MiddleName { get; set; }

        [StringLength(255)]
        public string Suffix { get; set; }

        [StringLength(255)]
        public string Address1 { get; set; }

        [StringLength(255)]
        public string Address2 { get; set; }

        [StringLength(255)]
        public string Address3 { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        public int? StateID { get; set; }

        public int? CountryID { get; set; }

        [StringLength(12)]
        public string PostalCode { get; set; }

        [StringLength(20)]
        public string HomePhone { get; set; }

        [StringLength(20)]
        public string CellPhone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        public int? PlanID { get; set; }

        public int? DojoID { get; set; }

        public int? MemberTypeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateJoined { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfRank { get; set; }

        [StringLength(500)]
        public string RankText { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Active { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateInactive { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateLastPaid { get; set; }

        [Column(TypeName = "text")]
        public string Comments { get; set; }
    }
}
