using QuanLyVoSinhDAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhBUS
{
    public class BangDiemVoSinhBUS
    {
        public int LuuDiemDaiCam(List<DiemSoDTO> danhsachvosinh)
        {
            return BangDiemVoSinhDAO.LuuDiemDaiCam(danhsachvosinh);
        }

        public int LuuDiemDaiDo(List<DiemSoDTO> danhsachvosinh)
        {
            return BangDiemVoSinhDAO.LuuDiemDaiDo(danhsachvosinh);
        }

        public int LuuDiemDaiNau(List<DiemSoDTO> danhsachvosinh)
        {
            return BangDiemVoSinhDAO.LuuDiemDaiNau(danhsachvosinh);
        }

        public int LuuDiemDaiNau1(List<DiemSoDTO> danhsachvosinh)
        {
            return BangDiemVoSinhDAO.LuuDiemDaiNau1(danhsachvosinh);
        }

        public int LuuDiemDaiTim(List<DiemSoDTO> danhsachvosinh)
        {
            return BangDiemVoSinhDAO.LuuDiemDaiTim(danhsachvosinh);
        }

        public int LuuDiemDaiVang(List<DiemSoDTO> danhsachvosinh)
        {
            return BangDiemVoSinhDAO.LuuDiemDaiVang(danhsachvosinh);
        }

        public int LuuDiemDaiXanhDuong(List<DiemSoDTO> danhsachvosinh)
        {
           return BangDiemVoSinhDAO.LuuDiemDaiXanhDuong(danhsachvosinh);
        }

        public int LuuDiemDaiXanhLuc(List<DiemSoDTO> danhsachvosinh)
        {
            return BangDiemVoSinhDAO.LuuDiemDaiXanhLuc(danhsachvosinh);
        }

        public int ThemBangDiem(VoSinhDTO vosinh)
        {
            return BangDiemVoSinhDAO.ThemBangDiem(vosinh);
        }

        public int XoaBangDiemVoSinh(string maCLB)
        {
            return BangDiemVoSinhDAO.XoaBangDiemVoSinh(maCLB);
        }
    }
}
