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
    public class ChiTietSpView
    {
        public Guid Id { get; set; }
        public Guid? IdSp { get; set; }
        public Guid? IdMauSac { get; set; }
        public Guid? IdSize { get; set; }
        public Guid? IdGiaiDau { get; set; }
        public Guid? IdTeam { get; set; }
        public Guid? IdChatLieu { get; set; }
        public string BaoHanh { get; set; }
        public string MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
        public int? TrangThai { get; set; }
        public int? TrangThaiKhuyenMai { get; set; }

        public ChiTietSpView(Guid id, Guid? idSp, Guid? idMauSac, Guid? idSize, Guid? idGiaiDau, Guid? idTeam, Guid? idChatLieu, string baoHanh, string moTa, int? soLuongTon, decimal? giaNhap, decimal? giaBan, int? trangThai, int? trangThaiKhuyenMai)
        {
            Id = id;
            IdSp = idSp;
            IdMauSac = idMauSac;
            IdSize = idSize;
            IdGiaiDau = idGiaiDau;
            IdTeam = idTeam;
            IdChatLieu = idChatLieu;
            BaoHanh = baoHanh;
            MoTa = moTa;
            SoLuongTon = soLuongTon;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
            TrangThai = trangThai;
            TrangThaiKhuyenMai = trangThaiKhuyenMai;
        }

        public ChiTietSpView(Guid? idSp, Guid? idMauSac, Guid? idSize, Guid? idGiaiDau, Guid? idTeam, Guid? idChatLieu, string baoHanh, string moTa, int? soLuongTon, decimal? giaNhap, decimal? giaBan, int? trangThai, int? trangThaiKhuyenMai)
        {
            IdSp = idSp;
            IdMauSac = idMauSac;
            IdSize = idSize;
            IdGiaiDau = idGiaiDau;
            IdTeam = idTeam;
            IdChatLieu = idChatLieu;
            BaoHanh = baoHanh;
            MoTa = moTa;
            SoLuongTon = soLuongTon;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
            TrangThai = trangThai;
            TrangThaiKhuyenMai = trangThaiKhuyenMai;
        }
    }
}
