using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmNhanVien : Form
    {
        private INhanVienServices _iNhanVien;
        private IChucVuServices _iChucVu;
        private NhanVienView _nvv;
        public FrmNhanVien()
        {
            InitializeComponent();
            rdb_hoatdong.Checked = true;
            tb_ma.Enabled = false;
            _iChucVu = new ChucVuServices();
            _iNhanVien = new NhanVienServices();
        }
        public void loadData()
        {
            dtgv_show.ColumnCount = 11;
            dtgv_show.Columns[0].Name = "Id";
            dtgv_show.Columns[0].Visible = false;
            dtgv_show.Columns[4].Name = "Chức vụ";
            dtgv_show.Columns[1].Name = "Mã";
            dtgv_show.Columns[2].Name = "Tên";
            dtgv_show.Columns[5].Name = "Giới tính";
            dtgv_show.Columns[6].Name = "Ngày sinh";
            dtgv_show.Columns[7].Name = "Địa chỉ";
            dtgv_show.Columns[8].Name = "SĐT";
            dtgv_show.Columns[9].Name = "Trạng thái";

            dtgv_show.Rows.Clear();
            var lstViewNV = _iNhanVien.GetNhanViens();

            foreach (var item in lstViewNV)
            {
                dtgv_show.Rows.Add(
                    item.Id,
                    item.Ma,
                    item.HoVaTen,
                    item.GioiTinh,
                    item.NgaySinh.ToString(),
                    item.DiaChi,
                    item.Sdt,
                    item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"
                    );
            }
            loadComboBox();
        }
        public void loadComboBox()
        {
            cbb_chucvu.Items.Clear();
            cbb_gioitinh.Items.Clear();
            foreach (var item in _iChucVu.GetChucVus())
            {
                cbb_chucvu.Items.Add(item.Ten);
            }
            cbb_gioitinh.Items.Add("Nam");
            cbb_gioitinh.Items.Add("Nữ");
        }
    }
}
