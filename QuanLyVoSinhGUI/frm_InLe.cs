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
    public partial class frm_InLe : Form
    {
        List<DiemSoVoSinhDTO> diemSoVoSinhDTOs;
        string MaCLB;
        public frm_InLe(string maclb)
        {
            this.MaCLB = maclb;
            InitializeComponent();
        }

        private void frm_InLe_Load(object sender, EventArgs e)
        {
            cbo_CapDai.SelectedIndex = 0;
        }
        private CauLacBoDTO LayCauLacBo(string MaCLB)
        {
            CauLacBoDTO clb = new CauLacBoDTO();
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            clb = cauLacBoBUS.LayThongTin(MaCLB);
            return clb;
        }
        public CapDaiDTO LayTenDai()
        {
            int MaDai = cbo_CapDai.SelectedIndex + 2;
            CapDaiDTO capDaiDTO = new CapDaiDTO();
            CapDaiBUS capDaiBUS = new CapDaiBUS();
            capDaiDTO = capDaiBUS.LayThongTinCapDai(MaDai);
            return capDaiDTO;
        }
        private int KiemTraMaVoSinh(string MaVoSinh)
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            int kq = voSinhBUS.KiemTraMaVoSinh(MaVoSinh);
            return kq;
        }
        private void btn_InLe_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_MaVoSinh.Text))
            {
                MessageBox.Show("Vui lòng nhập mã võ sinh");
                return;
            }    
            if(string.IsNullOrWhiteSpace(txt_MaSo.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số");
                return;
            }
            if (KiemTraMaVoSinh(txt_MaVoSinh.Text) == 0)
            {
                MessageBox.Show("Võ sinh không tồn tại");
                return;
            }
            int MaDai = cbo_CapDai.SelectedIndex + 2;
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


            string MaVoSinh = txt_MaVoSinh.Text;
            ThongTinVoSinhBUS thongTinVoSinhBUS = new ThongTinVoSinhBUS();
            ThongTinVoSinhDTO thongtinvosinh = new ThongTinVoSinhDTO();

            thongtinvosinh = thongTinVoSinhBUS.LayThongTin(MaVoSinh);

            int MaDai2 = cbo_CapDai.SelectedIndex;
            float Diem = 0;
            switch (MaDai2)
            {
                case 0: Diem = thongtinvosinh.DiemDaiVang; break;
                case 1: Diem = thongtinvosinh.DiemDaiCam; break;
                case 2: Diem = thongtinvosinh.DiemDaiXanhLuc; break;
                case 3: Diem = thongtinvosinh.DiemDaiXanhDuong; break;
                case 4: Diem = thongtinvosinh.DiemDaiDo; break;
                case 5: Diem = thongtinvosinh.DiemDaiTim; break;
                case 6: Diem = thongtinvosinh.DiemDaiNau; break;
                case 7: Diem = thongtinvosinh.DiemDaiNau1; break;
            }

            string XepLoai = "";
            if (Diem >= 8)
                XepLoai = "Giỏi";
            else if (Diem >= 6.5 && Diem < 8)
                XepLoai = "Khá";
            else if (Diem >= 5 && Diem < 6.5)
                XepLoai = "Trung Bình";
            else if (Diem >= 3.5 && Diem < 5)
                XepLoai = "Yếu";
            else
                XepLoai = "Kém";

            string maso = txt_MaSo.Text;
            int ngay = DateTime.Now.Day;
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            ReportDataSource rds = new ReportDataSource("GCN", diemSoVoSinhDTOs);
            this.rpv_InGCNLe.LocalReport.DataSources.Clear();
            this.rpv_InGCNLe.LocalReport.DataSources.Add(rds);
            this.rpv_InGCNLe.LocalReport.ReportEmbeddedResource = "QuanLyVoSinhGUI.rpt_InGiayChungNhanLe.rdlc";
            this.rpv_InGCNLe.LocalReport.SetParameters(new ReportParameter("HoTen", thongtinvosinh.HoTen));
            this.rpv_InGCNLe.LocalReport.SetParameters(new ReportParameter("NamSinh", thongtinvosinh.NgaySinh.Year.ToString()));
            this.rpv_InGCNLe.LocalReport.SetParameters(new ReportParameter("DonVi", thongtinvosinh.DonVi));
            this.rpv_InGCNLe.LocalReport.SetParameters(new ReportParameter("Cap", CapDo));
            this.rpv_InGCNLe.LocalReport.SetParameters(new ReportParameter("MauDai", Dai.TenDai));
            this.rpv_InGCNLe.LocalReport.SetParameters(new ReportParameter("Diem", Diem.ToString()));
            this.rpv_InGCNLe.LocalReport.SetParameters(new ReportParameter("Ngay", ngay.ToString()));
            this.rpv_InGCNLe.LocalReport.SetParameters(new ReportParameter("Thang", thang.ToString()));
            this.rpv_InGCNLe.LocalReport.SetParameters(new ReportParameter("Nam", nam.ToString()));
            this.rpv_InGCNLe.LocalReport.SetParameters(new ReportParameter("MaSo", maso));
            this.rpv_InGCNLe.LocalReport.SetParameters(new ReportParameter("XepLoai", XepLoai));
            this.rpv_InGCNLe.RefreshReport();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_MaVoSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_MaSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
