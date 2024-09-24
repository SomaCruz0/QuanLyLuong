using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLuong.DTO
{
    internal class NhanVienDTO
    {
        public int id { get; set; }
        public string ten { get; set; }
        public string cmt { get; set; }
        public string ngaysinh { get; set; }
        public string dienthoai { get; set; }
        public int hosonhanvien { get; set; }
        public int trangthai { get; set; }
        public string hinh {  get; set; }
        public int maphongban { get; set; }
        public int machucvu { get; set; }
        public int mahesoluong { get; set; }
        public int matrocap { get; set; }

    }
}
