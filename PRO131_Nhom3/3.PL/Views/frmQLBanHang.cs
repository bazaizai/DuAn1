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
    public partial class frmQLBanHang : Form
    {
        int count;
        public frmQLBanHang()
        {
            InitializeComponent();
            count = 1;
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage(NamrTabTS());
            TabHoaDon.TabPages.Add(tabPage);
        }

        //private void btnRemovetab_Click(object sender, EventArgs e)
        //{
        //    if (tabHoaDon.SelectedTab != null)
        //    {
        //        tabHoaDon.TabPages.Remove(tabHoaDon.SelectedTab);
        //    }
        //}

        private string NamrTabTS()
        {
            return "Hóa Đơn " + (count++).ToString();
        }
    }
}
