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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmPtthanhToan : Form
    {

        private IPtthanhToanServices _ISanPhamServices;
        private List<PtthanhToanViews> _LstSanPham;
        public PtthanhToanViews? _SanPham;
        public FrmPtthanhToan()
        {
            InitializeComponent();
            InitializeComponent();
            _ISanPhamServices = new PtthanhToanServices();
            _LstSanPham = new List<PtthanhToanViews >();
        }
        public void LoadData()
        {

            dtg_Show.Rows.Clear();
            dtg_Show.ColumnCount = 4;
            dtg_Show.Columns[0].Name = "Id ";
            dtg_Show.Columns[0].Visible = false;
            dtg_Show.Columns[1].Name = "ma";
            dtg_Show.Columns[2].Name = "Tên ";
            dtg_Show.Columns[3].Name = "Trang Thai";

            tb_Ma.Enabled = false;
            var lstKhachHang = _ISanPhamServices.GetPtthanhToans();
            if (tb_TimKiem.Text != "")
            {
                lstKhachHang = lstKhachHang.Where(x => x.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var item in lstKhachHang)
            {
                dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai /*item.nhanVien.TrangThai == 0 ? "Không hoạt động" : "Hoạt động"*/);

            }
        }

        private string MaTS()
        {
            string[] hoten;
            hoten = tb_Ten.Text.Split(' ');
            string tenVT = "";
            for (int i = 0; i < hoten.Length - 1; i++)
            {
                tenVT += hoten[i][0];
            }
            tenVT = hoten[hoten.Length - 1] + tenVT;
            int stt = _ISanPhamServices.GetPtthanhToans().Where(x => Regex.Match(x.Ma, @"^[^0-9]*").Value == tenVT).ToList().Count + 1;
            return tenVT + stt.ToString();
        }

        public void resetForm()
        {
            _SanPham = null;

            radioButton1 = null;
            radioButton2 = null;
            foreach (TextBox item in groupBox2.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            tb_TimKiem.Text = "";
            LoadData();
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = dtg_Show.Rows[e.RowIndex];
                _SanPham = _ISanPhamServices.GetPtthanhToans().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString() ?? "Unknown message id"));
                tb_Ma.Text = r.Cells[1].Value.ToString();
                tb_Ten.Text = r.Cells[2].Value.ToString();


            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_Ten.Text == "")
            {
                MessageBox.Show("Hãy nhập Ten");
            }

            else
            {

                DialogResult dlg = MessageBox.Show("Bạn có muốn thêm", "Chú ý", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    PtthanhToanViews a = new PtthanhToanViews()
                    {
                        Ma = MaTS(),
                        Ten = tb_Ten.Text,
                        
                    };
                    _ISanPhamServices.Add(a);
                    MessageBox.Show("Them thành công");
                    resetForm();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_SanPham == null)
            {
                MessageBox.Show("Bạn chưa chọn");
            }
            else
            {
                if (tb_Ten.Text == "")
                {
                    MessageBox.Show("Hãy nhập ten ");
                }

                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có muốn sửa ", "Chú ý", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        _SanPham.Ma = MaTS();
                        _SanPham.Ten = tb_Ten.Text;

                        _ISanPhamServices.Update(_SanPham);
                        MessageBox.Show("Sửa thành công");
                        resetForm();
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_SanPham == null)
            {
                MessageBox.Show("Bạn chưa chọn Khách hàng");
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Bạn có muốn xóa khách hàng", "Chú ý", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    _ISanPhamServices.Delete(_SanPham);
                    MessageBox.Show("Xóa thành công");
                    resetForm();
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
resetForm();
        }
    }
}
