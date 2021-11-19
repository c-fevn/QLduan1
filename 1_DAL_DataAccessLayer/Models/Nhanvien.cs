using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Nhanvien")]
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        [Key]
        [Column("manhanvien")]
        [StringLength(10)]
        public string Manhanvien { get; set; }
        [Required]
        [Column("tennhanvien")]
        [StringLength(20)]
        public string Tennhanvien { get; set; }
        [Required]
        [Column("sdt")]
        [StringLength(10)]
        public string Sdt { get; set; }
        [Required]
        [Column("diachi")]
        [StringLength(200)]
        public string Diachi { get; set; }
        [Column("vaitro")]
        public int Vaitro { get; set; }
        [Required]
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [Column("matkhau")]
        [StringLength(20)]
        public string Matkhau { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [InverseProperty(nameof(Hoadon.ManhanvienNavigation))]
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
