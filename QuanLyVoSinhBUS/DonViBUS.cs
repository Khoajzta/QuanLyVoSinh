using QuanLyVoSinhDAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhBUS
{
    public class DonViBUS
    {
        public List<DonViDTO> LayDanhSach()
        {
            return DonViDAO.LayDanhSach();
        }

        public int SuaDonVi(DonViDTO dv)
        {
            return DonViDAO.SuaDonVi(dv);
        }

        public int ThemDonVi(DonViDTO dv)
        {
            return DonViDAO.ThemDonVi(dv);
        }

        public int TrungMaDonVi(string maDonVi)
        {
            return DonViDAO.TrungMaDonVi(maDonVi);
        }

        public int XoaDonVi(DonViDTO dv)
        {
            return DonViDAO.XoaDonVi(dv);
        }
    }
}
