namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("memberactivity")]
    public partial class memberactivity
    {
        public int ID { get; set; }

        public int? TypeID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ActivityDate { get; set; }

        public int? MemberID { get; set; }

        public string ActivityDescription { get; set; }
    }
}
