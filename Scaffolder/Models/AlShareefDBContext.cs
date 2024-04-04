using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Scaffolder.Models
{
    public partial class AlShareefDBContext : DbContext
    {
        public AlShareefDBContext()
        {
        }

        public AlShareefDBContext(DbContextOptions<AlShareefDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AvailabilityStatus> AvailabilityStatuses { get; set; } = null!;
        public virtual DbSet<Building> Buildings { get; set; } = null!;
        public virtual DbSet<BusinessEntity> BusinessEntities { get; set; } = null!;
        public virtual DbSet<ClientType> ClientTypes { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Lead> Leads { get; set; } = null!;
        public virtual DbSet<LeadAttachment> LeadAttachments { get; set; } = null!;
        public virtual DbSet<LeadNote> LeadNotes { get; set; } = null!;
        public virtual DbSet<LeadPreference> LeadPreferences { get; set; } = null!;
        public virtual DbSet<LeadSource> LeadSources { get; set; } = null!;
        public virtual DbSet<LeadStatus> LeadStatuses { get; set; } = null!;
        public virtual DbSet<LeadType> LeadTypes { get; set; } = null!;
        public virtual DbSet<LeaseStatus> LeaseStatuses { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<UnitOccupancyStatus> UnitOccupancyStatuses { get; set; } = null!;
        public virtual DbSet<UnitStatus> UnitStatuses { get; set; } = null!;
        public virtual DbSet<UnitType> UnitTypes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<View> Views { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.10.20;Initial Catalog=AlShareefDB;User ID=sa;Password=NDZ@123;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailabilityStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(30);
            });

            modelBuilder.Entity<Building>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(50)
                    .HasColumnName("NameAR");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(50)
                    .HasColumnName("NameEN");
            });

            modelBuilder.Entity<BusinessEntity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(50)
                    .HasColumnName("NameAR");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(50)
                    .HasColumnName("NameEN");
            });

            modelBuilder.Entity<ClientType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Logo).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(50)
                    .HasColumnName("NameAR");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(50)
                    .HasColumnName("NameEN");
            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.Property(e => e.AlternateNo).HasMaxLength(15);

                entity.Property(e => e.AnnualRevenue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Company).HasMaxLength(300);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Designation).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Industry).HasMaxLength(20);

                entity.Property(e => e.LeadName).HasMaxLength(100);

                entity.Property(e => e.MaritalStatus).HasMaxLength(12);

                entity.Property(e => e.Mobile).HasMaxLength(15);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Nationality).HasMaxLength(20);

                entity.Property(e => e.PrefferedTimeToCall).HasMaxLength(20);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Website).HasMaxLength(100);

                entity.HasOne(d => d.ClientType)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.ClientTypeId)
                    .HasConstraintName("FK_ClientTypes");

                entity.HasOne(d => d.LeadOwner)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.LeadOwnerId)
                    .HasConstraintName("FK_LeadsOwner");

                entity.HasOne(d => d.LeadSource)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.LeadSourceId)
                    .HasConstraintName("FK_LeadSources");

                entity.HasOne(d => d.LeadStatus)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.LeadStatusId)
                    .HasConstraintName("FK_LeadsStatus");

                entity.HasOne(d => d.LeadType)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.LeadTypeId)
                    .HasConstraintName("FK_LeadsTypes");
            });

            modelBuilder.Entity<LeadAttachment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FilePath).HasMaxLength(200);

                entity.Property(e => e.FileSize).HasMaxLength(10);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadAttachments)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_LeadAttachments");
            });

            modelBuilder.Entity<LeadNote>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadNotes)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_LeadNotes");
            });

            modelBuilder.Entity<LeadPreference>(entity =>
            {
                entity.Property(e => e.Area).HasMaxLength(100);

                entity.Property(e => e.BuildingType).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DesiredLocation).HasMaxLength(50);

                entity.Property(e => e.DesiredMoveInDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PreferredNeighbourhood).HasMaxLength(50);

                entity.Property(e => e.PreferredPropertyType).HasMaxLength(50);

                entity.Property(e => e.PriceRange).HasMaxLength(50);

                entity.Property(e => e.ViewPreference).HasMaxLength(50);

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadPreferences)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_LeadPreferences");
            });

            modelBuilder.Entity<LeadSource>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Source).HasMaxLength(50);
            });

            modelBuilder.Entity<LeadStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(20);
            });

            modelBuilder.Entity<LeadType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(30);
            });

            modelBuilder.Entity<LeaseStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(30);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ElectricityMeterNo).HasMaxLength(20);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParkingBayNo).HasMaxLength(20);

                entity.Property(e => e.QatarCoolMeterNo).HasMaxLength(20);

                entity.Property(e => e.UnitBasicRent).HasMaxLength(20);

                entity.Property(e => e.UnitCode).HasMaxLength(20);

                entity.Property(e => e.UnitLayout).HasMaxLength(200);

                entity.Property(e => e.WaterMeterNo).HasMaxLength(20);
            });

            modelBuilder.Entity<UnitOccupancyStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(30);
            });

            modelBuilder.Entity<UnitStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(30);
            });

            modelBuilder.Entity<UnitType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BalconyArea).HasMaxLength(50);

                entity.Property(e => e.BasicRent).HasMaxLength(20);

                entity.Property(e => e.CoolingArea).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(20);

                entity.Property(e => e.ElectricityPrice).HasMaxLength(20);

                entity.Property(e => e.GasPrice).HasMaxLength(20);

                entity.Property(e => e.InternalUnitArea).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.QatarCoolPrice).HasMaxLength(20);

                entity.Property(e => e.TotalUnitArea).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(30);

                entity.Property(e => e.UnitTypeCode).HasMaxLength(20);

                entity.Property(e => e.WaterPrice).HasMaxLength(20);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Designation).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(12);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserRole).HasMaxLength(20);
            });

            modelBuilder.Entity<View>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
