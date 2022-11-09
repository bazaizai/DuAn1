using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KieuSP")]
    [Index(nameof(Ma), Name = "UQ__KieuSP__3214CC9E4723D16C", IsUnique = true)]
    public partial class KieuSp
    {
        public KieuSp()
        {
            ChiTietKieuSps = new HashSet<ChiTietKieuSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietKieuSp.IdKieuSpNavigation))]
        public virtual ICollection<ChiTietKieuSp> ChiTietKieuSps { get; set; }
    }
}
