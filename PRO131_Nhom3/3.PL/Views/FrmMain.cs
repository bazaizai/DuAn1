using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmMain : Form
    {
        private Form CurrentFormChild;
        private IconButton currentBtn;
        private Panel LeftBorderBtn;
        public FrmMain()
        {
            InitializeComponent();
            HidePanel();
            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(LeftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            CheckMenuPanel();
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                LeftBorderBtn.BackColor = color;
                LeftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                LeftBorderBtn.Visible = true;
                LeftBorderBtn.BringToFront();
                //Current Child Form Icon
                btbHome.IconChar = currentBtn.IconChar;
                btbHome.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(8, 8, 8);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            LeftBorderBtn.Visible = false;
            btbHome.IconChar = IconChar.Home;
            btbHome.IconColor = Color.MediumPurple;
            lblHome.Text = "Home";
        }
        private void ResetLeftBorder()
        {
            DisableButton();
            LeftBorderBtn.Visible = false;
            btbHome.IconChar = IconChar.Home;
            btbHome.IconColor = Color.MediumPurple;
            lblHome.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ptnTileBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


       
        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }
            CurrentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(ChildForm);
            pnlBody.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void HidePanel()
        {
            pnlbtn1.Visible = false;
            pnlbtn5.Visible = false;
            pnlbtn9.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlbtn1.Visible == true)
                pnlbtn1.Visible = false;
            if (pnlbtn5.Visible == true)
                pnlbtn5.Visible = false;
            if (pnlbtn9.Visible == true)
                pnlbtn9.Visible = false;
        }
        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
                ResetLeftBorder();
            }
                
        }

        private void CheckMenuPanel()
        {
            if (pnlbtn1.Visible)
            {
                pnlbtn1.Visible = false;
            }
            if (pnlbtn5.Visible)
            {
                pnlbtn5.Visible = false;
            }
            if (pnlbtn9.Visible)
            {
                pnlbtn9.Visible = false;
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ShowSubMenu(pnlbtn1);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmQLKhachHang());
            HideSubMenu();
            ResetLeftBorder();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ResetLeftBorder();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ResetLeftBorder();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            
            ActivateButton(sender, RGBColors.color3);
            ShowSubMenu(pnlbtn5);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }
            Reset();
            HideSubMenu();
        }

        private void _X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _ToNho_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void _tru_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnBanHang.Text;
            OpenChildForm(new frmQLBanHang());
            ActivateButton(sender, RGBColors.color1);
            HideSubMenu();
        }
    }
}
