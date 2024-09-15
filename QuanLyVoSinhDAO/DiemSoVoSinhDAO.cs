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
    public class DiemSoVoSinhDAO
    {
        public static List<DiemSoVoSinhDTO> LayDanhSachDiemSoVoSinhTheoDai(int madai, string maCLB)
        {
            List<DiemSoVoSinhDTO> DanhSachDiemSoVoSinhTheoDai = new List<DiemSoVoSinhDTO>();
            string query = $"select vs.MaVoSinh MaVoSinh,vs.Ho Ho,vs.Ten,vs.NgaySinh NgaySinh,vs.GioiTinh GioiTinh,vs.MaDai MaDai,ds.Diem Diem from VoSinh vs join DiemSo ds on vs.MaVoSinh = ds.MaVoSinh where vs.MaDai = {madai} and vs.MaCLB = '{maCLB}' and vs.TrangThai = 1";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                DiemSoVoSinhDTO diemSoVoSinh = new DiemSoVoSinhDTO();
                diemSoVoSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                diemSoVoSinh.Ho = sdr["Ho"].ToString();
                diemSoVoSinh.Ten = sdr["Ten"].ToString();
                diemSoVoSinh.NgaySinh = (DateTime)sdr["NgaySinh"];
                diemSoVoSinh.GioiTinh = sdr["GioiTinh"].ToString();
                diemSoVoSinh.MaDai = (int)sdr["MaDai"];
                diemSoVoSinh.Diem = float.Parse(sdr["Diem"].ToString());
                DanhSachDiemSoVoSinhTheoDai.Add(diemSoVoSinh);
            }
            sdr.Close();
            conn.Close();
            return DanhSachDiemSoVoSinhTheoDai;
        }

        public static List<DiemSoVoSinhDTO> LayDanhSachDiemSoVoSinhTheoDaiVaCLB(int maDai, string maCLB)
        {
            List<DiemSoVoSinhDTO> DanhSachDiemSoVoSinhTheoDai = new List<DiemSoVoSinhDTO>();
            string query = $"select vs.MaVoSinh MaVoSinh,vs.Ho Ho,vs.Ten Ten,vs.NgaySinh NgaySinh,vs.GioiTinh GioiTinh,vs.MaDai MaDai,vs.MaCLB MaCLB,ds.Diem Diem from VoSinh vs join DiemSo ds on vs.MaVoSinh = ds.MaVoSinh where vs.MaDai = {maDai} and vs.MaCLB = '{maCLB}' and vs.TrangThai = 1";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            while (sdr.Read())
            {
                DiemSoVoSinhDTO diemSoVoSinh = new DiemSoVoSinhDTO();
                diemSoVoSinh.MaVoSinh = sdr["MaVoSinh"].ToString();
                diemSoVoSinh.Ho = sdr["Ho"].ToString();
                diemSoVoSinh.Ten = sdr["Ten"].ToString();
                diemSoVoSinh.NgaySinh = (DateTime)sdr["NgaySinh"];
                diemSoVoSinh.GioiTinh = sdr["GioiTinh"].ToString();
                diemSoVoSinh.MaDai = (int)sdr["MaDai"];
                diemSoVoSinh.Diem = float.Parse(sdr["Diem"].ToString());
                diemSoVoSinh.MaCLB = sdr["MaCLB"].ToString();
                DanhSachDiemSoVoSinhTheoDai.Add(diemSoVoSinh);
            }
            sdr.Close();
            conn.Close();
            return DanhSachDiemSoVoSinhTheoDai;
        }

        public static int NhapDiem(List<DiemSoVoSinhDTO> danhsachvosinh)
        {
            int kq = 0;
            foreach (DiemSoVoSinhDTO dsvs in danhsachvosinh)
            {
                string query = $"update DiemSo set Diem = {dsvs.Diem} ,MaDai = {dsvs.MaDai}+1 where MaVoSinh = '{dsvs.MaVoSinh}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                kq = DataProvider.ThucThiLenh(query, conn);
                conn.Close();
            }
            return kq;
        }
    }
}
