using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Donvi")]
    public partial class Donvi
    {
        public Donvi()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        [Key]
        [Column("madv")]
        [StringLength(10)]
        public string Madv { get; set; }
        [Required]
        [Column("donvitinh")]
        [StringLength(20)]
        public string Donvitinh { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [InverseProperty(nameof(Ctsanpham.MadvNavigation))]
        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
