using QuanLyHocSinhTHPT_DAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhDAO
{
    public class VoSinhDAO
    {
        public static List<VoSinhDTO> LayDanhSachTheoCLB(string maCLB)
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = $"select FORMAT(vs.NgaySinh, 'dd/MM/yyyy') AS NaySinhFM,FORMAT(vs.NgayNhapHoc, 'dd/MM/yyyy') AS NgayNhapHocFM, vs.*,cd.TenDai TenDai from vosinh vs join CapDai cd on vs.madai = cd.madai where TrangThai = 1 and MaCLB = '{maCLB}' order by MaDai desc ,NgayNhapHoc asc ,MaVoSinh asc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.MauDai = sdr["TenDai"].ToString();
                voSinh.NgayNhapHoc = sdr["NgayNhapHocFM"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }

        public static List<VoSinhDTO> LayDanhSachVoSinh()
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = "select FORMAT(vs.NgaySinh, 'dd/MM/yyyy') AS NaySinhFM, vs.*,cd.TenDai TenDai from vosinh vs join CapDai cd on vs.madai = cd.madai where TrangThai = 1 order by MaDai desc ,Ten asc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.MauDai = sdr["TenDai"].ToString();
                voSinh.NgayNhapHoc = sdr["NgayNhapHoc"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }

        public static List<VoSinhDTO> LayDanhSachVoSinhNghi()
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = "select * ,FORMAT(NgaySinh, 'dd/MM/yyyy') AS NaySinhFM from VoSinh where TrangThai = 0 order by MaDai desc ,Ten asc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.NgayNghi = (DateTime)sdr["NgayNghi"];
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.NgayNhapHoc = sdr["NgayNhapHoc"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }

        public static List<VoSinhDTO> LayDanhSachVoSinhNghiTheoCLB(string maCLB)
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = $"select * ,FORMAT(NgaySinh, 'dd/MM/yyyy') AS NaySinhFM from VoSinh where TrangThai = 0 and MaCLB = '{maCLB}' order by MaDai desc ,Ten asc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.NgayNghi = (DateTime)sdr["NgayNghi"];
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.NgayNhapHoc = sdr["NgayNhapHoc"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }

        public static List<VoSinhDTO> LayDanhSachVoSinhNghiTheoDai(int maDai)
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = $"select *,FORMAT(NgaySinh, 'dd/MM/yyyy') AS NaySinhFM from VoSinh where TrangThai = 0 and MaDai = {maDai} order by MaDai desc ,Ten asc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.NgayNghi = (DateTime)sdr["NgayNghi"];
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.NgayNhapHoc = sdr["NgayNhapHoc"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }

        public static List<VoSinhDTO> LayDanhSachVoSinhNghiTheoDaivaCLB(int maDai, string maCLB)
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = $"select *,FORMAT(NgaySinh, 'dd/MM/yyyy') AS NaySinhFM, FORMAT(NgayNhapHoc, 'dd/MM/yyyy') AS NgayNhapHocFM from VoSinh where TrangThai = 0 and MaDai = {maDai} and MaCLB = '{maCLB}' order by MaDai desc ,NgayNghi asc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.NgayNghi = (DateTime)sdr["NgayNghi"];
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.NgayNhapHoc = sdr["NgayNhapHocFM"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }

        public static List<VoSinhDTO> LayDanhSachVoSinhNghiTheoTenVaCLB(string ten, string maCLB)
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = $"select *,FORMAT(NgaySinh, 'dd/MM/yyyy') AS NaySinhFM , FORMAT(NgayNhapHoc, 'dd/MM/yyyy') AS NgayNhapHocFM from VoSinh where TrangThai = 0 AND (Ten) COLLATE Latin1_General_CI_AI LIKE N'%{ten}%' and MaCLB = '{maCLB}' order by MaDai desc ,NgayNghi asc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.NgayNghi = (DateTime)sdr["NgayNghi"];
                voSinh.NgayNhapHoc = sdr["NgayNhapHocFM"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }

        public static List<VoSinhDTO> LayDanhSachVoSinhTheoDaivaCLB(int maDai,string MaCLB)
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = $"select *,FORMAT(NgaySinh, 'dd/MM/yyyy') AS NaySinhFM ,FORMAT(NgayNhapHoc, 'dd/MM/yyyy') AS NgayNhapHocFM from VoSinh where TrangThai = 1 and MaDai = {maDai} and MaCLB = '{MaCLB}' order by NgayNhapHoc asc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.NgayNhapHoc = sdr["NgayNhapHocFM"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }

        public static List<VoSinhDTO> LayDanhSachVoSinhTheoTenVaCLB(string ten, string MaCLB)
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = $"select *,FORMAT(NgaySinh, 'dd/MM/yyyy') AS NaySinhFM ,FORMAT(NgayNhapHoc, 'dd/MM/yyyy') AS NgayNhapHocFM from VoSinh where TrangThai = 1 AND (Ten) COLLATE Latin1_General_CI_AI LIKE N'%{ten}%'   and MaCLB = '{MaCLB}' order by MaDai desc ,NgayNhapHoc asc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.NgayNhapHoc = sdr["NgayNhapHocFM"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }

        public static string LayMaVoSinhMax(string maCLB)
        {
            string MaVoSinhMax = "0";
            string query = $"SELECT  MAX(MaVoSinh)  FROM VoSinh where MaCLB = '{maCLB}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            if(sdr.Read())
            {
                MaVoSinhMax = sdr[0].ToString();
            }    
            sdr.Close();
            conn.Close(); 
            return MaVoSinhMax;
        }

        public static int SuaVoSinh(VoSinhDTO vosinh)
        {
            string query = "Update VoSinh set Ho = @Ho,Ten = @Ten, NgaySinh = CONVERT(DATE, @NgaySinh, 103),GioiTinh = @GioiTinh,MaDai = @MaDai, MaCLB = @MaCLB,NgayNhapHoc = CONVERT(DATE, @NgayNhapHoc, 103) where MaVoSinh = @MaVoSinh ";
            SqlParameter[] pars = new SqlParameter[8];
            pars[0] = new SqlParameter("Ho", vosinh.Ho);
            pars[1] = new SqlParameter("Ten", vosinh.Ten);
            pars[2] = new SqlParameter("NgaySinh", vosinh.NgaySinh);
            pars[3] = new SqlParameter("GioiTinh", vosinh.GioiTinh);
            pars[4] = new SqlParameter("MaDai", vosinh.MaDai);
            pars[5] = new SqlParameter("MaVoSinh", vosinh.MaVoSinh);
            pars[6] = new SqlParameter("MaCLB", vosinh.MaCLB);
            pars[7] = new SqlParameter("NgayNhapHoc", vosinh.NgayNhapHoc);
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn, pars);
            conn.Close();
            return kq;
        }

        public static int CapNhatDai(List<string> danhsachvosinh , int MaDai)
        {
            int kq = 0;
            foreach (string mavossinh in danhsachvosinh)
            {
                string query = $"update VoSinh set MaDai = {MaDai} where MaVoSinh = '{mavossinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }

        public static int ThemVoSinh(VoSinhDTO vosinh)
        {
            string query = "insert into VoSinh(MaVoSinh,Ho,Ten,NgaySinh,GioiTinh,MaDai,MaCLB,TrangThai,NgayNhapHoc)" +
                "values (@MaVoSinh,@Ho,@Ten,CONVERT(DATE, @NgaySinh, 103),@GioiTinh,@MaDai,@MaCLB,1,CONVERT(DATE, @NgayNhapHoc, 103))";
            SqlParameter[] par = new SqlParameter[8];
            par[0] = new SqlParameter("MaVoSinh", vosinh.MaVoSinh);
            par[1] = new SqlParameter("Ho", vosinh.Ho);
            par[2] = new SqlParameter("Ten", vosinh.Ten);
            par[3] = new SqlParameter("NgaySinh", vosinh.NgaySinh);
            par[4] = new SqlParameter("GioiTinh", vosinh.GioiTinh);
            par[5] = new SqlParameter("MaDai", vosinh.MaDai);
            par[6] = new SqlParameter("MaCLB", vosinh.MaCLB);
            par[7] = new SqlParameter("NgayNhapHoc", vosinh.NgayNhapHoc);
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn, par);
            conn.Close();
            return kq;
        }

        public static int TrungMaVoSinh(VoSinhDTO vosinh)
        {
            string query = $"select count(*) from VoSinh where MaVoSinh = '{vosinh.MaVoSinh}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.truyVanScalar(query, conn);
            conn.Close();
            return kq;
        }

        public static int VoSinhComback(List<string> danhsachmavosinh)
        {
            int kq = 0;
            foreach (string mavossinh in danhsachmavosinh)
            {
                string query = $"update VoSinh set TrangThai = 1 where MaVoSinh = '{mavossinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }

        public static int XoaVoSinh(string maVoSinh)
        {
            string query = $"Update VoSinh Set TrangThai = 0,NgayNghi = GETDATE() where MaVoSinh = {maVoSinh}";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }

        public static int XoaVoSinhTheoCLB(string maCLB)
        {
            string query = $"delete VoSinh where MaCLB = '{maCLB}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }

        public static int KiemTraMaVoSinh(string maVoSinh)
        {
            string query = $"select count(*) from VoSinh where MaVoSinh = '{maVoSinh}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.truyVanScalar(query, conn);
            conn.Close();
            return kq;
        }

        public static List<VoSinhDTO> SapXepTheoDai(string maCLB)
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = $"select FORMAT(vs.NgaySinh, 'dd/MM/yyyy') AS NaySinhFM,FORMAT(vs.NgayNhapHoc, 'dd/MM/yyyy') AS NgayNhapHocFM, vs.*,cd.TenDai TenDai from vosinh vs join CapDai cd on vs.madai = cd.madai where TrangThai = 1 and MaCLB = '{maCLB}' order by MaDai desc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.MauDai = sdr["TenDai"].ToString();
                voSinh.NgayNhapHoc = sdr["NgayNhapHocFM"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }

        public static List<VoSinhDTO> SapXepTheoNgayNhapHoc(string maCLB)
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = $"select FORMAT(vs.NgaySinh, 'dd/MM/yyyy') AS NaySinhFM,FORMAT(vs.NgayNhapHoc, 'dd/MM/yyyy') AS NgayNhapHocFM, vs.*,cd.TenDai TenDai from vosinh vs join CapDai cd on vs.madai = cd.madai where TrangThai = 1 and MaCLB = '{maCLB}' order by vs.NgayNhapHoc asc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.MauDai = sdr["TenDai"].ToString();
                voSinh.NgayNhapHoc = sdr["NgayNhapHocFM"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }

        public static List<VoSinhDTO> SapXepTheoTen(string maCLB)
        {
            List<VoSinhDTO> danhsachvosinh = new List<VoSinhDTO>();
            string query = $"select FORMAT(vs.NgaySinh, 'dd/MM/yyyy') AS NaySinhFM,FORMAT(vs.NgayNhapHoc, 'dd/MM/yyyy') AS NgayNhapHocFM, vs.*,cd.TenDai TenDai from vosinh vs join CapDai cd on vs.madai = cd.madai where TrangThai = 1 and MaCLB = '{maCLB}' order by vs.Ten asc";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                VoSinhDTO voSinh = new VoSinhDTO();
                voSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                voSinh.Ho = sdr["Ho"].ToString();
                voSinh.Ten = sdr["Ten"].ToString();
                voSinh.NgaySinh = sdr["NaySinhFM"].ToString();
                voSinh.GioiTinh = sdr["GioiTinh"].ToString();
                voSinh.MaDai = (int)sdr["MaDai"];
                voSinh.MaCLB = sdr["MaCLB"].ToString();
                voSinh.TrangThai = (int)sdr["TrangThai"];
                voSinh.MauDai = sdr["TenDai"].ToString();
                voSinh.NgayNhapHoc = sdr["NgayNhapHocFM"].ToString();
                danhsachvosinh.Add(voSinh);
            }
            sdr.Close();
            conn.Close();
            return danhsachvosinh;
        }
    }
}
