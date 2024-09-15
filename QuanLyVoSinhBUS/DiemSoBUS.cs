using QuanLyVoSinhDAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhBUS
{
    public class DiemSoBUS
    {
        public static int CapNhatLaiDiem(List<string> danhsachvosinh)
        {
            return DiemSoDAO.CapNhatLaiDiem(danhsachvosinh);
        }

        public int ThemDiemSo(VoSinhDTO vosinh)
        {
            return DiemSoDAO.ThemDiemSo(vosinh);
        }

        public int XoaDiemVoSinh(string maCLB)
        {
            return DiemSoDAO.XoaDiem(maCLB);
        }
    }
}
