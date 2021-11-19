using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Khachhang")]
    public partial class Khachhang
    {
        public Khachhang()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        [Key]
        [Column("makhach")]
        [StringLength(10)]
        public string Makhach { get; set; }
        [Required]
        [Column("tenkhach")]
        [StringLength(20)]
        public string Tenkhach { get; set; }
        [Required]
        [Column("diachi")]
        [StringLength(200)]
        public string Diachi { get; set; }
        [Required]
        [Column("sdt")]
        [StringLength(10)]
        public string Sdt { get; set; }
        [Required]
        [Column("gioitinh")]
        [StringLength(5)]
        public string Gioitinh { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [InverseProperty(nameof(Hoadon.MakhachNavigation))]
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
