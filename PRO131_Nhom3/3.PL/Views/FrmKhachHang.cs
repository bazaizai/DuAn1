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
            var lstKhachHang = _iKhachHangServices.GetAll();
            foreach (var item in lstKhachHang)
            {
                dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.Ten, item.TenDem, item.Ho, item.NgaySinh.ToString(), item.Sdt, item.DiaChi, item.Email, item.TrangThai);
            }
        }
    }
}
