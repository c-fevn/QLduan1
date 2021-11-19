using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Loaidichvu")]
    public partial class Loaidichvu
    {
        public Loaidichvu()
        {
            Dichvus = new HashSet<Dichvu>();
        }

        [Key]
        [Column("maloaidichvu")]
        [StringLength(10)]
        public string Maloaidichvu { get; set; }
        [Required]
        [Column("tenloaidichvu")]
        [StringLength(20)]
        public string Tenloaidichvu { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [InverseProperty(nameof(Dichvu.MaloaidichvuNavigation))]
        public virtual ICollection<Dichvu> Dichvus { get; set; }
    }
}
