namespace Hackathon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Party")]
    public partial class Party
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Party()
        {
            Check_In = new HashSet<Check_In>();
            Commentaries = new HashSet<Commentaries>();
            PartyPPL = new HashSet<PartyPPL>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Owner { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartsAt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndsAt { get; set; }

        public int? LocationLongitude { get; set; }

        public int? LocationLattitude { get; set; }

        public int? LocationName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Check_In> Check_In { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commentaries> Commentaries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyPPL> PartyPPL { get; set; }
    }
}
