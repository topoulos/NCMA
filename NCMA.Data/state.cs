namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("state")]
    public partial class state
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string StateName { get; set; }

        [StringLength(2)]
        public string StateAbbrev { get; set; }
    }
}
