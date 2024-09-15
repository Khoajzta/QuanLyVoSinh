using QuanLyVoSinhDAO;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVoSinhBUS
{
    public class VoSinhBUS
    {
        public List<VoSinhDTO> LayDanhSachTheoCLB(string maCLB)
        {
            return VoSinhDAO.LayDanhSachTheoCLB(maCLB);
        }

        public List<VoSinhDTO> LayDanhSachVoSinh()
        {
            return VoSinhDAO.LayDanhSachVoSinh();
        }

        public List<VoSinhDTO> LayDanhSachVoSinhNghi()
        {
            return VoSinhDAO.LayDanhSachVoSinhNghi();
        }

        public List<VoSinhDTO> LayDanhSachVoSinhNghiTheoCLB(string maCLB)
        {
            return VoSinhDAO.LayDanhSachVoSinhNghiTheoCLB(maCLB);
        }

        public List<VoSinhDTO> LayDanhSachVoSinhNghiTheoDai(int maDai)
        {
            return VoSinhDAO.LayDanhSachVoSinhNghiTheoDai(maDai);
        }

        public List<VoSinhDTO> LayDanhSachVoSinhNghiTheoDaivaCLB(int maDai, string maCLB)
        {
            return VoSinhDAO.LayDanhSachVoSinhNghiTheoDaivaCLB(maDai, maCLB);
        }

        public List<VoSinhDTO> LayDanhSachVoSinhNghiTheoTenVaCLB(string ten, string maCLB)
        {
            return VoSinhDAO.LayDanhSachVoSinhNghiTheoTenVaCLB(ten, maCLB);
        }

        public List<VoSinhDTO> LayDanhSachVoSinhTheoDaivaCLB(int maDai,string MaCLB)
        {
            return VoSinhDAO.LayDanhSachVoSinhTheoDaivaCLB(maDai, MaCLB);
        }

        public List<VoSinhDTO> LayDanhSachVoSinhTheoTenVaCLB(string ten, string MaCLB)
        {
            return VoSinhDAO.LayDanhSachVoSinhTheoTenVaCLB(ten, MaCLB);
        }

        public string LayMaVoSinhLonNhat(string maCLB)
        {
            return VoSinhDAO.LayMaVoSinhMax(maCLB);
        }

        public int SuaVoSinh(VoSinhDTO vosinh)
        {
            return VoSinhDAO.SuaVoSinh(vosinh);
        }

        public int CapNhatDai(List<string> danhsachvosinh, int MaDai)
        {
            return VoSinhDAO.CapNhatDai(danhsachvosinh, MaDai);
        }

        public int ThemVoSinh(VoSinhDTO vosinh)
        {
            return VoSinhDAO.ThemVoSinh(vosinh);
        }

        public int TrungMaVoSinh(VoSinhDTO vosinh)
        {
            return VoSinhDAO.TrungMaVoSinh(vosinh);
        }

        public int VoSinhComback(List<string> danhsachmavosinh)
        {
            return VoSinhDAO.VoSinhComback(danhsachmavosinh);
        }

        public int XoaVoSinh(string maVoSinh)
        {
            return VoSinhDAO.XoaVoSinh(maVoSinh);
        }

        public int XoaVoSinhTheoCLB(string maCLB)
        {
            return VoSinhDAO.XoaVoSinhTheoCLB(maCLB);
        }

        public int KiemTraMaVoSinh(string maVoSinh)
        {
            return VoSinhDAO.KiemTraMaVoSinh(maVoSinh);
        }

        public List<VoSinhDTO> SapXepTheoDai(string MaCLB)
        {
            return VoSinhDAO.SapXepTheoDai(MaCLB);
        }

        public List<VoSinhDTO> SapXepTheoNgayNhapHoc(string MaCLB)
        {
            return VoSinhDAO.SapXepTheoNgayNhapHoc(MaCLB);
        }

        public List<VoSinhDTO> SapXepTheoTen(string MaCLB)
        {
            return VoSinhDAO.SapXepTheoTen(MaCLB);
        }
    }
}
