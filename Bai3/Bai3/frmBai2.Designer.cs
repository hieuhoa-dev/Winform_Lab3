namespace Bai3
{
    partial class frmBai2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.cbTenHang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Tiền Thanh Toán:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(95, 60);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 2;
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Location = new System.Drawing.Point(20, 59);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(66, 17);
            this.rdbTienMat.TabIndex = 1;
            this.rdbTienMat.TabStop = true;
            this.rdbTienMat.Text = "Tiền mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(95, 261);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(159, 320);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(13, 13);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "0";
            // 
            // cbTenHang
            // 
            this.cbTenHang.FormattingEnabled = true;
            this.cbTenHang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
            this.cbTenHang.Location = new System.Drawing.Point(94, 24);
            this.cbTenHang.Name = "cbTenHang";
            this.cbTenHang.Size = new System.Drawing.Size(121, 21);
            this.cbTenHang.TabIndex = 5;
            this.cbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbTenHang_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(94, 97);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTienMat);
            this.groupBox1.Controls.Add(this.rdbChuyenKhoan);
            this.groupBox1.Location = new System.Drawing.Point(95, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình thức thanh toán";
            // 
            // rdbChuyenKhoan
            // 
            this.rdbChuyenKhoan.AutoSize = true;
            this.rdbChuyenKhoan.Checked = true;
            this.rdbChuyenKhoan.Location = new System.Drawing.Point(20, 27);
            this.rdbChuyenKhoan.Name = "rdbChuyenKhoan";
            this.rdbChuyenKhoan.Size = new System.Drawing.Size(95, 17);
            this.rdbChuyenKhoan.TabIndex = 0;
            this.rdbChuyenKhoan.TabStop = true;
            this.rdbChuyenKhoan.Text = "Chuyển Khoản";
            this.rdbChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTenHang);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.ComboBox cbTenHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbChuyenKhoan;
    }
}