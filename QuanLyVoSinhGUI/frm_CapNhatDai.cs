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
    public partial class frm_CapNhatDai : Form
    {
        TaiKhoanDTO taikhoan;
        string MaCLB;
        List<CapDaiDTO> danhsachCapDai;
        List<CauLacBoDTO> danhsachCLB;
        List<VoSinhDTO> danhsachvosinhTheoCLB;
        public frm_CapNhatDai()
        {
            InitializeComponent();
        }
        public frm_CapNhatDai(TaiKhoanDTO tk, string maCLB)
        {
            this.taikhoan = tk;
            InitializeComponent();
            MaCLB = maCLB;
        }
        private void frm_CapNhatDai_Load(object sender, EventArgs e)
        {
            dgv_DanhSachVoSinh.AutoGenerateColumns = false;
            LoadCapDai();
            LoadCLB();

            int MaDai = 0;
            if (cbo_CapDaiTruoc.SelectedValue != null)
            {
                MaDai = int.Parse(cbo_CapDaiTruoc.SelectedValue.ToString());
            }
            LayDanhSachTheoDaivaCLB(MaDai, MaCLB);
            dgv_DanhSachVoSinh.MouseWheel += new MouseEventHandler(dataGridView1_MouseWheel);
            lbl_nav.Text = $"DANH SÁCH VÕ SINH ĐAI {cbo_CapDaiTruoc.Text.ToUpper()}";
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
        private void LoadCapDai()
        {
            CapDaiBUS capDaiBUS = new CapDaiBUS();
            danhsachCapDai = capDaiBUS.LayDanhSachCapDai();
            cbo_CapDaiTruoc.DataSource = danhsachCapDai;
            cbo_CapDaiTruoc.DisplayMember = "TenDai";
            cbo_CapDaiTruoc.ValueMember = "MaDai";

            col_C1apDai.DataSource = new List<CapDaiDTO>(danhsachCapDai);
            col_C1apDai.DisplayMember = "TenDai";
            col_C1apDai.ValueMember = "MaDai";
            dgv_DanhSachVoSinh.AutoGenerateColumns = false;

            cbo_CapDaiSau.DataSource = new List<CapDaiDTO>(danhsachCapDai);
            cbo_CapDaiSau.DisplayMember = "TenDai";
            cbo_CapDaiSau.ValueMember = "MaDai";
        }
        private void LoadCLB()
        {
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            danhsachCLB = cauLacBoBUS.LayDanhSachCLB();
            col_MaCLB.DataSource = danhsachCLB;
            col_MaCLB.DisplayMember = "TenCLB";
            col_MaCLB.ValueMember = "MaCLB";
        }

        private void LoadDanhSachTheoCLB(string MaCLB)
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            danhsachvosinhTheoCLB = voSinhBUS.LayDanhSachTheoCLB(MaCLB);
            dgv_DanhSachVoSinh.DataSource = danhsachvosinhTheoCLB;
        }

        private void btn_LenDai_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachVoSinh.Rows.Count == 0)
            {
                MessageBox.Show("Cấp đai hiện tại chưa có võ sinh.", "Cập Nhật Đai");
                return;
            }
            if (dgv_DanhSachVoSinh.SelectedRows == null)
            {
                MessageBox.Show("Vui lòng chọn võ sinh để cập nhật đai.", "Cập Nhật Đai");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn đã chọn đúng theo tứ tự từ đai lớn đến đai nhỏ chưa?", "Cập Nhật Đai", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                int MaDai = 0;
                if (cbo_CapDaiTruoc.SelectedValue != null)
                {
                    MaDai = int.Parse(cbo_CapDaiTruoc.SelectedValue.ToString());
                }
                if (CapNhatDai() > 0 && CapNhatLaiDiem() > 0)
                {
                    MessageBox.Show("Cập nhật đai thành công");
                    LayDanhSachTheoDaivaCLB(MaDai, MaCLB);
                }
                else
                {
                    MessageBox.Show("Cập nhật đai thất bại");
                }
            }    
        }

        private int CapNhatLaiDiem()
        {
            List<string> danhsachvosinh = new List<string>();

            foreach (DataGridViewRow row in dgv_DanhSachVoSinh.SelectedRows)
            {
                string MaVoSinh = row.Cells["col_MaVoSinh"].Value.ToString();
                danhsachvosinh.Add(MaVoSinh);
            }
            DiemSoBUS diemSoBUS = new DiemSoBUS();
            int kq = DiemSoBUS.CapNhatLaiDiem(danhsachvosinh);
            return kq;
        }

        private int CapNhatDai()
        {
            List<string> danhsachvosinh = new List<string>();
            int MaDaiMoi = 0;
            if(cbo_CapDaiSau.SelectedValue != null)
            {
                MaDaiMoi = (int)cbo_CapDaiSau.SelectedValue;
            }    
            foreach (DataGridViewRow row in dgv_DanhSachVoSinh.SelectedRows)
            {
                string MaVoSinh = row.Cells["col_MaVoSinh"].Value.ToString();
                danhsachvosinh.Add(MaVoSinh);
            }
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            int kq = voSinhBUS.CapNhatDai(danhsachvosinh, MaDaiMoi);
            return kq;
        }

        private void cbo_CLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MaDai = 0;
            if (cbo_CapDaiTruoc.SelectedValue != null)
            {
                MaDai = int.Parse(cbo_CapDaiTruoc.SelectedValue.ToString());
            }
            LayDanhSachTheoDaivaCLB(MaDai, MaCLB);
        }

        private void cbo_CapDaiTruoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_nav.Text = $"DANH SÁCH VÕ SINH ĐAI {cbo_CapDaiTruoc.Text.ToUpper()}";
            
            int MaDai = cbo_CapDaiTruoc.SelectedIndex + 1;
            LayDanhSachTheoDaivaCLB(MaDai, MaCLB);
        }

        private void LayDanhSachTheoDaivaCLB(int MaDai, string MaCLB)
        {
            VoSinhBUS vosinhBUS = new VoSinhBUS();
            danhsachvosinhTheoCLB = vosinhBUS.LayDanhSachVoSinhTheoDaivaCLB(MaDai, MaCLB);
            dgv_DanhSachVoSinh.DataSource = danhsachvosinhTheoCLB;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
