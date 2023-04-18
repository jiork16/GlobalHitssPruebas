using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace APIRESTHITSS.Models
{
    public partial class GLOBALHITSSContext : DbContext
    {
        private readonly string _connectionStrings;
        public GLOBALHITSSContext(string connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }
        protected GLOBALHITSSContext(DbContextOptions contextOptions,string connectionStrings)
        : base(contextOptions)
        {
            _connectionStrings = connectionStrings;
        }

        public GLOBALHITSSContext(DbContextOptions<GLOBALHITSSContext> options, string connectionStrings)
            : base(options)
        {
            _connectionStrings = connectionStrings;
        }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(_connectionStrings);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ci)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CI");

                entity.Property(e => e.DateBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_birth");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.HomeAdress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("home_adress");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.PhoneNumer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_numer");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
