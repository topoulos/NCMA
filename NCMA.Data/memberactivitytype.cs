namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("memberactivitytype")]
    public partial class memberactivitytype
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
