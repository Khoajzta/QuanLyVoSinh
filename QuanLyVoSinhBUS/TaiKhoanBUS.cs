using QuanLyVoSinhDAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhBUS
{
    public class TaiKhoanBUS
    {
        public static int ThemTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            return TaiKhoanDAO.ThemTaiKhoan(taiKhoan);
        }

        public int CapQuyenAdmin(TaiKhoanDTO taiKhoan)
        {
            return TaiKhoanDAO.CapQuyenAdmin(taiKhoan);
        }

        public int DoiMatKhau(string tenTaiKhoan, string matKhauMoi)
        {
            return TaiKhoanDAO.DoiMatKhau(tenTaiKhoan,matKhauMoi);
        }

        public TaiKhoanDTO KiemTraAdmin(string TenTaiKhoan)
        {
            return TaiKhoanDAO.KiemTraAdmin(TenTaiKhoan);
        }

        public List<TaiKhoanDTO> LayDanhSachTaiKhoan()
        {
            return TaiKhoanDAO.LayDanhSachTaiKhoan();
        }

        public string LayMaAdmin()
        {
            return TaiKhoanDAO.LayMaAdmin();
        }

        public TaiKhoanDTO LayTaiKhoan(string username, string password)
        {
            return TaiKhoanDAO.LayTaiKhoan(username, password);
        }

        public int ResetPW(string TenTaiKhoan, string mKReset)
        {
            return TaiKhoanDAO.ResetPW(TenTaiKhoan, mKReset);
        }

        public int TrungUsername(string username)
        {
            return TaiKhoanDAO.TrungUsername(username);
        }

        public int XoaQuyenAdmin(TaiKhoanDTO taiKhoan)
        {
            return TaiKhoanDAO.XoaQuyenAdmin(taiKhoan);
        }

        public int XoaTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            return TaiKhoanDAO.XoaTaiKhoan(taiKhoan);
        }

        public int XoaTaiKhoanCuaCLB(string maCLB)
        {
            return TaiKhoanDAO.XoaTaiKhoanCuaCLB(maCLB);
        }
    }
}
