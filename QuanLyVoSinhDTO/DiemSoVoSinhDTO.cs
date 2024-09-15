using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhDTO
{
    public class DiemSoVoSinhDTO
    {
        public string MaVoSinh { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public float Diem { get; set; }
        public int MaDai { get; set; }
        public string TenDai { get; set; }
        public string MaCLB { get; set; }
        public string Loai
        {
            get
            {
                if (Diem >= 8)
                {
                    return "Giỏi";
                }
                else if (Diem >= 6.5 && Diem < 8)
                {
                    return "Khá";
                }
                else if (Diem >= 5 && Diem < 6.5)
                {
                    return "Trung Bình";
                }
                else if (Diem >= 3.5 && Diem < 5)
                    return "Yếu";
                else
                    return "Kém";
            }
        }
    }
}
