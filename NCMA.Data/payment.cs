namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("payment")]
    public partial class payment
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime paymentdate { get; set; }

        public int invoiceid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal paymentamount { get; set; }

        public string description { get; set; }
    }
}
