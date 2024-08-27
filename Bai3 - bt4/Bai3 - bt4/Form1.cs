using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3___bt4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSanPham = "3";
            sp.TenSanPham = "fff";
            sp.LoaiSanPham = "1";
            sp.NgaySanXuat = new DateTime(2002 , 2 , 2);

            lblThongBao.Text = sp.ToString();
        }
    }
}
