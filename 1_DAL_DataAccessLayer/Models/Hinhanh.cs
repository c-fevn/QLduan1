using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Hinhanh")]
    public partial class Hinhanh
    {
        public Hinhanh()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        [Key]
        [Column("mahh")]
        [StringLength(10)]
        public string Mahh { get; set; }
        [Required]
        [Column("hinhanh")]
        [StringLength(400)]
        public string Hinhanh1 { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [InverseProperty(nameof(Ctsanpham.MahhNavigation))]
        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
