using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Sanpham")]
    public partial class Sanpham
    {
        public Sanpham()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        [Key]
        [Column("masanpham")]
        [StringLength(10)]
        public string Masanpham { get; set; }
        [Required]
        [Column("tensanpham")]
        [StringLength(20)]
        public string Tensanpham { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [InverseProperty(nameof(Ctsanpham.MasanphamNavigation))]
        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
