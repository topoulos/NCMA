namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("instructortype")]
    public partial class instructortype
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string InstructorTypeName { get; set; }
    }
}
