namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dojoinstructor")]
    public partial class dojoinstructor
    {
        public int ID { get; set; }

        public int DojoID { get; set; }

        public int? InstructorID { get; set; }

        public int? InstructorTypeID { get; set; }
    }
}
