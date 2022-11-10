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
    public partial class FrmKieuSanPham : Form
    {
        IKieuSpServices kieuSpServices;
        public FrmKieuSanPham()
        {
            kieuSpServices = new KieuSpServices();
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Mã";
            dataGridView1.Columns[2].Name = "Tên";
            dataGridView1.Columns[3].Name = "Trạng thái";
            dataGridView1.Rows.Clear();
            var lst = kieuSpServices.GetAll().OrderBy(c => c.Ma);
            foreach (var i in lst)
            {
                dataGridView1.Rows.Add(i.Id, i.Ma, i.Ten, i.TrangThai == 0 ? "Hoạt Động" : i.TrangThai == 1 ? "Không Hoạt Động":"");
            }
            XoaForm();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var temp = kieuSpServices.GetID(Guid.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            tb_ma.Text = temp.Ma;
            tb_ten.Text = temp.Ten;
            rb_0.Checked = temp.TrangThai == 0;
            rb_1.Checked = temp.TrangThai == 1;
        }
        private void XoaForm()
        {
            tb_ma.Text = "";
            tb_ten.Text = "";
            rb_0.Checked = false;
            rb_1.Checked = false;
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            KieuSpViews kieuSpViews = new KieuSpViews()
            {
                Id = Guid.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                Ma = tb_ma.Text,
                Ten = tb_ten.Text,
                TrangThai = rb_0.Checked ? 0 : rb_1.Checked ? 1 : 0
            };
            MessageBox.Show(kieuSpServices.Update(kieuSpViews));
            LoadData();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            KieuSpViews kieuSpViews = new KieuSpViews()
            {
                Ma = tb_ma.Text,
                Ten = tb_ten.Text,
                TrangThai = rb_0.Checked ? 0 : rb_1.Checked ? 1 : 0
            };
            MessageBox.Show(kieuSpServices.Add(kieuSpViews));
            LoadData();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            KieuSpViews kieuSpViews = new KieuSpViews()
            {
                Id = Guid.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                Ma = tb_ma.Text,
                Ten = tb_ten.Text,
                TrangThai = 1
            };
            MessageBox.Show(kieuSpServices.Update(kieuSpViews));
            LoadData();
        }

        private void bt_xoaform_Click(object sender, EventArgs e)
        {
            XoaForm();
        }
    }
}
