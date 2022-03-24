using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Patches
{
    public partial class patchdbContext : DbContext
    {
        //public patchdbContext()
        //{
        //}

        public patchdbContext(DbContextOptions<patchdbContext> options)
            : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql(
        //        "Server=localhost;Database=patchdb;UID=root;PWD=batoolhammoud95_mysql;",
        //        new MySqlServerVersion(new Version(8, 0, 21))
        //    );
        //}

        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<D> Ds { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<DesktopPribter> DesktopPribters { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<Headofdept> Headofdepts { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Patch> Patches { get; set; }
        public virtual DbSet<staff> staff { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySql("server=localhost;database=patchdb;uid=root;pwd=batoolhammoud95_mysql", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.21-mysql"));
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Building>(entity =>
            {
                entity.HasKey(e => e.Idbuildings)
                    .HasName("PRIMARY");

                entity.ToTable("buildings");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_bin");

                entity.Property(e => e.Idbuildings).HasColumnName("idbuildings");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<D>(entity =>
            {
                entity.HasKey(e => e.Idds)
                    .HasName("PRIMARY");

                entity.ToTable("ds");

                entity.Property(e => e.Idds).HasColumnName("idds");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.Iddepts)
                    .HasName("PRIMARY");

                entity.ToTable("depts");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_bin");

                entity.HasIndex(e => e.FloorId, "dept_floor_fk_idx");

                entity.Property(e => e.Iddepts).HasColumnName("iddepts");

                entity.Property(e => e.FloorId).HasColumnName("floor-id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.Floor)
                    .WithMany(p => p.Depts)
                    .HasForeignKey(d => d.FloorId)
                    .HasConstraintName("dept_floor_fk");
            });

            modelBuilder.Entity<DesktopPribter>(entity =>
            {
                entity.HasKey(e => e.IddesktopPribter)
                    .HasName("PRIMARY");

                entity.ToTable("desktop-pribter");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_bin");

                entity.HasIndex(e => e.DsId, "desktop-ds-fk_idx");

                entity.HasIndex(e => e.OfficeId, "desktop-office-fk_idx");

                entity.Property(e => e.IddesktopPribter).HasColumnName("iddesktop-pribter");

                entity.Property(e => e.Av).HasColumnName("av");

                entity.Property(e => e.Dc).HasColumnName("dc");

                entity.Property(e => e.DsId).HasColumnName("ds-id");

                entity.Property(e => e.Em)
                    .HasMaxLength(255)
                    .HasColumnName("em");

                entity.Property(e => e.Ex).HasColumnName("ex");

                entity.Property(e => e.Ip)
                    .HasMaxLength(255)
                    .HasColumnName("ip");

                entity.Property(e => e.OfficeId).HasColumnName("office-id");

                entity.Property(e => e.User)
                    .HasMaxLength(255)
                    .HasColumnName("user");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DesktopPribters)
                    .HasForeignKey(d => d.DsId)
                    .HasConstraintName("desktop-ds-fk");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.DesktopPribters)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("desktop-office-fk");
            });

            modelBuilder.Entity<Floor>(entity =>
            {
                entity.HasKey(e => e.Idfloors)
                    .HasName("PRIMARY");

                entity.ToTable("floors");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_bin");

                entity.HasIndex(e => e.Building, "floor_building_fk_idx");

                entity.Property(e => e.Idfloors).HasColumnName("idfloors");

                entity.Property(e => e.Building).HasColumnName("building");

                entity.Property(e => e.FloorNo).HasColumnName("floor-No");

                entity.HasOne(d => d.BuildingNavigation)
                    .WithMany(p => p.Floors)
                    .HasForeignKey(d => d.Building)
                    .HasConstraintName("floor_building_fk");
            });

            modelBuilder.Entity<Headofdept>(entity =>
            {
                entity.HasKey(e => e.Idheadofdept)
                    .HasName("PRIMARY");

                entity.ToTable("headofdept");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_bin");

                entity.HasIndex(e => e.DeptId, "head-dept-fk_idx");

                entity.HasIndex(e => e.OfficeId, "head-office-fk_idx");

                entity.HasIndex(e => e.StaffId, "head-staff_idx");

                entity.Property(e => e.Idheadofdept).HasColumnName("idheadofdept");

                entity.Property(e => e.DeptId).HasColumnName("dept-id");

                entity.Property(e => e.OfficeId).HasColumnName("office-id");

                entity.Property(e => e.StaffId).HasColumnName("staff-id");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Headofdepts)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("head-dept-fk");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Headofdepts)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("head-office-fk");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Headofdepts)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("head-staff-fk");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.HasKey(e => e.Idoffice)
                    .HasName("PRIMARY");

                entity.ToTable("office");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_bin");

                entity.Property(e => e.Idoffice).HasColumnName("idoffice");

                entity.Property(e => e.DeptId).HasColumnName("dept-id");

                entity.Property(e => e.OfficeNo).HasColumnName("office-No");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Patch>(entity =>
            {
                entity.HasKey(e => e.Idpatches)
                    .HasName("PRIMARY");

                entity.ToTable("patches");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_bin");

                entity.HasIndex(e => e.OfficeId, "patch-dept-fk_idx");

                entity.Property(e => e.Idpatches).HasColumnName("idpatches");

                entity.Property(e => e.BoxNo).HasColumnName("box-no");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .HasColumnName("notes");

                entity.Property(e => e.OfficeId).HasColumnName("office-id");

                entity.Property(e => e.PatchNo).HasColumnName("patch-no");

                entity.Property(e => e.PatchSlot)
                    .HasMaxLength(255)
                    .HasColumnName("patch-slot");

                entity.Property(e => e.RoomNo).HasColumnName("room-no");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Patches)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("patch-office-fk");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasKey(e => e.Idstaff)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_bin");

                entity.HasIndex(e => e.OfficeId, "staff-office-fk_idx");

                entity.Property(e => e.Idstaff).HasColumnName("idstaff");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OfficeId).HasColumnName("office-id");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("staff-office-fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
