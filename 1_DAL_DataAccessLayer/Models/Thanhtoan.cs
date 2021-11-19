using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Thanhtoan")]
    public partial class Thanhtoan
    {
        [Key]
        [Column("mathanhtoan")]
        [StringLength(10)]
        public string Mathanhtoan { get; set; }
        [Required]
        [Column("mahoadon")]
        [StringLength(10)]
        public string Mahoadon { get; set; }
        [Column("ngaythanhtoan", TypeName = "date")]
        public DateTime Ngaythanhtoan { get; set; }
        [Column("sotienthanhtoan", TypeName = "decimal(12, 0)")]
        public decimal Sotienthanhtoan { get; set; }
        [Column("solan")]
        public int Solan { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [ForeignKey(nameof(Mahoadon))]
        [InverseProperty(nameof(Hoadon.Thanhtoans))]
        public virtual Hoadon MahoadonNavigation { get; set; }
    }
}
