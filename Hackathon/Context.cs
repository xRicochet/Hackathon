namespace Hackathon
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Chat> Chat { get; set; }
        public virtual DbSet<ChatMessenger> ChatMessenger { get; set; }
        public virtual DbSet<Check_In> Check_In { get; set; }
        public virtual DbSet<Commentaries> Commentaries { get; set; }
        public virtual DbSet<Party> Party { get; set; }
        public virtual DbSet<PartyPPL> PartyPPL { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Chat>()
                .HasMany(e => e.ChatMessenger)
                .WithRequired(e => e.Chat)
                .HasForeignKey(e => e.CID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChatMessenger>()
                .Property(e => e.Message)
                .IsFixedLength();

            modelBuilder.Entity<Check_In>()
                .Property(e => e.Message)
                .IsFixedLength();

            modelBuilder.Entity<Commentaries>()
                .Property(e => e.Message)
                .IsFixedLength();

            modelBuilder.Entity<Party>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Party>()
                .HasMany(e => e.Check_In)
                .WithRequired(e => e.Party)
                .HasForeignKey(e => e.PID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.Commentaries)
                .WithRequired(e => e.Party)
                .HasForeignKey(e => e.PID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.PartyPPL)
                .WithRequired(e => e.Party)
                .HasForeignKey(e => e.PID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.UserToken)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.FacebookId)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.GId)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.ProfilePic)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.ChatMessenger)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Check_In)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Commentaries)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PartyPPL)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UID)
                .WillCascadeOnDelete(false);
        }
    }
}
