namespace Hackathon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Check-In")]
    public partial class Check_In
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int UID { get; set; }

        public int PID { get; set; }

        [StringLength(255)]
        public string Message { get; set; }

        public virtual Party Party { get; set; }

        public virtual User User { get; set; }
    }
}
