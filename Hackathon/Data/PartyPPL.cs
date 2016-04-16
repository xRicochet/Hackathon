namespace Hackathon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartyPPL")]
    public partial class PartyPPL
    {
        public int Id { get; set; }

        public int UID { get; set; }

        public int PID { get; set; }

        public virtual Party Party { get; set; }

        public virtual User User { get; set; }
    }
}
