using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Chatlieu")]
    public partial class Chatlieu
    {
        public Chatlieu()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        [Key]
        [Column("macl")]
        [StringLength(10)]
        public string Macl { get; set; }
        [Required]
        [Column("chatlieu")]
        [StringLength(20)]
        public string Chatlieu1 { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [InverseProperty(nameof(Ctsanpham.MaclNavigation))]
        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
