using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonView
    {
        public Guid Id { get; set; }
        public Guid? IdKh { get; set; }
        public Guid? IdtichDiem { get; set; }
        public int? SoDiem { get; set; }
        public string TenKh { get; set; }
        public string TenDemKh { get; set; }
        public string HoKh { get; set; }
        public Guid? IdNv { get; set; }
        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string TenDemNv { get; set; }
        public string HoNv { get; set; }
        public Guid? IdPttt { get; set; }
        public string MaPttt { get; set; }
        public string TenPttt { get; set; }
        public Guid? IdHt { get; set; }
        public string MaHt { get; set; }
        [StringLength(50)]
        public string TenHt { get; set; }
        public string MaHD { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public DateTime? NgayShip { get; set; }
        public DateTime? NgayNhan { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChiNhan { get; set; }
        public string SdtNhanHang { get; set; }
        public decimal? GiamGia { get; set; }
        public string MoTa { get; set; }
        public decimal? TongTien { get; set; }
        public decimal? SoTienGiam { get; set; }
        public decimal? TongTienSauKhiGiam { get; set; }
        public int? TienKhachDua { get; set; }
        public int? TrangThai { get; set; }
    }
}
