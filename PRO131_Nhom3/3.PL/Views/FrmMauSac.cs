using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FrmMauSac : Form
    {
        private IMauSacServices _iMauSac;
        private MauSacView _msv;
        public FrmMauSac()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 4;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[1].Name = "Mã";
            dtg_show.Columns[2].Name = "Tên";
            dtg_show.Columns[3].Name = "Trạng thái";
            dtg_show.Columns[0].Visible = false;
            var lstChucVu = _iMauSac.GetMauSacs();
            foreach (var item in lstChucVu)
            {
                dtg_show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        //private string MaTS()
        //{
        //    if (_iMauSac.GetMauSacs().Count > 0)
        //    {
        //        return "CV" + Convert.ToString(_iMauSac.GetMauSacs().Max(c => Convert.ToInt32(c.Ma.Substring(2, c.Ma.Length - 2)) + 1));
        //    }
        //    else return "CV1";
        //}

        public MauSacView GetData()
        {
            MauSacView cvv = new MauSacView()
            {
                Id = new Guid(),
                Ma = tbt_ma.Text,
                Ten = tbt_ten.Text,
                TrangThai = rdb_hoatdong.Checked ? 1 : 0,
            };
            return cvv;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _iMauSac.Add(GetData());
                MessageBox.Show("thêm thành công");
            }
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            MauSacView cvv = new MauSacView()
            {
                Id = Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString()),
                Ma = tbt_ma.Text,
                Ten = tbt_ten.Text,
                TrangThai = rdb_hoatdong.Checked ? 1 : 0,
            };
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _iMauSac.Update(cvv);
                MessageBox.Show("sửa thành công");
            }
            LoadData();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _msv = _iMauSac.GetMauSacs().FirstOrDefault(c => c.Id == Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString()));
            tbt_ma.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tbt_ten.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            rdb_khonghd.Checked = _msv.TrangThai == 0;
            rdb_hoatdong.Checked = _msv.TrangThai == 1;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_msv == null)
                {
                    MessageBox.Show("chọn chức vụ");
                }
                _iMauSac.Delete(_msv);
                MessageBox.Show("xóa thành công");
            }
            LoadData();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbt_ma.Text = "";
            tbt_ten.Text = "";
            rdb_hoatdong.Checked = false;
            rdb_khonghd.Checked = false;
        }
    }
}
