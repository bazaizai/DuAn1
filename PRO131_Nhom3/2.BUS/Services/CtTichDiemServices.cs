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
    public class CtTichDiemServices : ICtTichDiemServices
    {
        private ICtTichDiemRepos _iCtTinhDiemRepos;
        private IHoaDonRepos _ihoaDonRepos;
        public CtTichDiemServices()
        {
            _iCtTinhDiemRepos = new CtTichDiemRepos();
            _ihoaDonRepos = new HoaDonRepos();
        }
        public string Add(CtTinhDiemView obj)
        {
            if (obj == null) return "Thêm thất bại";
            CttichDiem vcv = new CttichDiem()
            {
                Id = obj.Id,
                IdHoaDon = obj.IdHoaDon,
                HeSoTich = obj.HeSoTich,
                TrangThai = obj.TrangThai
            };
            _iCtTinhDiemRepos.Add(vcv);
            return "thêm thành công";
        }

        public string Delete(CtTinhDiemView obj)
        {
            if (obj == null) return "xóa thất bại";
            CttichDiem vcv = new CttichDiem()
            {
                Id = obj.Id,
                IdHoaDon = obj.IdHoaDon,
                HeSoTich = obj.HeSoTich,
                TrangThai = obj.TrangThai
            };
            _iCtTinhDiemRepos.Delete(vcv);
            return "xóa thành công";
        }

        public List<CtTinhDiemView> GetUuDais()
        {
            List<CtTinhDiemView> _lstCtTinhDiem = new List<CtTinhDiemView>();
            _lstCtTinhDiem = (
                from a in _iCtTinhDiemRepos.GetUuDais()
                join b in _ihoaDonRepos.GetAll() on a.IdHoaDon equals b.Id
                select new CtTinhDiemView()
                {
                    Id = a.Id,
                    IdHoaDon = b.Id,
                    MaHD = b.Ma,
                    TongTienSauKhiGiam = b.TongTienSauKhiGiam,
                    HeSoTich = a.HeSoTich,
                    TrangThai = a.TrangThai
                }).ToList();
            return _lstCtTinhDiem;
        }

        public string Update(CtTinhDiemView obj)
        {
            if (obj == null) return "sửa thất bại";
            CttichDiem vcv = new CttichDiem()
            {
                Id = obj.Id,
                IdHoaDon = obj.IdHoaDon,
                HeSoTich = obj.HeSoTich,
                TrangThai = obj.TrangThai
            };
            _iCtTinhDiemRepos.Update(vcv);
            return "sửa thành công";
        }
    }
}
