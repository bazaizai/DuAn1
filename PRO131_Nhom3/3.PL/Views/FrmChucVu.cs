﻿using _2.BUS.IServices;
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
    public partial class FrmChucVu : Form
    {
        private IChucVuServices _iChucVu;
        private ChucVuView _cvv;
        public FrmChucVu()
        {
            InitializeComponent();
            _iChucVu = new ChucVuServices();
            LoadData();
            rdb_hoatdong.Checked = true;
            tbt_ma.Enabled = false;
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
            var lstChucVu = _iChucVu.GetChucVus();
            foreach (var item in lstChucVu)
            {
                dtg_show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private string MaTS()
        {
            if (_iChucVu.GetChucVus().Count > 0)
            {
                return "CV" + Convert.ToString(_iChucVu.GetChucVus().Max(c => Convert.ToInt32(c.Ma.Substring(2, c.Ma.Length - 2)) + 1));
            }
            else return "CV1";
        }

        public ChucVuView GetData()
        {
            ChucVuView cvv = new ChucVuView()
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
                _iChucVu.Add(GetData());
                MessageBox.Show("thêm thành công");
            }
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ChucVuView cvv = new ChucVuView()
            {
                Id = Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString()),
                Ma = tbt_ma.Text,
                Ten = tbt_ten.Text,
                TrangThai = rdb_hoatdong.Checked ? 1 : 0,
            };
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _iChucVu.Update(cvv);
                MessageBox.Show("sửa thành công");
            }
            LoadData();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _cvv = _iChucVu.GetChucVus().FirstOrDefault(c => c.Id == Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString()));
            tbt_ma.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tbt_ten.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            rdb_khonghd.Checked = _cvv.TrangThai == 0;
            rdb_hoatdong.Checked = _cvv.TrangThai == 1;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_cvv == null)
                {
                    MessageBox.Show("chọn chức vụ");
                }
                _iChucVu.Delete(_cvv);
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
