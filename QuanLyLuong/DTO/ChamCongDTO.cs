﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLuong.DTO
{
    internal class ChamCongDTO
    {
        public int id {  get; set; }
        public int idnhanvien { get; set; }
        public string gio { get; set; }
        public string ngay { get; set; }
        public string thang { get; set; }
        public string nam { get; set; }
        public int trangthai { get; set; }
        public string noidung { get; set; }
        public string ghichu { get; set; }
        public string dieukien { get; set; }

    }
}
