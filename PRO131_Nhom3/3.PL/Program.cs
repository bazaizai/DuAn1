<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using _3.PL.Views;
=======
using _3.PL.VIews;
>>>>>>> DAnh
=======
using _3.PL.Views;
>>>>>>> Hoang
=======
using _3.PL.Views;
>>>>>>> Kien
=======
using _3.PL.Views;
>>>>>>> Hieu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Application.Run(new FrmSale());
=======
            Application.Run(new FrmChucVu());
>>>>>>> DAnh
=======
            Application.Run(new FrmMain());

>>>>>>> Hoang
=======
            Application.Run(new FrmKhachHang());
>>>>>>> Kien
=======
            Application.Run(new FrmKieuSanPham());
>>>>>>> Hieu
        }
    }
}
