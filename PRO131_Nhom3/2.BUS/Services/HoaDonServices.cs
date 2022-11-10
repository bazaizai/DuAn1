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
    public class HoaDonServices : IHoaDonServices
    {
        IHoaDonRepos hoaDonRepos;
        IKhachHangRepos khachHangRepos;
        INhanVienRepos nhanVienRepos;
        ITichDiemRepos tichDiemRepos;
        public HoaDonServices()
        {
            hoaDonRepos = new HoaDonRepos();
            khachHangRepos = new KhachHangRepos();
            nhanVienRepos = new NhanVienRepos();
            tichDiemRepos = new TichDiemRepos();
        }

        public string Add(HoaDonViews obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(HoaDonViews obj)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonViews> GetAll()
        {
            //var lst = (from a in hoaDonRepos.GetAll()
            //           join b in (from a in khachHangRepos.GetKhachHangs()
            //                      join b in tichDiemRepos.GetTichDiems() on a.IdtichDiem equals b.Id
            //                      select new KhachHangView()
            //                      {
            //                          Id = a.Id,
            //                          Ten = a.Ten,
            //                          Ho = a.Ho,
            //                          TenDem = a.TenDem,
            //                          Sdt = a.Sdt,
            //                          DiaChi = a.DiaChi,
            //                          IdtichDiem = a.IdtichDiem,
            //                          Email = a.Email,
            //                          Ma = a.Ma,
            //                      }
            //                      )
            //           );
            throw new NotImplementedException();
        }

        public HoaDonViews GetID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(HoaDonViews obj)
        {
            throw new NotImplementedException();
        }
    }
}
