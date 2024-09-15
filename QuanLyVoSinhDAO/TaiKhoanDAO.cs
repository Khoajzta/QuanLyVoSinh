using QuanLyHocSinhTHPT_DAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhDAO
{
    public class TaiKhoanDAO
    {
        public static int CapQuyenAdmin(TaiKhoanDTO taiKhoan)
        {
            string query = $"update TaiKhoan set LoaiTaiKhoan = 1 where TenTaiKhoan = '{taiKhoan.TenTaiKhoan}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }

        public static int DoiMatKhau(string tenTaiKhoan, string matKhauMoi)
        {
            string query = $"update TaiKhoan set MatKhau = '{matKhauMoi}' where TenTaiKhoan = '{tenTaiKhoan}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }

        public static TaiKhoanDTO KiemTraAdmin(string tenTaiKhoan)
        {
            TaiKhoanDTO tk = null;
            string query = $"select * from TaiKhoan where TenTaiKhoan = '{tenTaiKhoan}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            if(sdr.Read())
            {
                tk = new TaiKhoanDTO();
                tk.TenTaiKhoan = tenTaiKhoan;
                tk.MatKhau = sdr["MatKhau"].ToString();
                tk.LoaiTaiKhoan = (bool)sdr["LoaiTaiKhoan"];
            }
            sdr.Close();
            conn.Close();
            return tk;
        }

        public static List<TaiKhoanDTO> LayDanhSachTaiKhoan()
        {
            List<TaiKhoanDTO> danhsachtaikhoan = new List<TaiKhoanDTO>();
            string query = "select * from TaiKhoan";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while(sdr.Read())
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TenTaiKhoan = sdr["TenTaiKhoan"].ToString();
                tk.MatKhau = sdr["MatKhau"].ToString();
                tk.LoaiTaiKhoan = (bool)sdr["LoaiTaiKhoan"];
                tk.MaHLV = sdr["MaHLV"].ToString();
                danhsachtaikhoan.Add(tk);
            }
            sdr.Close();
            conn.Close();
            return danhsachtaikhoan;
        }

        public static string LayMaAdmin()
        {
            string MaHLV = "";
            string query = "Select MaHLV from TaiKhoan where TenTaiKhoan = 'admin'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query,conn);
            if(sdr.Read())
            {
                MaHLV = sdr["MaHLV"].ToString();
            }    
            sdr.Close();
            conn.Close();
            return MaHLV;
        }

        public static TaiKhoanDTO LayTaiKhoan(string username, string password)
        {
            TaiKhoanDTO taikhoan = null;
            string query = "select * from TaiKhoan where TenTaiKhoan COLLATE SQL_Latin1_General_CP1_CS_AS = @TenTaiKhoan and MatKhau COLLATE SQL_Latin1_General_CP1_CS_AS = @MatKhau ";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("TenTaiKhoan", username);
            param[1] = new SqlParameter("MatKhau", password);

            SqlDataReader sdr = DataProvider.TruyVan(query, conn,param);
            if(sdr.Read())
            {
                taikhoan = new TaiKhoanDTO();
                taikhoan.TenTaiKhoan = sdr["TenTaiKhoan"].ToString();
                taikhoan.MatKhau = sdr["MatKhau"].ToString();
                taikhoan.MaHLV = sdr["MaHLV"].ToString();
                taikhoan.LoaiTaiKhoan = (bool)sdr["LoaiTaiKhoan"];
            }
            sdr.Close();
            conn.Close();
            return taikhoan;
        }

        public static int ResetPW(string TenTaiKhoan, string mKReset)
        {
            string query = $"update TaiKhoan set MatKhau = '{mKReset}' where TenTaiKhoan = '{TenTaiKhoan}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }

        public static int ThemTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            
            string query = $"insert into TaiKhoan(TenTaiKhoan,MatKhau,LoaiTaiKhoan,MaHLV) values(@TenTaiKhoan,@MatKhau,0,@MaHLV)";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("TenTaiKhoan",taiKhoan.TenTaiKhoan);
            pars[1] = new SqlParameter("MatKhau",taiKhoan.MatKhau);
            pars[2] = new SqlParameter("MaHLV", taiKhoan.MaHLV);
            int kq = DataProvider.ThucThiLenh(query, conn, pars);
            conn.Close();
            return kq;
        }

        public static int TrungUsername(string username)
        {
            string query = $"select count(*) from TaiKhoan where TenTaiKhoan = '{username}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.truyVanScalar(query, conn);
            conn.Close();
            return kq;
        }

        public static int XoaQuyenAdmin(TaiKhoanDTO taiKhoan)
        {
            string query = $"update TaiKhoan set LoaiTaiKhoan = 0 where TenTaiKhoan = '{taiKhoan.TenTaiKhoan}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }

        public static int XoaTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            string query = $"delete TaiKhoan where TenTaiKhoan = '{taiKhoan.TenTaiKhoan}'";
            SqlConnection conn =  DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }

        public static int XoaTaiKhoanCuaCLB(string MaHLV)
        {
            string query = $"delete TaiKhoan where MaHLV = '{MaHLV}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }
    }
}
