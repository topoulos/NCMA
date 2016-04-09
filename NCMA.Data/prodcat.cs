namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prodcat")]
    public partial class prodcat
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string prodcatname { get; set; }
    }
}
