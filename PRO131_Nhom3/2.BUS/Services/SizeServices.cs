using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class SizeServices:ISizeServices
    {
        private ISizeRepos _ISizeRepos;
        private List<SizeViews> _lstSp;

        public SizeServices()
        {
            _ISizeRepos = new SizeRepos();
            _lstSp = new List<SizeViews>();
        }

        public string Add(SizeViews obj)
        {
            if (obj == null) return "Thêm Không thành công";

            Size Sp = new Size()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Size1 = obj.Size1,
                Cm = obj.Cm,
                Inch = obj.Inch,
                TrangThai = obj.TrangThai,


            };
            if (_ISizeRepos.Add(Sp)) return "Thêm thành công";
            return "Thêm Không thành công";
        }



        public string Delete(SizeViews obj)
        {
            if (obj == null) return "Delete Không thành công";

            var x = _ISizeRepos.GetSizes().FirstOrDefault(p => p.Id == obj.Id);
            if (_ISizeRepos.Delete(x)) return "Delete thành công";
            return "Delete Không thành công";
        }

        public List<SizeViews> GetSizes()
        {
            _lstSp = (from a in _ISizeRepos.GetSizes()
                      select new SizeViews
                      {
                          Id = a.Id,
                          Ma = a.Ma,
                          Size1 = a.Size1,
                          Cm = a.Cm,
                          Inch = a.Inch,
                          TrangThai = a.TrangThai,

                      }).ToList();
            return _lstSp;
        }

        public string Update(SizeViews obj)
        {
            if (obj == null) return "Update Không thành công";
            var x = _ISizeRepos.GetSizes().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.Ma = obj.Ma;
            x.Size1 = obj.Size1;
            x.Inch = obj.Inch;
            x.TrangThai = obj.TrangThai;
            if (_ISizeRepos.Update(x)) return "Update thành công";
            return "Update Không thành công";
        }

    }
}
