namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tournament")]
    public partial class tournament
    {
        public int ID { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string Address1 { get; set; }

        [StringLength(255)]
        public string Address2 { get; set; }

        [StringLength(255)]
        public string Address3 { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        public int? StateID { get; set; }

        [StringLength(12)]
        public string PostalCode { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TournDate { get; set; }
    }
}
