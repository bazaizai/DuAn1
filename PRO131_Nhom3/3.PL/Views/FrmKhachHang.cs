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
    public partial class FrmKhachHang : Form
    {
        public IKhachHangServices _iKhachHangServices;
        public KhachHangView _khachHangView;
        public FrmKhachHang()
        {
            InitializeComponent();
            _iKhachHangServices = new KhachHangServices();
            _khachHangView = new KhachHangView();
            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 11;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã";
            dtg_show.Columns[3].Name = "Tên";
            dtg_show.Columns[4].Name = "Tên đệm";
            dtg_show.Columns[5].Name = "Họ";
            dtg_show.Columns[6].Name = "Ngày Sinh";
            dtg_show.Columns[7].Name = "SDT";
            dtg_show.Columns[8].Name = "Địa chỉ";
            dtg_show.Columns[9].Name = "Email";
            dtg_show.Columns[10].Name = "Trạng thái";


            dtg_show.Rows.Clear();
            var lst = _iKhachHangServices.GetAll();
            if (tb_timkiem.Text != "")
            {
                lst = lst.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Sdt.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var item in lst)
            {
                dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.Ten, item.TenDem, item.Ho, item.NgaySinh.ToString(), item.Sdt, item.DiaChi, item.Email, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }

        public void ClearForm()
        {
            LoadData();
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_tendem.Text = "";
            tb_ho.Text = "";
            tb_diachi.Text = "";
            tb_email.Text = "";
            tb_sdt.Text = "";
            dtp_ngaysinh.Value = DateTime.Now;
            rdb_hd.Checked = false;
            rdb_khd.Checked = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = new KhachHangView()
            {
                Id = new Guid(),
                Ma = tb_ma.Text,
                Ten = tb_ten.Text,
                TenDem = tb_tendem.Text,
                Ho = tb_ho.Text,
                DiaChi = tb_diachi.Text,
                Email = tb_email.Text,
                Sdt = tb_sdt.Text,
                NgaySinh = dtp_ngaysinh.Value,
                TrangThai = rdb_hd.Checked ? 1 : 0
            };
            MessageBox.Show(_iKhachHangServices.Add(x));
            ClearForm();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            _khachHangView.Ma = tb_ma.Text;
            _khachHangView.Ten = tb_ten.Text;
            _khachHangView.TenDem = tb_tendem.Text;
            _khachHangView.Ho = tb_ho.Text;
            _khachHangView.DiaChi = tb_diachi.Text;
            _khachHangView.Email = tb_email.Text;
            _khachHangView.Sdt = tb_sdt.Text;
            _khachHangView.NgaySinh = dtp_ngaysinh.Value;
            _khachHangView.TrangThai = rdb_hd.Checked ? 1 : 0;
            MessageBox.Show(_iKhachHangServices.Update(_khachHangView));
            ClearForm();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iKhachHangServices.Delete(_khachHangView));
            ClearForm();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _khachHangView = _iKhachHangServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = _khachHangView.Ma;
                tb_ten.Text = _khachHangView.Ten;
                tb_tendem.Text = _khachHangView.TenDem;
                tb_ho.Text = _khachHangView.Ho;
                tb_diachi.Text = _khachHangView.DiaChi;
                tb_email.Text = _khachHangView.Email;
                tb_sdt.Text = _khachHangView.Sdt;
                dtp_ngaysinh.Value = _khachHangView.NgaySinh.Value;
                rdb_hd.Checked = _khachHangView.TrangThai == 1;
                rdb_khd.Checked = _khachHangView.TrangThai == 0;
            }
        }

        //public void TimKiem()
        //{
        //    var lst = _iKhachHangServices.GetAll();
        //    if (tb_timkiem.Text != "")
        //    {
        //        lst = lst.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Sdt.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
        //    }
        //}
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
