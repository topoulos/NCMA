namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("applicant")]
    public partial class applicant
    {
        public int id { get; set; }

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

        [Column(TypeName = "datetime2")]
        public DateTime? DOB { get; set; }

        public int? PlanID { get; set; }

        [Column(TypeName = "text")]
        public string About { get; set; }

        [StringLength(255)]
        public string Style { get; set; }

        public bool? Approved { get; set; }

        public bool? InputIntoNCMA { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ApprovedDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? SubmitDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? InputIntoNCMADate { get; set; }

        [StringLength(255)]
        public string DojoName { get; set; }
    }
}
