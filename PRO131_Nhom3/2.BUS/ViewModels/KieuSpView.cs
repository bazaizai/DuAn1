using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class KieuSpView
    {
        public KieuSpView()
        {

        }
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public int? TrangThai { get; set; }


        public KieuSpView(Guid id, string ma, string ten, int? trangThai)
        {
            Id = id;
            Ma = ma;
            Ten = ten;
            TrangThai = trangThai;
        }

        public KieuSpView(string ma, string ten, int? trangThai)
        {
            Ma = ma;
            Ten = ten;
            TrangThai = trangThai;
        }
    }
}
