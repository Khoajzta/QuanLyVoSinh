using Microsoft.Reporting.WinForms;
using QuanLyVoSinhBUS;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVoSinhGUI
{
    public partial class frm_InDanhSach : Form
    {
        TaiKhoanDTO taikhoan;
        string MaCLB;
        List<VoSinhDTO> danhsachvosinh;
        public frm_InDanhSach()
        {
            InitializeComponent();
        }
        public frm_InDanhSach(TaiKhoanDTO tk, string maCLB)
        {
            this.taikhoan = tk;
            InitializeComponent();
            MaCLB = maCLB;
        }
        private void frm_InDanhSach_Load(object sender, EventArgs e)
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            danhsachvosinh = voSinhBUS.LayDanhSachTheoCLB(MaCLB);
            int LayNamHienTai = DateTime.Now.Year;

            CauLacBoDTO clb = new CauLacBoDTO();
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            int LayThang = DateTime.Now.Month;
            int Thang = 1;
            if (LayThang <= 6)
                Thang = 1;
            else
                Thang = 7;
            clb = cauLacBoBUS.LayThongTin(MaCLB);

            ReportDataSource rds = new ReportDataSource("DanhSachVoSinh", danhsachvosinh);
            this.rpv_XemDanhSach.LocalReport.DataSources.Clear();
            this.rpv_XemDanhSach.LocalReport.DataSources.Add(rds);
            this.rpv_XemDanhSach.LocalReport.ReportEmbeddedResource = "QuanLyVoSinhGUI.rpt_InDanhSach.rdlc";
            this.rpv_XemDanhSach.LocalReport.SetParameters(new ReportParameter("NamHienTai", LayNamHienTai.ToString()));
            this.rpv_XemDanhSach.LocalReport.SetParameters(new ReportParameter("CauLacBo", clb.TenCLB.ToUpper()));
            this.rpv_XemDanhSach.LocalReport.SetParameters(new ReportParameter("Thang", Thang.ToString()));
            this.rpv_XemDanhSach.RefreshReport();
        }
    }
}
