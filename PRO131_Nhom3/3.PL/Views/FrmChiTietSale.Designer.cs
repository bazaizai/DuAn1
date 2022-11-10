namespace _3.PL.Views
{
    partial class FrmChiTietSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_xoaform = new System.Windows.Forms.Button();
            this.rdb_khd = new System.Windows.Forms.RadioButton();
            this.rdb_hd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.tb_them = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_trangthai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.cbb_sale = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_ctsp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_xoaform
            // 
            this.bt_xoaform.Location = new System.Drawing.Point(635, 203);
            this.bt_xoaform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xoaform.Name = "bt_xoaform";
            this.bt_xoaform.Size = new System.Drawing.Size(82, 22);
            this.bt_xoaform.TabIndex = 42;
            this.bt_xoaform.Text = "Xóa form";
            this.bt_xoaform.UseVisualStyleBackColor = true;
            this.bt_xoaform.Click += new System.EventHandler(this.bt_xoaform_Click);
            // 
            // rdb_khd
            // 
            this.rdb_khd.AutoSize = true;
            this.rdb_khd.Location = new System.Drawing.Point(301, 197);
            this.rdb_khd.Name = "rdb_khd";
            this.rdb_khd.Size = new System.Drawing.Size(118, 19);
            this.rdb_khd.TabIndex = 41;
            this.rdb_khd.TabStop = true;
            this.rdb_khd.Text = "Không hoạt động";
            this.rdb_khd.UseVisualStyleBackColor = true;
            // 
            // rdb_hd
            // 
            this.rdb_hd.AutoSize = true;
            this.rdb_hd.Location = new System.Drawing.Point(179, 197);
            this.rdb_hd.Name = "rdb_hd";
            this.rdb_hd.Size = new System.Drawing.Size(83, 19);
            this.rdb_hd.TabIndex = 40;
            this.rdb_hd.TabStop = true;
            this.rdb_hd.Text = "Hoạt Động";
            this.rdb_hd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(167, 255);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(555, 23);
            this.tb_timkiem.TabIndex = 38;
            // 
            // dtg_show
            // 
            this.dtg_show.AllowUserToAddRows = false;
            this.dtg_show.AllowUserToDeleteRows = false;
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(59, 282);
            this.dtg_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.ReadOnly = true;
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_show.Size = new System.Drawing.Size(684, 141);
            this.dtg_show.TabIndex = 37;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(634, 158);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(82, 22);
            this.bt_xoa.TabIndex = 36;
            this.bt_xoa.Text = "xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // tb_them
            // 
            this.tb_them.Location = new System.Drawing.Point(634, 110);
            this.tb_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_them.Name = "tb_them";
            this.tb_them.Size = new System.Drawing.Size(82, 22);
            this.tb_them.TabIndex = 35;
            this.tb_them.Text = "Thêm";
            this.tb_them.UseVisualStyleBackColor = true;
            this.tb_them.Click += new System.EventHandler(this.tb_them_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(634, 64);
            this.bt_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(82, 22);
            this.bt_update.TabIndex = 34;
            this.bt_update.Text = "Cập nhật";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "IDCtsp";
            // 
            // tb_trangthai
            // 
            this.tb_trangthai.Location = new System.Drawing.Point(174, 154);
            this.tb_trangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_trangthai.Name = "tb_trangthai";
            this.tb_trangthai.Size = new System.Drawing.Size(216, 23);
            this.tb_trangthai.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "IDSale";
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(174, 117);
            this.tb_mota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(216, 23);
            this.tb_mota.TabIndex = 29;
            // 
            // cbb_sale
            // 
            this.cbb_sale.FormattingEnabled = true;
            this.cbb_sale.Location = new System.Drawing.Point(174, 42);
            this.cbb_sale.Name = "cbb_sale";
            this.cbb_sale.Size = new System.Drawing.Size(215, 23);
            this.cbb_sale.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Trạng thái";
            // 
            // cbb_ctsp
            // 
            this.cbb_ctsp.FormattingEnabled = true;
            this.cbb_ctsp.Location = new System.Drawing.Point(174, 77);
            this.cbb_ctsp.Name = "cbb_ctsp";
            this.cbb_ctsp.Size = new System.Drawing.Size(215, 23);
            this.cbb_ctsp.TabIndex = 46;
            // 
            // FrmChiTietSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 453);
            this.Controls.Add(this.cbb_ctsp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_sale);
            this.Controls.Add(this.bt_xoaform);
            this.Controls.Add(this.rdb_khd);
            this.Controls.Add(this.rdb_hd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.dtg_show);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.tb_them);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_trangthai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_mota);
            this.Name = "FrmChiTietSale";
            this.Text = "FrmChiTietSale";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_xoaform;
        private System.Windows.Forms.RadioButton rdb_khd;
        private System.Windows.Forms.RadioButton rdb_hd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button tb_them;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_trangthai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.ComboBox cbb_sale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_ctsp;
    }
}