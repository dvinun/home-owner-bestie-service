using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HomeOwnerBestie.LeadData.SQL.Models
{
    public partial class HomeOwnerBestieDBContext : DbContext
    {
        public HomeOwnerBestieDBContext()
        {
        }

        public HomeOwnerBestieDBContext(DbContextOptions<HomeOwnerBestieDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppUsers> AppUsers { get; set; }
        public virtual DbSet<RentValuationReports> RentValuationReports { get; set; }
        public virtual DbSet<UserAddresses> UserAddresses { get; set; }
        public virtual DbSet<UserIpaddresses> UserIpaddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=HomeOwnerBestieDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AppUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(256);

                entity.Property(e => e.LastName).HasMaxLength(256);

                entity.Property(e => e.Phone).HasMaxLength(24);
            });

            modelBuilder.Entity<RentValuationReports>(entity =>
            {
                entity.HasKey(e => e.RentValuationRecordId)
                    .HasName("PK_RentValuationData");

                entity.Property(e => e.RentValuationRecordId)
                    .HasColumnName("RentValuationRecordID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AverageMonthlyRent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.HomeOwnerSpecifiedRent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValuationRentHigh).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValuationRentLow).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValueChangedIn30Days).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentValuationReports)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentValuationData_AppUsers");
            });

            modelBuilder.Entity<UserAddresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.Property(e => e.AddressId)
                    .HasColumnName("AddressID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(128);

                entity.Property(e => e.County).HasMaxLength(128);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Street).HasMaxLength(512);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserAddresses_AppUsers");
            });

            modelBuilder.Entity<UserIpaddresses>(entity =>
            {
                entity.HasKey(e => e.IpaddressRecordId);

                entity.ToTable("UserIPAddresses");

                entity.Property(e => e.IpaddressRecordId)
                    .HasColumnName("IPAddressRecordID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(24);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserIpaddresses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIPAddresses_AppUsers");
            });
        }
    }
}
