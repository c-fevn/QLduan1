using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Loaisanpham")]
    public partial class Loaisanpham
    {
        public Loaisanpham()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        [Key]
        [Column("maloaisp")]
        [StringLength(10)]
        public string Maloaisp { get; set; }
        [Required]
        [Column("tenloaisanpham")]
        [StringLength(20)]
        public string Tenloaisanpham { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [InverseProperty(nameof(Ctsanpham.MaloaispNavigation))]
        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
