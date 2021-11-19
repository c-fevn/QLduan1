using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("CTsanpham")]
    public partial class Ctsanpham
    {
        public Ctsanpham()
        {
            Chitiethoadons = new HashSet<Chitiethoadon>();
        }

        [Key]
        [Column("mactsanpham")]
        [StringLength(10)]
        public string Mactsanpham { get; set; }
        [Required]
        [Column("masanpham")]
        [StringLength(10)]
        public string Masanpham { get; set; }
        [Required]
        [Column("maloaisp")]
        [StringLength(10)]
        public string Maloaisp { get; set; }
        [Column("soluong")]
        public int Soluong { get; set; }
        [Column("giaban", TypeName = "decimal(12, 0)")]
        public decimal Giaban { get; set; }
        [Required]
        [Column("mahh")]
        [StringLength(10)]
        public string Mahh { get; set; }
        [Required]
        [Column("macl")]
        [StringLength(10)]
        public string Macl { get; set; }
        [Required]
        [Column("mams")]
        [StringLength(10)]
        public string Mams { get; set; }
        [Required]
        [Column("madv")]
        [StringLength(10)]
        public string Madv { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [ForeignKey(nameof(Macl))]
        [InverseProperty(nameof(Chatlieu.Ctsanphams))]
        public virtual Chatlieu MaclNavigation { get; set; }
        [ForeignKey(nameof(Madv))]
        [InverseProperty(nameof(Donvi.Ctsanphams))]
        public virtual Donvi MadvNavigation { get; set; }
        [ForeignKey(nameof(Mahh))]
        [InverseProperty(nameof(Hinhanh.Ctsanphams))]
        public virtual Hinhanh MahhNavigation { get; set; }
        [ForeignKey(nameof(Maloaisp))]
        [InverseProperty(nameof(Loaisanpham.Ctsanphams))]
        public virtual Loaisanpham MaloaispNavigation { get; set; }
        [ForeignKey(nameof(Mams))]
        [InverseProperty(nameof(Mausac.Ctsanphams))]
        public virtual Mausac MamsNavigation { get; set; }
        [ForeignKey(nameof(Masanpham))]
        [InverseProperty(nameof(Sanpham.Ctsanphams))]
        public virtual Sanpham MasanphamNavigation { get; set; }
        [InverseProperty(nameof(Chitiethoadon.MactsanphamNavigation))]
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
    }
}
