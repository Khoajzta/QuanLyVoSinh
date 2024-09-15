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
    public class DonViDAO
    {
        public static List<DonViDTO> LayDanhSach()
        {
            List<DonViDTO> danhsachdonvi = new List<DonViDTO>();
            string query = "select * from DonVi";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                DonViDTO donvi = new DonViDTO();
                donvi.MaDonVi = sdr["MaDonVi"].ToString();
                donvi.TenDonVi = sdr["TenDonVi"].ToString();
                danhsachdonvi.Add(donvi);   
            }
            sdr.Close();
            conn.Close();
            return danhsachdonvi;
        }

        public static int SuaDonVi(DonViDTO dv)
        {
            string query = $"update DonVi set TenDonVi = N'{dv.TenDonVi}' where MaDonVi = '{dv.MaDonVi}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }

        public static int ThemDonVi(DonViDTO dv)
        {
            string query = $"insert into DonVi(MaDonVi,TenDonVi) values('{dv.MaDonVi}',N'{dv.TenDonVi}')";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }

        public static int TrungMaDonVi(string maDonVi)
        {
            string query = $"select count(*) from DonVi where MaDonVi = '{maDonVi}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.truyVanScalar(query, conn);
            conn.Close();
            return kq;
        }

        public static int XoaDonVi(DonViDTO dv)
        {
            string query = $"delete DonVi where MaDonVi = '{dv.MaDonVi}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }
    }
}
