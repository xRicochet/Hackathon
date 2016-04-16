using Hackathon.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Hackathon.Mapping
{
    public class PartyMapping:EntityTypeConfiguration<Party>
    {

        public PartyMapping()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired();
            Property(t => t.OwnerId).IsRequired();
            Property(t => t.StartsAt).IsRequired();
            ToTable("Party");
        }
    }
}