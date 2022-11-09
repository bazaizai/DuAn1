using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class KhachHangRepos:IKhachHangRepos
    {
        private FpolyDBContext context;
        private List<KhachHang> _lstKhachHang;

        public bool Add(KhachHang obj)
        {
            try
            {
                context.KhachHangs.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(KhachHang obj)
        {
            try
            {
                var tempobj = context.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
                context.Remove(tempobj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public KhachHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return context.KhachHangs.FirstOrDefault(c => c.Id == id);
        }

        public List<KhachHang> GetKhachHangs()
        {
            _lstKhachHang = context.KhachHangs.ToList();
            return _lstKhachHang;
        }

        public bool Update(KhachHang obj)
        {
            try
            {
                var tempobj = context.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
                tempobj.Ma = obj.Ma;
                tempobj.Ten = obj.Ten;
                tempobj.TenDem = obj.TenDem;
                tempobj.Ho = obj.Ho;
                tempobj.NgaySinh = obj.NgaySinh;
                tempobj.Sdt = obj.Sdt;
                tempobj.DiaChi = obj.DiaChi;
                tempobj.Email = obj.Email;
                tempobj.TrangThai = obj.TrangThai;
                context.Update(tempobj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
