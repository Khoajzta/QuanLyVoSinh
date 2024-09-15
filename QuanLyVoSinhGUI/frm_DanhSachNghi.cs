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
    public partial class frm_DanhSachNghi : Form
    {
        TaiKhoanDTO taikhoan;
        string MaCLB;
        List<VoSinhDTO> danhsachvosinhnghi;
        List<VoSinhDTO> danhsachvosinhnghiTheoCLB;
        List<VoSinhDTO> danhsachvosinhTheoCapDai;

        List<CauLacBoDTO> danhsachCLB;
        List<CapDaiDTO> danhsachCapDai;
        VoSinhDTO vosinh;
        public frm_DanhSachNghi()
        {
            InitializeComponent();
        }
        public frm_DanhSachNghi(TaiKhoanDTO tk, string maCLB)
        {
            this.taikhoan = tk;
            InitializeComponent();
            this.MaCLB = maCLB;
        }
        private void frm_DanhSachNghi_Load(object sender, EventArgs e)
        {
            dgv_DanhSachVoSinh.AutoGenerateColumns = false;

            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            CauLacBoDTO clb = new CauLacBoDTO();
            clb = cauLacBoBUS.LayThongTin(MaCLB);
            lbl_DANHSACH.Text = "CLB " + clb.TenCLB.ToUpper();
            lbl_HLV.Text = "HLV: " + clb.TenHLV;
            LoadCapDai();
            cbo_LocTheoCapDai.SelectedIndex = -1;
            LoadCLB();
            LoadDanhSachVoSinhNghiTheoCLB(MaCLB);
            dgv_DanhSachVoSinh.MouseWheel += new MouseEventHandler(dataGridView1_MouseWheel);
        }
        private void dataGridView1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) // Cuộn lên
            {
                if (dgv_DanhSachVoSinh.FirstDisplayedScrollingRowIndex > 0)
                {
                    dgv_DanhSachVoSinh.FirstDisplayedScrollingRowIndex--;
                }
            }
            else if (e.Delta < 0) // Cuộn xuống
            {
                if (dgv_DanhSachVoSinh.FirstDisplayedScrollingRowIndex < dgv_DanhSachVoSinh.RowCount - 1)
                {
                    dgv_DanhSachVoSinh.FirstDisplayedScrollingRowIndex++;
                }
            }
        }
        private void LoadDanhSachVoSinhNghi()
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            danhsachvosinhnghi = voSinhBUS.LayDanhSachVoSinhNghi();
            dgv_DanhSachVoSinh.DataSource = danhsachvosinhnghi;
        }
        private void LoadDanhSachVoSinhNghiTheoCLB(string MaCLB)
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            danhsachvosinhnghiTheoCLB = voSinhBUS.LayDanhSachVoSinhNghiTheoCLB(MaCLB);
            dgv_DanhSachVoSinh.DataSource = danhsachvosinhnghiTheoCLB;
        }
        private void LoadCLB()
        {
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            danhsachCLB = cauLacBoBUS.LayDanhSachCLB();
            col_MaCLB.DataSource = danhsachCLB;
            col_MaCLB.DisplayMember = "TenCLB";
            col_MaCLB.ValueMember = "MaCLB";
        }
        private void LoadCapDai()
        {
            CapDaiBUS capDaiBUS = new CapDaiBUS();
           danhsachCapDai = capDaiBUS.LayDanhSachCapDai();
            col_C1apDai.DataSource = danhsachCapDai;
            col_C1apDai.DisplayMember = "TenDai";
            col_C1apDai.ValueMember = "MaDai";

            cbo_LocTheoCapDai.DataSource = new List<CapDaiDTO>(danhsachCapDai);
            cbo_LocTheoCapDai.DisplayMember = "TenDai";
            cbo_LocTheoCapDai.ValueMember = "MaDai";
        }

        private void btn_DiHocLai_Click(object sender, EventArgs e)
        {
            if(vosinh == null)
            {
                MessageBox.Show("Vui lòng chọn võ sinh");
                return;
            }    
            if(HocLai()>0)
            {
                if(taikhoan.LoaiTaiKhoan == true)
                {
                    LoadDanhSachVoSinhNghi();
                }
                else
                {
                    LoadDanhSachVoSinhNghiTheoCLB(MaCLB);
                }
                MessageBox.Show("Võ sinh đã đi học lại", "Đi Học Lại");
                    
            }
            else
            {
                MessageBox.Show("Lỗi", "Đi Học Lại");
            }
        }
        private int HocLai()
        {
            List<string> danhsachmavosinh = new List<string>();
            foreach (DataGridViewRow row in dgv_DanhSachVoSinh.SelectedRows)
            {
                string MaVoSinh = row.Cells["col_MaVoSinh"].Value.ToString();
                danhsachmavosinh.Add(MaVoSinh);
            }
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            int kq = voSinhBUS.VoSinhComback(danhsachmavosinh);
            return kq;
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            int MaDai = (int)cbo_LocTheoCapDai.SelectedValue;
            LayDanhSachTheoDaivaCLB(MaDai, MaCLB);
        }
        private void LayDanhSachTheoDai(int MaDai)
        {
            VoSinhBUS vosinhBUS = new VoSinhBUS();
            danhsachvosinhTheoCapDai = vosinhBUS.LayDanhSachVoSinhNghiTheoDai(MaDai);
            dgv_DanhSachVoSinh.DataSource = danhsachvosinhTheoCapDai;
        }
        private void LayDanhSachTheoDaivaCLB(int MaDai,string MaCLB)
        {
            VoSinhBUS vosinhBUS = new VoSinhBUS();
            danhsachvosinhTheoCapDai = vosinhBUS.LayDanhSachVoSinhNghiTheoDaivaCLB(MaDai, MaCLB);
            dgv_DanhSachVoSinh.DataSource = danhsachvosinhTheoCapDai;
        }

        private void cbo_CLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachVoSinhNghiTheoCLB(MaCLB);
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_TimTheoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }    
            string Ten = txt_TimTheoTen.Text;
            LayDanhSachVSNghiTheoTenVaCLB(Ten,MaCLB);
            if(dgv_DanhSachVoSinh.Rows.Count == 0)
            {
                MessageBox.Show($"Không có võ sinh tên {txt_TimTheoTen.Text}","Tìm Kiếm");
            }    
        }
        private void LayDanhSachVSNghiTheoTenVaCLB(string Ten, string MaCLB)
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            danhsachvosinhnghi = voSinhBUS.LayDanhSachVoSinhNghiTheoTenVaCLB(Ten, MaCLB);
            dgv_DanhSachVoSinh.DataSource = danhsachvosinhnghi;
        }

        private void dgv_DanhSachVoSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachVoSinh.SelectedRows.Count > 0)
            {
                vosinh = dgv_DanhSachVoSinh.SelectedRows[0].DataBoundItem as VoSinhDTO;
            }
            else
            {
                vosinh = null;
            }
        }

        private void txt_TimTheoTen_TextChanged(object sender, EventArgs e)
        {
            string Ten = txt_TimTheoTen.Text;
            LayDanhSachVSNghiTheoTenVaCLB(Ten, MaCLB);
        }

        private void cbo_LocTheoCapDai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_LocTheoCapDai.SelectedIndex != -1)
            {
                int MaDai = cbo_LocTheoCapDai.SelectedIndex + 1;
                LayDanhSachTheoDaivaCLB(MaDai, MaCLB);
            }
        }

        private void cbo_LocTheoCapDai_Click(object sender, EventArgs e)
        {
            cbo_LocTheoCapDai.BorderColor = Color.FromArgb(20, 13, 11);
        }
    }
}
