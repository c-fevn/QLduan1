using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Hoadon")]
    public partial class Hoadon
    {
        public Hoadon()
        {
            Chitiethoadons = new HashSet<Chitiethoadon>();
            Thanhtoans = new HashSet<Thanhtoan>();
        }

        [Key]
        [Column("mahoadon")]
        [StringLength(10)]
        public string Mahoadon { get; set; }
        [Required]
        [Column("makhach")]
        [StringLength(10)]
        public string Makhach { get; set; }
        [Required]
        [Column("manhanvien")]
        [StringLength(10)]
        public string Manhanvien { get; set; }
        [Column("ngaydathang", TypeName = "date")]
        public DateTime Ngaydathang { get; set; }
        [Column("tiendatcoc", TypeName = "decimal(12, 0)")]
        public decimal Tiendatcoc { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [ForeignKey(nameof(Makhach))]
        [InverseProperty(nameof(Khachhang.Hoadons))]
        public virtual Khachhang MakhachNavigation { get; set; }
        [ForeignKey(nameof(Manhanvien))]
        [InverseProperty(nameof(Nhanvien.Hoadons))]
        public virtual Nhanvien ManhanvienNavigation { get; set; }
        [InverseProperty(nameof(Chitiethoadon.MahoadonNavigation))]
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
        [InverseProperty(nameof(Thanhtoan.MahoadonNavigation))]
        public virtual ICollection<Thanhtoan> Thanhtoans { get; set; }
    }
}
