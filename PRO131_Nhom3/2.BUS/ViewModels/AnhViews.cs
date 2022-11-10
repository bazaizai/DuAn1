using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.ViewModels
{
    public class AnhViews
    {
        public AnhViews()
        {

        }
        public Guid Id { get; set; }
        public Guid? IdChiTietSp { get; set; }
        public string TenAnh { get; set; }
        public byte[] DuongDan { get; set; }
        public int? TrangThai { get; set; }

        ChiTietSp ChiTietSp { get; set; }

        public AnhViews(Guid? idChiTietSp, string tenAnh, byte[] duongDan, int? trangThai)
        {
            IdChiTietSp = idChiTietSp;
            TenAnh = tenAnh;
            DuongDan = duongDan;
            TrangThai = trangThai;
        }

        public AnhViews(Guid id, Guid? idChiTietSp, string tenAnh, byte[] duongDan, int? trangThai)
        {
            Id = id;
            IdChiTietSp = idChiTietSp;
            TenAnh = tenAnh;
            DuongDan = duongDan;
            TrangThai = trangThai;
        }
    }
}
