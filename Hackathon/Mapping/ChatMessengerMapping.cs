using Hackathon.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Hackathon.Mapping
{
    public class ChatMessengerMapping:EntityTypeConfiguration<ChatMessenger>
    {

        public ChatMessengerMapping()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.UserId).IsRequired();
            Property(t => t.ChatId).IsRequired();
            Property(t => t.Message).IsRequired();
            Property(t => t.Timestamp).IsRequired();
            ToTable("ChatMessenger");
        }
    }
}