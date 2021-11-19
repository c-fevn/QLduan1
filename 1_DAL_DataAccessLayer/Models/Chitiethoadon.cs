using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Chitiethoadon")]
    public partial class Chitiethoadon
    {
        [Key]
        [Column("maCTDH")]
        [StringLength(10)]
        public string MaCtdh { get; set; }
        [Required]
        [Column("mahoadon")]
        [StringLength(10)]
        public string Mahoadon { get; set; }
        [Required]
        [Column("mactsanpham")]
        [StringLength(10)]
        public string Mactsanpham { get; set; }
        [Required]
        [Column("madichvu")]
        [StringLength(10)]
        public string Madichvu { get; set; }
        [Column("soluong")]
        public int Soluong { get; set; }
        [Column("dongia", TypeName = "decimal(12, 0)")]
        public decimal Dongia { get; set; }
        [Column("ngaygiaohang", TypeName = "date")]
        public DateTime Ngaygiaohang { get; set; }
        [Column("tongtienthanhtoan", TypeName = "decimal(12, 0)")]
        public decimal Tongtienthanhtoan { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [ForeignKey(nameof(Mactsanpham))]
        [InverseProperty(nameof(Ctsanpham.Chitiethoadons))]
        public virtual Ctsanpham MactsanphamNavigation { get; set; }
        [ForeignKey(nameof(Madichvu))]
        [InverseProperty(nameof(Dichvu.Chitiethoadons))]
        public virtual Dichvu MadichvuNavigation { get; set; }
        [ForeignKey(nameof(Mahoadon))]
        [InverseProperty(nameof(Hoadon.Chitiethoadons))]
        public virtual Hoadon MahoadonNavigation { get; set; }
    }
}
