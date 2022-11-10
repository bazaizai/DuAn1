namespace _3.PL.Views
{
    partial class FrmChucVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbt_ma = new System.Windows.Forms.TextBox();
            this.rdb_hoatdong = new System.Windows.Forms.RadioButton();
            this.btn_them = new System.Windows.Forms.Button();
            this.tbt_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rdb_khonghd = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // tbt_ma
            // 
            this.tbt_ma.Location = new System.Drawing.Point(142, 44);
            this.tbt_ma.Name = "tbt_ma";
            this.tbt_ma.Size = new System.Drawing.Size(229, 23);
            this.tbt_ma.TabIndex = 1;
            // 
            // rdb_hoatdong
            // 
            this.rdb_hoatdong.AutoSize = true;
            this.rdb_hoatdong.Location = new System.Drawing.Point(142, 157);
            this.rdb_hoatdong.Name = "rdb_hoatdong";
            this.rdb_hoatdong.Size = new System.Drawing.Size(82, 19);
            this.rdb_hoatdong.TabIndex = 2;
            this.rdb_hoatdong.TabStop = true;
            this.rdb_hoatdong.Text = "Hoạt động";
            this.rdb_hoatdong.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(414, 47);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tbt_ten
            // 
            this.tbt_ten.Location = new System.Drawing.Point(142, 100);
            this.tbt_ten.Name = "tbt_ten";
            this.tbt_ten.Size = new System.Drawing.Size(229, 23);
            this.tbt_ten.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(414, 100);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(414, 151);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(414, 192);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Xóa form";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rdb_khonghd
            // 
            this.rdb_khonghd.AutoSize = true;
            this.rdb_khonghd.Location = new System.Drawing.Point(253, 157);
            this.rdb_khonghd.Name = "rdb_khonghd";
            this.rdb_khonghd.Size = new System.Drawing.Size(118, 19);
            this.rdb_khonghd.TabIndex = 11;
            this.rdb_khonghd.TabStop = true;
            this.rdb_khonghd.Text = "Không hoạt động";
            this.rdb_khonghd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Trạng thái";
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(70, 244);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowTemplate.Height = 25;
            this.dtg_show.Size = new System.Drawing.Size(419, 150);
            this.dtg_show.TabIndex = 13;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 418);
            this.Controls.Add(this.dtg_show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdb_khonghd);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.tbt_ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.rdb_hoatdong);
            this.Controls.Add(this.tbt_ma);
            this.Controls.Add(this.label1);
            this.Name = "FrmChucVu";
            this.Text = "FrmChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbt_ma;
        private System.Windows.Forms.RadioButton rdb_hoatdong;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tbt_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton rdb_khonghd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_show;
    }
}