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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)

        {
            if (nudLyThuyet.Value < 5 || nudLyThuyet.Value < 5)
            {
                label4.Text = "Trung Bình";
            }
            decimal DiemTB = (nudLyThuyet.Value + nudLyThuyet.Value) / 2;

            if (DiemTB < 7)
            {
                label4.Text = "Khá";
            }
            if (DiemTB < 8 && DiemTB > 7)
            {
                label4.Text = "Khá";
            }
            if (DiemTB < 9 && DiemTB > 8)
            {
                label4.Text = "Giỏi";
            }
            if (DiemTB < 9 && DiemTB > 8)
            {
                label4.Text = "Xuất sắc";
            }   
        }
    }
}
