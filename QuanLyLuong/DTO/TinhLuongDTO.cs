﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLuong.DTO
{
    internal class TinhLuongDTO
    {
        public int id { get; set; }
        public int idnhanvien { get; set; }
        public float ngaycong { get; set; }
        public float tong { get; set; }
        public string thang { get; set; }
        public string nam { get; set; }
    }
}
