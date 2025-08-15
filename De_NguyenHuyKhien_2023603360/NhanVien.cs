using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtratx2
{
    internal class NhanVien
    {
        public string maNhanVien {  get; set; }
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public float tienBanHang { get; set; }
        public float tienHoaHong { get {
                return tienBanHang * 0.1f;
            } }

    }
}
