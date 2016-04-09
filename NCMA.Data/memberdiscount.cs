namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("memberdiscount")]
    public partial class memberdiscount
    {
        public int ID { get; set; }

        public int? MemberDiscountPercentage { get; set; }

        public int? MemberID { get; set; }
    }
}
