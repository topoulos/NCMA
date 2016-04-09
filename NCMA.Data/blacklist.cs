namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("blacklist")]
    public partial class blacklist
    {
        public int ID { get; set; }

        public int? FormerMemberID { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Reason { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateListed { get; set; }
    }
}
