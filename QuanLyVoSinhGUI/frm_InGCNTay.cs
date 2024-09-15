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
    public partial class frm_InGCNTay : Form
    {
        int MaDai;
        string MaCLB;

        List<DiemSoVoSinhDTO> diemSoVoSinhDTOs;
        public frm_InGCNTay()
        {
            InitializeComponent();
        }
        public frm_InGCNTay(int MaDai, string MaCLB)
        {
            this.MaDai = MaDai;
            this.MaCLB = MaCLB;
            InitializeComponent();
        }

        public CapDaiDTO LayTenDai()
        {
            CapDaiDTO capDaiDTO = new CapDaiDTO();
            CapDaiBUS capDaiBUS = new CapDaiBUS();
            capDaiDTO = capDaiBUS.LayThongTinCapDai(MaDai);
            return capDaiDTO;
        }
        private CauLacBoDTO LayCauLacBo(string MaCLB)
        {
            CauLacBoDTO clb = new CauLacBoDTO();    
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            clb = cauLacBoBUS.LayThongTin(MaCLB);
            return clb;
        }
        private void frm_InGCNTay_Load(object sender, EventArgs e)
        {
            string CapDo = "";
            if (MaDai == 2)
                CapDo = "Cấp 08";
            if (MaDai == 3)
                CapDo = "Cấp 07";
            if (MaDai == 4)
                CapDo = "Cấp 06";
            if (MaDai == 5)
                CapDo = "Cấp 05";
            if (MaDai == 6)
                CapDo = "Cấp 04";
            if (MaDai == 7)
                CapDo = "Cấp 03";
            if (MaDai == 8)
                CapDo = "Cấp 02";
            if (MaDai == 9)
                CapDo = "Cấp 01";

            CauLacBoDTO clb = LayCauLacBo(MaCLB);
            CapDaiDTO Dai = LayTenDai();
            DiemSoVoSinhBUS diemSoVoSinhBUS = new DiemSoVoSinhBUS();
            diemSoVoSinhDTOs = diemSoVoSinhBUS.LayDanhSachDiemSoVoSinhTheoDai(MaDai - 1, MaCLB);

            int nam = DateTime.Now.Year;
            ReportDataSource rds = new ReportDataSource("GiayChungNhanTay", diemSoVoSinhDTOs);
            this.rpv_InGCNTay.LocalReport.DataSources.Clear();
            this.rpv_InGCNTay.LocalReport.DataSources.Add(rds);
            this.rpv_InGCNTay.LocalReport.ReportEmbeddedResource = "QuanLyVoSinhGUI.rpt_InGiayChungNhanTay.rdlc";
            this.rpv_InGCNTay.LocalReport.SetParameters(new ReportParameter("Cap", CapDo));
            this.rpv_InGCNTay.LocalReport.SetParameters(new ReportParameter("MauDai", Dai.TenDai));
            this.rpv_InGCNTay.LocalReport.SetParameters(new ReportParameter("DonVi", clb.TenDonVi));
            this.rpv_InGCNTay.LocalReport.SetParameters(new ReportParameter("Nam", nam.ToString()));
            this.rpv_InGCNTay.RefreshReport();
        }
    }
}
