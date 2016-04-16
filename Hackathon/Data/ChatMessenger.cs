namespace Hackathon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChatMessenger")]
    public partial class ChatMessenger
    {
        public int Id { get; set; }

        public int UID { get; set; }

        public int CID { get; set; }

        [Required]
        [StringLength(255)]
        public string Message { get; set; }

        [Column(TypeName = "date")]
        public DateTime Timestamp { get; set; }

        public virtual Chat Chat { get; set; }

        public virtual User User { get; set; }
    }
}
