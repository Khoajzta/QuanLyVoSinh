using QuanLyVoSinhDAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhBUS
{
    public class ThongTinVoSinhBUS
    {
        public ThongTinVoSinhDTO LayThongTin(string maVoSinh)
        {
            return ThongTinVoSinhDAO.LayThongTin(maVoSinh);
        }
    }
}
