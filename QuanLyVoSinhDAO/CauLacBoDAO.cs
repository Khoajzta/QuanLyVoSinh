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
    public class CauLacBoDAO
    {
        public static int KiemTraDonViTrongCLB(string maDonVi)
        {
            string query = $"select count(*) from CauLacBo where MaDonVi = '{maDonVi}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.truyVanScalar(query, conn);
            conn.Close();
            return kq;
        }

        public static int KiemTraHLVTrongCLB(string maHLV)
        {
            string query = $"select count(*) from CauLacBo where MaHLV = '{maHLV}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.truyVanScalar(query, conn);
            conn.Close();
            return kq;
        }

        public static CauLacBoDTO LayCLBAdmin()
        {
            CauLacBoDTO clb = new CauLacBoDTO();
            return clb;
        }

        public static List<CauLacBoDTO> LayDanhSachCLB()
        {
            List<CauLacBoDTO> danhsachCLB = new List<CauLacBoDTO>();
            string query = "select * from CauLacBo";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query,conn);
            while (sdr.Read())
            {
                CauLacBoDTO cauLacBo = new CauLacBoDTO();
                cauLacBo.MaCLB = sdr["MaCLB"].ToString();
                cauLacBo.TenCLB = sdr["TenCLB"].ToString();
                cauLacBo.MaHLV = sdr["MaHLV"].ToString();
                cauLacBo.MaDonVi = sdr["MaDonVi"].ToString();
                danhsachCLB.Add(cauLacBo);
            }
            sdr.Close();
            conn.Close();
            return danhsachCLB;
        }

        public static List<CauLacBoDTO> LayDanhSachCLBCuaHLV(string maHLV)
        {
            List<CauLacBoDTO> danhsachCLB = new List<CauLacBoDTO>();
            string query = $"select clb.MaCLB MaCLB,clb.TenCLB TenCLB from CauLacBo clb join HuanLuyenVien hlv on clb.MaHLV = hlv.MaHLV where clb.MaHLV = '{maHLV}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                CauLacBoDTO cauLacBo = new CauLacBoDTO();
                cauLacBo.MaCLB = sdr["MaCLB"].ToString();
                cauLacBo.TenCLB = sdr["TenCLB"].ToString();
                danhsachCLB.Add(cauLacBo);
            }
            sdr.Close();
            conn.Close();
            return danhsachCLB;
        }

        public static CauLacBoDTO LayThongTin(string maCLB)
        {
            CauLacBoDTO clb = new CauLacBoDTO();
            string query = $"select * from CauLacBo clb join DonVi dv on clb.MaDonVi = dv.MaDonVi join HuanLuyenVien hlv on clb.MaHLV = hlv.MaHLV where MaCLB = '{maCLB}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            if (sdr.Read())
            {
                clb.MaCLB = sdr["MaCLB"].ToString();
                clb.TenCLB = sdr["TenCLB"].ToString();
                clb.MaHLV = sdr["MaHLV"].ToString();
                clb.MaDonVi = sdr["MaDonVi"].ToString();
                clb.TenDonVi = sdr["TenDonVi"].ToString();
                clb.TenHLV = sdr["TenHLV"].ToString();
            }
            sdr.Close();
            conn.Close();
            return clb;
        }

        public static int SuaCLB(CauLacBoDTO clb)
        {
            string query = "update CauLacBo set MaCLB = @MaCLB, TenCLB = @TenCLB , MaHLV = @MaHLV,MaDonVi = @MaDonVi where MaCLB = @MaCLB";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("MaCLB", clb.MaCLB);
            pars[1] = new SqlParameter("TenCLB", clb.TenCLB);
            pars[2] = new SqlParameter("MaHLV", clb.MaHLV);
            pars[3] = new SqlParameter("MaDonVi", clb.MaDonVi);
            int kq = DataProvider.ThucThiLenh(query, conn, pars);
            conn.Close();
            return kq;
        }

        public static int ThemCLB(CauLacBoDTO clb)
        {
            string query = "insert into CauLacBo(MaCLB,TenCLB,MaHLV,MaDonVi) values(@MaCLB,@TenCLB,@MaHLV,@MaDonVi)";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("MaCLB", clb.MaCLB);
            pars[1] = new SqlParameter("TenCLB", clb.TenCLB);
            pars[2] = new SqlParameter("MaHLV", clb.MaHLV);
            pars[3] = new SqlParameter("MaDonVi", clb.MaDonVi);
            int kq = DataProvider.ThucThiLenh(query, conn, pars);
            conn.Close();
            return kq;
        }

        public static int TrungCLB(CauLacBoDTO clb)
        {
            string query = $"select count(*) from CauLacBo where MaCLB = '{clb.MaCLB}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.truyVanScalar(query, conn);   
            conn.Close();
            return kq;
        }

        public static int XoaCLB(CauLacBoDTO clb)
        {
            string query = $"delete CauLacBo where MaCLB = '{clb.MaCLB}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query,conn);
            conn.Close();
            return kq;
        }
    }
}
