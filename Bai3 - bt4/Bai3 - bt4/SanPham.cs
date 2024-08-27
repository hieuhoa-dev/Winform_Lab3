using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Bai3___bt4
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }

        public SanPham() { }

        public int NamHetHan()
        {
            return NgaySanXuat.Year + 3; ;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2} ,{3} ", MaSanPham, TenSanPham, LoaiSanPham, NamHetHan());
        }
    }
}
