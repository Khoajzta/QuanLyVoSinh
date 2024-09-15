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
    public class BangDiemVoSinhDAO
    {
        public static int LuuDiemDaiCam(List<DiemSoDTO> danhsachvosinh)
        {
            int kq = 0;
            foreach (DiemSoDTO dsvs in danhsachvosinh)
            {
                string query = $"update BangDiemVoSinh set DiemDaiCam = {dsvs.Diem}  where MaVoSinh = '{dsvs.MaVoSinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }

        public static int LuuDiemDaiDo(List<DiemSoDTO> danhsachvosinh)
        {
            int kq = 0;
            foreach (DiemSoDTO dsvs in danhsachvosinh)
            {
                string query = $"update BangDiemVoSinh set DiemDaiDo = {dsvs.Diem}  where MaVoSinh = '{dsvs.MaVoSinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }

        public static int LuuDiemDaiNau(List<DiemSoDTO> danhsachvosinh)
        {
            int kq = 0;
            foreach (DiemSoDTO dsvs in danhsachvosinh)
            {
                string query = $"update BangDiemVoSinh set DiemDaiNau = {dsvs.Diem}  where MaVoSinh = '{dsvs.MaVoSinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }

        public static int LuuDiemDaiNau1(List<DiemSoDTO> danhsachvosinh)
        {
            int kq = 0;
            foreach (DiemSoDTO dsvs in danhsachvosinh)
            {
                string query = $"update BangDiemVoSinh set DiemDaiNau1 = {dsvs.Diem}  where MaVoSinh = '{dsvs.MaVoSinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }

        public static int LuuDiemDaiTim(List<DiemSoDTO> danhsachvosinh)
        {
            int kq = 0;
            foreach (DiemSoDTO dsvs in danhsachvosinh)
            {
                string query = $"update BangDiemVoSinh set DiemDaiTim = {dsvs.Diem}  where MaVoSinh = '{dsvs.MaVoSinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }

        public static int LuuDiemDaiVang(List<DiemSoDTO> danhsachvosinh)
        {
            int kq = 0;
            foreach (DiemSoDTO dsvs in danhsachvosinh)
            {
                string query = $"update BangDiemVoSinh set DiemDaiVang = {dsvs.Diem}  where MaVoSinh = '{dsvs.MaVoSinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }

        public static int LuuDiemDaiXanhDuong(List<DiemSoDTO> danhsachvosinh)
        {
            int kq = 0;
            foreach (DiemSoDTO dsvs in danhsachvosinh)
            {
                string query = $"update BangDiemVoSinh set DiemDaiXanhDuong = {dsvs.Diem}  where MaVoSinh = '{dsvs.MaVoSinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }

        public static int LuuDiemDaiXanhLuc(List<DiemSoDTO> danhsachvosinh)
        {
            int kq = 0;
            foreach (DiemSoDTO dsvs in danhsachvosinh)
            {
                string query = $"update BangDiemVoSinh set DiemDaiXanhLuc = {dsvs.Diem}  where MaVoSinh = '{dsvs.MaVoSinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }

        public static int ThemBangDiem(VoSinhDTO vosinh)
        {
            string query = $"insert into BangDiemVoSinh(MaVoSinh, DiemDaiVang,DiemDaiCam,DiemDaiXanhLuc,DiemDaiXanhDuong,DiemDaiDo,DiemDaiTim,DiemDaiNau,DiemDaiNau1,MaCLB) " +
                $"values('{vosinh.MaVoSinh}' ,0,0,0,0,0,0,0,0,'{vosinh.MaCLB}')";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }

        public static int XoaBangDiemVoSinh(string maCLB)
        {
            string query = $"delete BangDiemVoSinh where MaCLB = '{maCLB}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            int kq = DataProvider.ThucThiLenh(query, conn);
            conn.Close();
            return kq;
        }
    }
}
