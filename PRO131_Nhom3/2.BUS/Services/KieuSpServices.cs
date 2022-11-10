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
    public class KieuSpServices : IKieuSpServices
    {
        IKieuSpRepos kieuSpRepos;
        public KieuSpServices()
        {
            kieuSpRepos = new KieuSpRepos();
        }

        public string Add(KieuSpViews obj)
        {
            if (obj == null) return "Không thành công";
            KieuSp temp = new KieuSp()
            {
                Id = obj.Id,
                Ma = MaTS(),
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if (kieuSpRepos.Add(temp)) return "Thành công";
            return "Không thành công";
        }

        public string Delete(KieuSpViews obj)
        {
            if (obj == null) return "Không thành công";
            var temp = kieuSpRepos.GetID(obj.Id);
            if (temp != null) temp.TrangThai = obj.TrangThai;
            if (kieuSpRepos.Update(temp)) return "Thành công";
            return "Không thành công";
        }
        public List<KieuSpViews> GetAll()
        {
            var list = (from a in kieuSpRepos.GetAll()
                        select new KieuSpViews()
                        {
                            Id = a.Id,
                            Ma = a.Ma,
                            Ten = a.Ten,
                            TrangThai = a.TrangThai
                        }).ToList();
            return list;
        }

        public KieuSpViews GetID(Guid id)
        {
            var obj = kieuSpRepos.GetID(id);
            KieuSpViews temp = new KieuSpViews()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai,
            };
            return temp;
        }
        public string Update(KieuSpViews obj)
        {
            if (obj == null) return "Không thành công";
            KieuSp temp = new KieuSp()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if (kieuSpRepos.Update(temp)) return "Thành công";
            return "Không thành công";
        }
        public string MaTS()
        {
            if(kieuSpRepos.GetAll().Count>0)return "KSP" + (kieuSpRepos.GetAll().Max(c=>Convert.ToInt32(c.Ma.Substring(3,c.Ma.Length-3)))+1);
            return "KSP1";
        }
    }
}
