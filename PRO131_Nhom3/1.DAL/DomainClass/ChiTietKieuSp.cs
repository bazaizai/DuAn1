using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietKieuSP")]
    public partial class ChiTietKieuSp
    {
        public ChiTietKieuSp()
        {
            InverseIdChaNavigation = new HashSet<ChiTietKieuSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdKieuSP")]
        public Guid? IdKieuSp { get; set; }
        public Guid? IdCha { get; set; }
        [Column("IdChiTietSP")]
        public Guid? IdChiTietSp { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdCha))]
        [InverseProperty(nameof(ChiTietKieuSp.InverseIdChaNavigation))]
        public virtual ChiTietKieuSp IdChaNavigation { get; set; }
        [ForeignKey(nameof(IdChiTietSp))]
        [InverseProperty(nameof(ChiTietSp.ChiTietKieuSps))]
        public virtual ChiTietSp IdChiTietSpNavigation { get; set; }
        [ForeignKey(nameof(IdKieuSp))]
        [InverseProperty(nameof(KieuSp.ChiTietKieuSps))]
        public virtual KieuSp IdKieuSpNavigation { get; set; }
        [InverseProperty(nameof(ChiTietKieuSp.IdChaNavigation))]
        public virtual ICollection<ChiTietKieuSp> InverseIdChaNavigation { get; set; }
    }
}
