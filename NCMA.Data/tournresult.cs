namespace NCMA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tournresult")]
    public partial class tournresult
    {
        public int ID { get; set; }

        public int? TournamentID { get; set; }

        public int? MemberID { get; set; }

        public int? TournAcheivementTypeID { get; set; }

        public int? TournDivisionID { get; set; }

        public int? TournCompTypeID { get; set; }
    }
}
