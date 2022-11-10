using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class CtTinhDiemView
    {
        public Guid Id { get; set; }
        public Guid? IdHoaDon { get; set; }
        public string MaHD { get; set; }
        public decimal? TongTienSauKhiGiam { get; set; }
        public int? HeSoTich
        { get; set; }
        public int? TrangThai { get; set; }
    }
}
