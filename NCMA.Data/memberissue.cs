namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("memberissue")]
    public partial class memberissue
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? MemberID { get; set; }

        public int? IssueID { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? IssueDate { get; set; }
    }
}
