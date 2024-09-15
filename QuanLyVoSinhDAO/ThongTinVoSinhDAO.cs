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
    public class ThongTinVoSinhDAO
    {
        public static ThongTinVoSinhDTO LayThongTin(string maVoSinh)
        {
            ThongTinVoSinhDTO thongtin = new ThongTinVoSinhDTO();
            string query = $"select vs.Ho + ' '+vs.Ten,vs.NgayNhapHoc,clb.TenCLB,hlv.TenHLV,cd.TenDai, bd.DiemDaiVang,bd.DiemDaiCam,bd.DiemDaiXanhLuc,bd.DiemDaiXanhDuong,bd.DiemDaiDo,bd.DiemDaiTim,bd.DiemDaiNau,bd.DiemDaiNau1,vs.NgaySinh,vs.TrangThai,dv.TenDonVi\r\nfrom VoSinh vs join CauLacBo clb on vs.MaCLB = clb.MaCLB \r\n\t\t\t\tjoin HuanLuyenVien hlv on clb.MaHLV = hlv.MaHLV  \r\n\t\t\t\tjoin DonVi dv on clb.MaDonVi = dv.MaDonVi\r\n\t\t\t\tjoin CapDai cd on vs.MaDai = cd.MaDai\r\n\t\t\t\tjoin BangDiemVoSinh bd on vs.MaVoSinh = bd.MaVoSinh\r\n where vs.MaVoSinh = '{maVoSinh}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            SqlDataReader sdr = DataProvider.TruyVan(query, conn);
            if (sdr.Read())
            {
                thongtin.HoTen = sdr[0].ToString();
                thongtin.NgayNhapHoc = (DateTime)sdr[1];
                thongtin.TenCLB = sdr[2].ToString();
                thongtin.TenHLV = sdr[3].ToString();
                thongtin.TenDai = sdr[4].ToString();
                thongtin.DiemDaiVang = float.Parse(sdr[5].ToString());
                thongtin.DiemDaiCam = float.Parse(sdr[6].ToString());
                thongtin.DiemDaiXanhLuc = float.Parse(sdr[7].ToString());
                thongtin.DiemDaiXanhDuong = float.Parse(sdr[8].ToString());
                thongtin.DiemDaiDo = float.Parse(sdr[9].ToString());
                thongtin.DiemDaiTim = float.Parse(sdr[10].ToString());
                thongtin.DiemDaiNau = float.Parse(sdr[11].ToString());
                thongtin.DiemDaiNau1 = float.Parse(sdr[12].ToString());
                thongtin.NgaySinh = (DateTime)sdr[13];
                thongtin.TrangThai = (int)sdr[14];
                thongtin.DonVi = sdr[15].ToString();
            }
            sdr.Close();
            conn.Close();
            return thongtin;
        }
    }
}
