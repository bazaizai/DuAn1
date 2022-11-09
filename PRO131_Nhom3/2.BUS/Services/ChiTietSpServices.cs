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
    public class ChiTietSpServices : IChiTietSpServices
    {
        IChiTietSpRespos _IChiTietResposi;
        public ChiTietSpServices()
        {
            _IChiTietResposi = new ChiTietSpRespos();
        }
        public string Add(ChiTietSpView Obj) => Obj != null && _IChiTietResposi.Add(new ChiTietSp(Obj.IdSp, Obj.IdMauSac, Obj.IdSize, Obj.IdGiaiDau, Obj.IdTeam, Obj.IdChatLieu, Obj.BaoHanh, Obj.MoTa, Obj.SoLuongTon, Obj.GiaNhap, Obj.GiaBan, Obj.TrangThaiKhuyenMai, Obj.TrangThai)) ? "Add Succsess" : "Add not success";

        public string Delete(ChiTietKieuSpView Obj)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietKieuSpView> GetAll()
        {
            throw new NotImplementedException();
        }

        public ChiTietKieuSpView GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public string Update(ChiTietKieuSpView Obj)
        {
            throw new NotImplementedException();
        }
    }
}
