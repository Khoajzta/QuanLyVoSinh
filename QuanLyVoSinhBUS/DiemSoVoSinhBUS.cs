using QuanLyVoSinhDAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhBUS
{
    public class DiemSoVoSinhBUS
    {
        public List<DiemSoVoSinhDTO> LayDanhSachDiemSoVoSinhTheoDai(int madai, string maCLB)
        {
            return DiemSoVoSinhDAO.LayDanhSachDiemSoVoSinhTheoDai(madai, maCLB);
        }

        public List<DiemSoVoSinhDTO> LayDanhSachDiemSoVoSinhTheoDai(int v)
        {
            throw new NotImplementedException();
        }

        public List<DiemSoVoSinhDTO> LayDanhSachDiemSoVoSinhTheoDaiVaCLB(int maDai, string maCLB)
        {
            return DiemSoVoSinhDAO.LayDanhSachDiemSoVoSinhTheoDaiVaCLB(maDai, maCLB);
        }

        public int NhapDiem(List<DiemSoVoSinhDTO> danhsachvosinh)
        {
            return DiemSoVoSinhDAO.NhapDiem(danhsachvosinh);
        }
    }
}
