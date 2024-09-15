using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhDTO
{
    public class ThongTinVoSinhDTO
    {
        public string HoTen { get; set; }
        public DateTime NgayNhapHoc { get; set; }
        public string TenCLB { get; set; }
        public string DonVi { get; set; }
        public string TenHLV { get; set; }
        public string TenDai { get; set; }
        public float DiemDaiVang { get; set; }
        public float DiemDaiCam { get; set; }
        public float DiemDaiXanhLuc { get; set; }
        public float DiemDaiXanhDuong { get; set; }
        public float DiemDaiDo { get; set; }
        public float DiemDaiTim { get; set; }
        public float DiemDaiNau { get; set; }
        public float DiemDaiNau1 { get; set; }
        public DateTime NgaySinh { get; set; }
        public int TrangThai { get; set; }

    }
}
