namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lineitem")]
    public partial class lineitem
    {
        public int ID { get; set; }

        public int productid { get; set; }

        public int qty { get; set; }

        public int discount { get; set; }

        public int invoiceid { get; set; }
    }
}
