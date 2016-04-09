namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vwInvoice")]
    public partial class vwInvoice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int productid { get; set; }

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

        [StringLength(12)]
        public string PostalCode { get; set; }

        [StringLength(20)]
        public string HomePhone { get; set; }

        [StringLength(20)]
        public string CellPhone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string country { get; set; }

        [StringLength(2)]
        public string state { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateJoined { get; set; }

        public int? Active { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateLastPaid { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateInactive { get; set; }

        [Column(TypeName = "text")]
        public string Comments { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InvoiceDate { get; set; }

        public int? MemberID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lineitemid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int qty { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int discount { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int invoiceid { get; set; }

        [StringLength(255)]
        public string productname { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int prodcatid { get; set; }

        public int? prodduration { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "numeric")]
        public decimal prodamt { get; set; }

        [StringLength(255)]
        public string prodcatname { get; set; }
    }
}
