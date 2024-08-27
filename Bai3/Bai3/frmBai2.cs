﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void cbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = cbTenHang.SelectedIndex;
            switch (stt)
            {
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "2000000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;

            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int DonGia = int.Parse(txtDonGia.Text);
            int SoLuong = int.Parse(txtSoLuong.Text);
            double thanhTien = 0;
            if (rdbChuyenKhoan.Checked)
                thanhTien = DonGia * SoLuong * 0.95;
            else
                thanhTien = DonGia * SoLuong;

            lblThongBao.Text = thanhTien.ToString("N0");
        }
    }
}
