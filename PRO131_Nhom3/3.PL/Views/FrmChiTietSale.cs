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
    public partial class FrmChiTietSale : Form
    {
        private IChiTietSaleServices _IchiTietSaleServices;
        private ISaleServices _SaleServices;
        private List<ChiTietSaleView> _lstCtsle;
        private Guid IDCtsle;
        public FrmChiTietSale()
        {
            InitializeComponent();
            _IchiTietSaleServices = new ChiTietSaleServices();
            _SaleServices = new SaleServices();
            _lstCtsle = new List<ChiTietSaleView>();
            loadData();
            loadcbb();
        }
        private void loadData()
        {

            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 8;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "IDSale";
            dtg_show.Columns[2].Name = "IDChiTietSp";
            dtg_show.Columns[3].Name = "Mã sale";
            dtg_show.Columns[4].Name = "Tên sale";
            dtg_show.Columns[5].Name = "Tên sản phẩm";
            dtg_show.Columns[6].Name = "Mô tả";
            dtg_show.Columns[7].Name = "Trạng thái";
            _lstCtsle = _IchiTietSaleServices.GetAll();
            //if (tb_timkiem.Text != "")
            //{
            //    _lstCtsle = _lstCtsle.Where(c => c..Contains(tb_timkiem.Text)).ToList();
            //}
            foreach (var item in _lstCtsle)
            {
                dtg_show.Rows.Add(item.Id, item.IdSale, item.IdChiTietSp, item.MaSale, item.TenSale
                    , item.TenSanPham, item.MoTa, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }

        }
        private void loadcbb()
        {
            foreach (var item in _SaleServices.GetAll())
            {
                cbb_sale.Items.Add(item.Ma);
            }
            
        }
        
        private void bt_update_Click(object sender, EventArgs e)
        {

        }

        private void tb_them_Click(object sender, EventArgs e)
        {

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

        }

        private void bt_xoaform_Click(object sender, EventArgs e)
        {

        }
    }
}
