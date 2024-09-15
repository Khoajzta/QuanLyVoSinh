using QuanLyVoSinhDAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhBUS
{
    public class CapDaiBUS
    {
        public List<CapDaiDTO> LayDanhSachCapDai()
        {
            return CapDaiDAO.LayDanhSachCapDai();
        }

        public CapDaiDTO LayThongTinCapDai(int maDai)
        {
            return CapDaiDAO.LayThongTinCapDai(maDai);
        }
    }
}
