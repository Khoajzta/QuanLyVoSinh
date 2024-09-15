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
    public partial class frm_NhapDiem : Form
    {
        TaiKhoanDTO taikhoan;
        string MaCLB;
        List<CapDaiDTO> danhsachCapDai;
        List<DiemSoVoSinhDTO> danhsachdiemsovosinhTheoDai;
        List<CauLacBoDTO> danhsachCLB;

        public frm_NhapDiem()
        {
            InitializeComponent();
        }
        public frm_NhapDiem(TaiKhoanDTO tk, string maCLB)
        {
            this.taikhoan = tk;
            InitializeComponent();
            this.MaCLB = maCLB;
        }
        private void btn_NhapDiem_Click(object sender, EventArgs e)
        {
            if(dgv_DanhSachVoSinh.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có võ sinh", "Nhập Điểm");
                return;
            }    
            int madai = cbo_CapDai.SelectedIndex + 1 ;
             
            if (NhapDiem() > 0 && LuuDiem(madai) > 0)
            {
                MessageBox.Show("Nhập điểm thành công", "Nhập điểm");
                int MaDai = cbo_CapDai.SelectedIndex + 1;
                LayDanhSachDiemSoVoSinhTheoDaiVaCLB(MaDai, MaCLB);
            }
            else
            {
                MessageBox.Show("Lỗi !!\nNhập điểm thất bại", "Nhập Điểm");
            }
        }
        private int LuuDiem(int madai)
        {
            List<DiemSoDTO> danhsachvosinh = new List<DiemSoDTO>();

            foreach (DataGridViewRow row in dgv_DanhSachVoSinh.SelectedRows)
            {
                DiemSoDTO diemSoDTO = new DiemSoDTO();
                diemSoDTO.MaVoSinh = row.Cells["col_MaVoSinh"].Value.ToString();
                diemSoDTO.Diem = float.Parse(row.Cells["col_Diem"].Value.ToString());
                danhsachvosinh.Add(diemSoDTO);
            }
            BangDiemVoSinhBUS bangDIemVoSinhBUS = new BangDiemVoSinhBUS();
            int kq = 0;
            switch (madai)
            {
                case 1:
                    {
                        kq = bangDIemVoSinhBUS.LuuDiemDaiVang(danhsachvosinh);
                        break;
                    }

                case 2:
                    {
                        kq = bangDIemVoSinhBUS.LuuDiemDaiCam(danhsachvosinh);
                        break;
                    }
                case 3:
                    {
                        kq = bangDIemVoSinhBUS.LuuDiemDaiXanhLuc(danhsachvosinh);
                        break;
                    }
                case 4:
                    {
                        kq = bangDIemVoSinhBUS.LuuDiemDaiXanhDuong(danhsachvosinh);
                        break;
                    }
                case 5:
                    {
                        kq = bangDIemVoSinhBUS.LuuDiemDaiDo(danhsachvosinh);
                        break;
                    }
                case 6:
                    {
                        kq = bangDIemVoSinhBUS.LuuDiemDaiTim(danhsachvosinh);
                        break;
                    }
                case 7:
                    {
                        kq = bangDIemVoSinhBUS.LuuDiemDaiNau(danhsachvosinh);
                        break;
                    }
                case 8:
                    {
                        kq = bangDIemVoSinhBUS.LuuDiemDaiNau1(danhsachvosinh);
                        break;
                    }
            }
            return kq;
            
        }
        private int NhapDiem()
        {
            List<DiemSoVoSinhDTO> danhsachvosinh = new List<DiemSoVoSinhDTO>();

            foreach (DataGridViewRow row in dgv_DanhSachVoSinh.SelectedRows)
            {
                DiemSoVoSinhDTO diemSoVoSinhDTO = new DiemSoVoSinhDTO();
                diemSoVoSinhDTO.MaVoSinh = row.Cells["col_MaVoSinh"].Value.ToString();
                diemSoVoSinhDTO.Diem = float.Parse(row.Cells["col_Diem"].Value.ToString());
                diemSoVoSinhDTO.MaDai = int.Parse(row.Cells["col_CapDai"].Value.ToString());
                danhsachvosinh.Add(diemSoVoSinhDTO);
            }
            DiemSoVoSinhBUS diemSoVoSinhBUS = new DiemSoVoSinhBUS();
            int kq = diemSoVoSinhBUS.NhapDiem(danhsachvosinh);
            return kq;
        }
        private void cbo_CapDai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MaDai = cbo_CapDai.SelectedIndex + 1;
            CapDaiBUS capDaiBUS = new CapDaiBUS();
            CapDaiDTO daicu = capDaiBUS.LayThongTinCapDai(MaDai);
            CapDaiDTO daimoi = capDaiBUS.LayThongTinCapDai(MaDai + 1);
            
            LayDanhSachDiemSoVoSinhTheoDaiVaCLB(MaDai, MaCLB);
            lbl_nav.Text = $"BẢNG ĐIỂM ĐAI {daicu.TenDai.ToUpper()} LÊN ĐAI {daimoi.TenDai.ToUpper()}";
        }
        private void LoadCLB()
        {
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            danhsachCLB = cauLacBoBUS.LayDanhSachCLB();
            col_MaCLB.DataSource = danhsachCLB;
            col_MaCLB.DisplayMember = "TenCLB";
            col_MaCLB.ValueMember = "MaCLB";

           
        }
        private void frm_NhapDiem_Load(object sender, EventArgs e)
        {
            dgv_DanhSachVoSinh.AutoGenerateColumns = false;
            LoadCapDai();
            LoadCLB();
            cbo_CapDai.SelectedIndex = 0;
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
        private void LoadCapDai()
        {
            CapDaiBUS capDaiBUS = new CapDaiBUS();
            danhsachCapDai = capDaiBUS.LayDanhSachCapDai();
            col_CapDai.DataSource = danhsachCapDai;
            col_CapDai.DisplayMember = "TenDai";
            col_CapDai.ValueMember = "MaDai";
        }
        private void LayDanhSachDiemSoVoSinhTheoDaiVaCLB(int MaDai,string MaCLB)
        {
            DiemSoVoSinhBUS diemSoVoSinhBUS = new DiemSoVoSinhBUS();
            danhsachdiemsovosinhTheoDai = diemSoVoSinhBUS.LayDanhSachDiemSoVoSinhTheoDaiVaCLB(MaDai, MaCLB);
            dgv_DanhSachVoSinh.DataSource = danhsachdiemsovosinhTheoDai;
            dgv_DanhSachVoSinh.Columns["col_NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void cbo_CLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MaDai = cbo_CapDai.SelectedIndex + 1;
            LayDanhSachDiemSoVoSinhTheoDaiVaCLB(MaDai, MaCLB);
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
