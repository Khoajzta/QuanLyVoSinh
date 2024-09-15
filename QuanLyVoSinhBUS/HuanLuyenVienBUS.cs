using QuanLyVoSinhDAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhBUS
{
    public class HuanLuyenVienBUS
    {
        public List<HuanLuyenVienDTO> LayDanhSach()
        {
            return HuanLuyênVienDAO.LayDanhSach();
        }

        public HuanLuyenVienDTO LayThongTin(string maHLV)
        {
            return HuanLuyênVienDAO.LayThongTin(maHLV);
        }

        public int SuaHLV(HuanLuyenVienDTO hlv)
        {
            return HuanLuyênVienDAO.SuaHLV(hlv);
        }

        public int ThemHLV(HuanLuyenVienDTO hlv)
        {
            return HuanLuyênVienDAO.ThemHLV(hlv);
        }

        public int TrungMaHLV(string maHLV)
        {
            return HuanLuyênVienDAO.TrungMaHLV(maHLV);
        }

        public int XoaHLV(HuanLuyenVienDTO hlv)
        {
            return HuanLuyênVienDAO.XoaHLV(hlv);
        }
    }
}
