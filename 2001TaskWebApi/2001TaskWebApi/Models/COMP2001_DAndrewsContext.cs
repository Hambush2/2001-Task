using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace _2001TaskWebApi.Models
{
    public partial class COMP2001_DAndrewsContext : DbContext
    {
        public COMP2001_DAndrewsContext()
        {
        }

        public COMP2001_DAndrewsContext(DbContextOptions<COMP2001_DAndrewsContext> options)
            : base(options)
        {
        }

//        public virtual DbSet<User> Users { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=socem1.uopnet.plymouth.ac.uk;Database=COMP2001_DAndrews;User Id=DAndrews;Password=QunX432+");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

//            modelBuilder.Entity<User>(entity =>
//            {
//                entity.Property(e => e.UserId)
//                    .ValueGeneratedNever()
//                    .HasColumnName("UserID");

//                entity.Property(e => e.Email)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Firstname)
//                    .IsRequired()
//                    .HasMaxLength(40)
//                    .IsUnicode(false);

//                entity.Property(e => e.Password)
//                    .IsRequired()
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Surname)
//                    .IsRequired()
//                    .HasMaxLength(40)
//                    .IsUnicode(false);
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
