using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ChiTietKieuSpViews
    {
        public ChiTietKieuSpViews()
        {

        }
        public Guid Id { get; set; }
        public Guid? IdKieuSp { get; set; }
        public Guid? IdChiTietSp { get; set; }
        public int? TrangThai { get; set; }

        public ChiTietKieuSpViews(Guid id, Guid? idKieuSp, Guid? idCha, Guid? idChiTietSp, int? trangThai)
        {
            Id = id;
            IdKieuSp = idKieuSp;
            IdChiTietSp = idChiTietSp;
            TrangThai = trangThai;
        }

        public ChiTietKieuSpViews(Guid? idKieuSp, Guid? idCha, Guid? idChiTietSp, int? trangThai)
        {
            IdKieuSp = idKieuSp;
            IdChiTietSp = idChiTietSp;
            TrangThai = trangThai;
        }
    }
}
