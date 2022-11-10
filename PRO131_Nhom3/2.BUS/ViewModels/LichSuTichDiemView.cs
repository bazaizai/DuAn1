using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class LichSuTichDiemView
    {
        public Guid Id { get; set; }
        public Guid? IdTichDiem { get; set; }
        public Guid? IdCttinhDiem { get; set; }
        public decimal? TongTienSauKhiGiam { get; set; }//
        public int? SoDiemLS { get; set; }//
        public int? SoDiemTD { get; set; }//
        public int? HeSoTich { get; set; }
        public int? TrangThai { get; set; }
    }
}
