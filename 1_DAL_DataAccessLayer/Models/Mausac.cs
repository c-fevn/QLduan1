using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Mausac")]
    public partial class Mausac
    {
        public Mausac()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        [Key]
        [Column("mams")]
        [StringLength(10)]
        public string Mams { get; set; }
        [Required]
        [Column("mausac")]
        [StringLength(20)]
        public string Mausac1 { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [InverseProperty(nameof(Ctsanpham.MamsNavigation))]
        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
