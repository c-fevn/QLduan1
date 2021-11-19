using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Dichvu")]
    public partial class Dichvu
    {
        public Dichvu()
        {
            Chitiethoadons = new HashSet<Chitiethoadon>();
        }

        [Key]
        [Column("madichvu")]
        [StringLength(10)]
        public string Madichvu { get; set; }
        [Required]
        [Column("maloaidichvu")]
        [StringLength(10)]
        public string Maloaidichvu { get; set; }
        [Required]
        [Column("tendichvu")]
        [StringLength(20)]
        public string Tendichvu { get; set; }
        [Column("giadichvu", TypeName = "decimal(12, 0)")]
        public decimal Giadichvu { get; set; }
        [Column("ngaysudungdichvu", TypeName = "date")]
        public DateTime Ngaysudungdichvu { get; set; }
        [Required]
        [Column("trangthai")]
        [StringLength(10)]
        public string Trangthai { get; set; }

        [ForeignKey(nameof(Maloaidichvu))]
        [InverseProperty(nameof(Loaidichvu.Dichvus))]
        public virtual Loaidichvu MaloaidichvuNavigation { get; set; }
        [InverseProperty(nameof(Chitiethoadon.MadichvuNavigation))]
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
    }
}
