using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1_DAL_DataAccessLayer.Models;

#nullable disable

namespace _1_DAL_DataAccessLayer.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chatlieu> Chatlieus { get; set; }
        public virtual DbSet<Chitiethoadon> Chitiethoadons { get; set; }
        public virtual DbSet<Ctsanpham> Ctsanphams { get; set; }
        public virtual DbSet<Dichvu> Dichvus { get; set; }
        public virtual DbSet<Donvi> Donvis { get; set; }
        public virtual DbSet<Hinhanh> Hinhanhs { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Loaidichvu> Loaidichvus { get; set; }
        public virtual DbSet<Loaisanpham> Loaisanphams { get; set; }
        public virtual DbSet<Mausac> Mausacs { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }
        public virtual DbSet<Thanhtoan> Thanhtoans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-ALHDGS7\\SQLEXPRESS;Initial Catalog=DUAN1QLNT1;User ID=ap1;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chatlieu>(entity =>
            {
                entity.HasKey(e => e.Macl)
                    .HasName("PK__Chatlieu__7A21F84211FF82C9");

                entity.Property(e => e.Macl).IsUnicode(false);
            });

            modelBuilder.Entity<Chitiethoadon>(entity =>
            {
                entity.HasKey(e => e.MaCtdh)
                    .HasName("PK__Chitieth__FD2652FE117F42E1");

                entity.Property(e => e.MaCtdh).IsUnicode(false);

                entity.Property(e => e.Mactsanpham).IsUnicode(false);

                entity.Property(e => e.Madichvu).IsUnicode(false);

                entity.Property(e => e.Mahoadon).IsUnicode(false);

                entity.HasOne(d => d.MactsanphamNavigation)
                    .WithMany(p => p.Chitiethoadons)
                    .HasForeignKey(d => d.Mactsanpham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ct2");

                entity.HasOne(d => d.MadichvuNavigation)
                    .WithMany(p => p.Chitiethoadons)
                    .HasForeignKey(d => d.Madichvu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ct3");

                entity.HasOne(d => d.MahoadonNavigation)
                    .WithMany(p => p.Chitiethoadons)
                    .HasForeignKey(d => d.Mahoadon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ct1");
            });

            modelBuilder.Entity<Ctsanpham>(entity =>
            {
                entity.HasKey(e => e.Mactsanpham)
                    .HasName("PK__CTsanpha__6C4113C2B07F6AE9");

                entity.Property(e => e.Mactsanpham).IsUnicode(false);

                entity.Property(e => e.Macl).IsUnicode(false);

                entity.Property(e => e.Madv).IsUnicode(false);

                entity.Property(e => e.Mahh).IsUnicode(false);

                entity.Property(e => e.Maloaisp).IsUnicode(false);

                entity.Property(e => e.Mams).IsUnicode(false);

                entity.Property(e => e.Masanpham).IsUnicode(false);

                entity.HasOne(d => d.MaclNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Macl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sp4");

                entity.HasOne(d => d.MadvNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Madv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sp6");

                entity.HasOne(d => d.MahhNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Mahh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sp3");

                entity.HasOne(d => d.MaloaispNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Maloaisp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sp2");

                entity.HasOne(d => d.MamsNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Mams)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sp5");

                entity.HasOne(d => d.MasanphamNavigation)
                    .WithMany(p => p.Ctsanphams)
                    .HasForeignKey(d => d.Masanpham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sp1");
            });

            modelBuilder.Entity<Dichvu>(entity =>
            {
                entity.HasKey(e => e.Madichvu)
                    .HasName("PK__Dichvu__7EA7308E445BCE10");

                entity.Property(e => e.Madichvu).IsUnicode(false);

                entity.Property(e => e.Maloaidichvu).IsUnicode(false);

                entity.HasOne(d => d.MaloaidichvuNavigation)
                    .WithMany(p => p.Dichvus)
                    .HasForeignKey(d => d.Maloaidichvu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Dichvu__maloaidi__30F848ED");
            });

            modelBuilder.Entity<Donvi>(entity =>
            {
                entity.HasKey(e => e.Madv)
                    .HasName("PK__Donvi__7A21E02959FF900F");

                entity.Property(e => e.Madv).IsUnicode(false);
            });

            modelBuilder.Entity<Hinhanh>(entity =>
            {
                entity.HasKey(e => e.Mahh)
                    .HasName("PK__Hinhanh__7A2100A2CF30EDC8");

                entity.Property(e => e.Mahh).IsUnicode(false);
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.Mahoadon)
                    .HasName("PK__Hoadon__8C708E0C1EA136DC");

                entity.Property(e => e.Mahoadon).IsUnicode(false);

                entity.Property(e => e.Makhach).IsUnicode(false);

                entity.Property(e => e.Manhanvien).IsUnicode(false);

                entity.HasOne(d => d.MakhachNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Makhach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk1");

                entity.HasOne(d => d.ManhanvienNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Manhanvien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk2");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Makhach)
                    .HasName("PK__Khachhan__98E32F154598FD68");

                entity.Property(e => e.Makhach).IsUnicode(false);
            });

            modelBuilder.Entity<Loaidichvu>(entity =>
            {
                entity.HasKey(e => e.Maloaidichvu)
                    .HasName("PK__Loaidich__A819571068BC9BF6");

                entity.Property(e => e.Maloaidichvu).IsUnicode(false);
            });

            modelBuilder.Entity<Loaisanpham>(entity =>
            {
                entity.HasKey(e => e.Maloaisp)
                    .HasName("PK__Loaisanp__F57B12AEB5001AAF");

                entity.Property(e => e.Maloaisp).IsUnicode(false);
            });

            modelBuilder.Entity<Mausac>(entity =>
            {
                entity.HasKey(e => e.Mams)
                    .HasName("PK__Mausac__7A21CB83DF4EDE90");

                entity.Property(e => e.Mams).IsUnicode(false);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manhanvien)
                    .HasName("PK__Nhanvien__75A28B527716097F");

                entity.Property(e => e.Manhanvien).IsUnicode(false);
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.Masanpham)
                    .HasName("PK__Sanpham__8F121B2FDEEAC623");

                entity.Property(e => e.Masanpham).IsUnicode(false);
            });

            modelBuilder.Entity<Thanhtoan>(entity =>
            {
                entity.HasKey(e => e.Mathanhtoan)
                    .HasName("PK__Thanhtoa__8C448CA53C6C2B6B");

                entity.Property(e => e.Mathanhtoan).IsUnicode(false);

                entity.Property(e => e.Mahoadon).IsUnicode(false);

                entity.HasOne(d => d.MahoadonNavigation)
                    .WithMany(p => p.Thanhtoans)
                    .HasForeignKey(d => d.Mahoadon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Thanhtoan__mahoa__2C3393D0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
