using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KhachHang")]
    [Index(nameof(Ma), Name = "UQ__KhachHan__3214CC9EFA140D70", IsUnique = true)]
    [Index(nameof(Email), Name = "UQ__KhachHan__A9D10534621E531E", IsUnique = true)]
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IDTichDiem")]
        public Guid? IdtichDiem { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        [StringLength(30)]
        public string TenDem { get; set; }
        [StringLength(30)]
        public string Ho { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(10)]
        public string Sdt { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdtichDiem))]
        [InverseProperty(nameof(TichDiem.KhachHangs))]
        public virtual TichDiem IdtichDiemNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.IdKhNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
