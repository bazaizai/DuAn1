using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChiTietSpServices : IChiTietSpServices
    {
        IChiTietSpRespos _IChiTietSpRespos;
        public ChiTietSpServices()
        {
            _IChiTietSpRespos = new ChiTietSpRespos();
        }
        public string Add(ChiTietSpViews Obj) => Obj != null && _IChiTietSpRespos.Add(new ChiTietSp(Obj.IdSp, Obj.IdMauSac, Obj.IdSize, Obj.IdGiaiDau, Obj.IdTeam, Obj.IdChatLieu, Obj.BaoHanh, Obj.MoTa, Obj.SoLuongTon, Obj.GiaNhap, Obj.GiaBan, Obj.TrangThaiKhuyenMai, Obj.TrangThai)) ? "Add Succsess" : "Add not success";

        public string Delete(ChiTietKieuSpViews Obj)=> Obj != null && _IChiTietSpRespos.Delete(_IChiTietSpRespos.GetAll().Find(x => x.Id == Obj.Id)) ? "Delete success" : "Delete not succsess";

        public List<ChiTietKieuSpViews> GetAll()
        {
            throw new NotImplementedException();
        }

        public ChiTietKieuSpViews GetById(Guid Id) => GetAll().Find(x => x.Id == Id);

        public string Update(ChiTietKieuSpViews Obj)
        {
            throw new NotImplementedException();
        }
    }
}
