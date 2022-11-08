using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("HoaDon")]
    [Index(nameof(Ma), Name = "UQ__HoaDon__3214CC9EEDFE93B8", IsUnique = true)]
    public partial class HoaDon
    {
        public HoaDon()
        {
            CttichDiems = new HashSet<CttichDiem>();
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdKH")]
        public Guid? IdKh { get; set; }
        [Column("IdNV")]
        public Guid? IdNv { get; set; }
        [Column("IdPTTT")]
        public Guid? IdPttt { get; set; }
        [Column("IdHT")]
        public Guid? IdHt { get; set; }
        [Column("IdUDTichDiem")]
        public Guid? IdUdtichDiem { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayThanhToan { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayShip { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayNhan { get; set; }
        [StringLength(50)]
        public string TenNguoiNhan { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(10)]
        public string Sdt { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? GiamGia { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TongTien { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? SoTienGiam { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TongTienSauKhiGiam { get; set; }
        public int? TienKhachDua { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdHt))]
        [InverseProperty(nameof(HinhThucMh.HoaDons))]
        public virtual HinhThucMh IdHtNavigation { get; set; }
        [ForeignKey(nameof(IdKh))]
        [InverseProperty(nameof(KhachHang.HoaDons))]
        public virtual KhachHang IdKhNavigation { get; set; }
        [ForeignKey(nameof(IdNv))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien IdNvNavigation { get; set; }
        [ForeignKey(nameof(IdPttt))]
        [InverseProperty(nameof(PtthanhToan.HoaDons))]
        public virtual PtthanhToan IdPtttNavigation { get; set; }
        [ForeignKey(nameof(IdUdtichDiem))]
        [InverseProperty(nameof(UdtichDiem.HoaDons))]
        public virtual UdtichDiem IdUdtichDiemNavigation { get; set; }
        [InverseProperty(nameof(CttichDiem.IdHoaDonNavigation))]
        public virtual ICollection<CttichDiem> CttichDiems { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdHoaDonNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
