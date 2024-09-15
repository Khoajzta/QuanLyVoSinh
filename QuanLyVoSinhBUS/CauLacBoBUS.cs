using QuanLyVoSinhDAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhBUS
{
    public class CauLacBoBUS
    {

        public int KiemTraDonViTrongCLB(string maDonVi)
        {
            return CauLacBoDAO.KiemTraDonViTrongCLB(maDonVi);
        }

        public int KiemTraHLVTrongCLB(string maHLV)
        {
            return CauLacBoDAO.KiemTraHLVTrongCLB(maHLV);
        }

        public CauLacBoDTO LayCLBAdmin()
        {
            return CauLacBoDAO.LayCLBAdmin();
        }

        public List<CauLacBoDTO> LayDanhSachCLB()
        {
            return CauLacBoDAO.LayDanhSachCLB();
        }

        public List<CauLacBoDTO> LayDanhSachCLBCuaHLV(string maHLV)
        {
            return CauLacBoDAO.LayDanhSachCLBCuaHLV(maHLV);
        }

        public CauLacBoDTO LayThongTin(string maCLB)
        {
            return CauLacBoDAO.LayThongTin(maCLB);
        }

        public int SuaCLB(CauLacBoDTO clb)
        {
            return CauLacBoDAO.SuaCLB(clb);
        }

        public int ThemCLB(CauLacBoDTO clb)
        {
            return CauLacBoDAO.ThemCLB(clb);
        }

        public int TrungCLB(CauLacBoDTO clb)
        {
            return CauLacBoDAO.TrungCLB(clb);
        }

        public int XoaCLB(CauLacBoDTO clb)
        {
            return CauLacBoDAO.XoaCLB(clb);
        }
    }
}
