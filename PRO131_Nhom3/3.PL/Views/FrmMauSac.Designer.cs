namespace _3.PL.Views
{
    partial class FrmMauSac
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
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_khonghd = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.tbt_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.rdb_hoatdong = new System.Windows.Forms.RadioButton();
            this.tbt_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(85, 237);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowTemplate.Height = 25;
            this.dtg_show.Size = new System.Drawing.Size(419, 150);
            this.dtg_show.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Trạng thái";
            // 
            // rdb_khonghd
            // 
            this.rdb_khonghd.AutoSize = true;
            this.rdb_khonghd.Location = new System.Drawing.Point(268, 150);
            this.rdb_khonghd.Name = "rdb_khonghd";
            this.rdb_khonghd.Size = new System.Drawing.Size(118, 19);
            this.rdb_khonghd.TabIndex = 23;
            this.rdb_khonghd.TabStop = true;
            this.rdb_khonghd.Text = "Không hoạt động";
            this.rdb_khonghd.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(429, 185);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 22;
            this.btn_clear.Text = "Xóa form";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(429, 144);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(429, 93);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // tbt_ten
            // 
            this.tbt_ten.Location = new System.Drawing.Point(157, 93);
            this.tbt_ten.Name = "tbt_ten";
            this.tbt_ten.Size = new System.Drawing.Size(229, 23);
            this.tbt_ten.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(429, 40);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // rdb_hoatdong
            // 
            this.rdb_hoatdong.AutoSize = true;
            this.rdb_hoatdong.Location = new System.Drawing.Point(157, 150);
            this.rdb_hoatdong.Name = "rdb_hoatdong";
            this.rdb_hoatdong.Size = new System.Drawing.Size(82, 19);
            this.rdb_hoatdong.TabIndex = 16;
            this.rdb_hoatdong.TabStop = true;
            this.rdb_hoatdong.Text = "Hoạt động";
            this.rdb_hoatdong.UseVisualStyleBackColor = true;
            // 
            // tbt_ma
            // 
            this.tbt_ma.Location = new System.Drawing.Point(157, 37);
            this.tbt_ma.Name = "tbt_ma";
            this.tbt_ma.Size = new System.Drawing.Size(229, 23);
            this.tbt_ma.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã";
            // 
            // FrmMauSac
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
            this.Name = "FrmMauSac";
            this.Text = "FrmMauSac";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_khonghd;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox tbt_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.RadioButton rdb_hoatdong;
        private System.Windows.Forms.TextBox tbt_ma;
        private System.Windows.Forms.Label label1;
    }
}