namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string productname { get; set; }

        public int categoryid { get; set; }

        public int? duration { get; set; }

        [Column(TypeName = "numeric")]
        public decimal amount { get; set; }
    }
}
