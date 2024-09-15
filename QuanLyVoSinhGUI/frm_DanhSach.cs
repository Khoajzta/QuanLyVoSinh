using QuanLyVoSinhBUS;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVoSinhGUI
{
    public partial class frm_DanhSach : Form
    {
        TaiKhoanDTO taikhoan;
        string MaCLB;
        List<VoSinhDTO> danhsachvosinh;
        List<VoSinhDTO> danhsachvosinhTheoCLB;
        List<VoSinhDTO> danhsachvosinhTheoCapDai;
        List<VoSinhDTO> danhsachvosinhTheoTen;
        List<CapDaiDTO> danhsachCapDai;
        List<CauLacBoDTO> danhsachCLB;
        frm_XemThongTin frm_XemDiem;

        VoSinhDTO vosinh;
        public frm_DanhSach()
        {
            InitializeComponent();
            dgv_DanhSachVoSinh.MouseWheel += new MouseEventHandler(dataGridView1_MouseWheel);
        }
        public frm_DanhSach(TaiKhoanDTO tk,string maclb)
        {
            this.taikhoan = tk;
            this.MaCLB = maclb;
            
            InitializeComponent();
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

        private void btn_Them_Click(object sender, EventArgs e)
        {          
            if (string.IsNullOrWhiteSpace(txt_Ho.Text) || string.IsNullOrWhiteSpace(txt_Ten.Text) || string.IsNullOrWhiteSpace(txt_NgaySinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thêm võ sinh");
                return;
            }
            if(txt_MaVoSinh.TextLength <10)
            {
                MessageBox.Show("Mã võ sinh bắt buộc phải 10 chữ số");
                return;
            }    
            string dateString = txt_NgaySinh.Text;
            string dadateString2 = txt_NgayNhapHoc.Text;
            DateTime date;
            if (!DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!","Ngày Sinh");
                txt_NgaySinh.Clear();
                return;
            }
            if(!DateTime.TryParseExact(dadateString2, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                MessageBox.Show("Ngày nhập học không hợp lệ!","Ngày Nhập Học");
                txt_NgayNhapHoc.Clear();
                return;
            }    

            if (TrungMaVoSinh() > 0)
            {
                MessageBox.Show("Võ sinh đã tồn tại", "Thêm võ sinh");
                return;
            }
            if (ThemVoSinh() > 0 && ThemDiem() > 0 && ThemBangDiem() > 0)
            {
                MessageBox.Show("Thêm võ sinh thành công.", "Thêm võ sinh");
                LoadDanhSachTheoCLB(MaCLB);
                btn_Them.Image = Properties.Resources.icon_khoa_removebg_preview;
                txt_MaVoSinh.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Thêm võ sinh thất bại.", "Thêm võ sinh");
            }
        }

        private int ThemBangDiem()
        {
            LayThongTin();
            BangDiemVoSinhBUS bangDiemVoSinhBUS = new BangDiemVoSinhBUS();
            int kq = bangDiemVoSinhBUS.ThemBangDiem(vosinh);
            return kq;
        }

        private int TrungMaVoSinh()
        {
            LayThongTin();
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            int kq = voSinhBUS.TrungMaVoSinh(vosinh);
            return kq;
        }
        private int ThemVoSinh()
        {
            LayThongTin();
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            int kq = voSinhBUS.ThemVoSinh(vosinh);
            return kq;
        }
        private int ThemDiem()
        {
            LayThongTin();
            DiemSoBUS diemSoBUS = new DiemSoBUS();
            int kq = diemSoBUS.ThemDiemSo(vosinh);
            return kq;
        }
        public void ReestForm()
        {
            txt_MaVoSinh.Visible = false;
            dgv_DanhSachVoSinh.AutoGenerateColumns = false;
            LoadCLB();
            LoadCapDai();
            LoadDanhSachTheoCLB(MaCLB);
        }
        private void frm_DanhSach_Load(object sender, EventArgs e)
        {
              
            cbo_LocTheoCapDai.Text = "";
            lbl_MaCLB.Text = "Mã CLB: " + MaCLB;

            if (vosinh==null)
            {
                txt_MaVoSinh.PlaceholderText = "Reset để nhập mã võ sinh";
                txt_Ho.ReadOnly = true;
                txt_Ten.ReadOnly = true;
                txt_NgaySinh.ReadOnly = true;
                txt_NgayNhapHoc.ReadOnly = true;
            }

            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            CauLacBoDTO clb = new CauLacBoDTO();
            clb = cauLacBoBUS.LayThongTin(MaCLB);
            lbl_DANHSACH.Text = "CLB "+ clb.TenCLB.ToUpper();
            lbl_HLV.Text = "HLV: " + clb.TenHLV;
            lbl_MaHLV.Text = "Mã HLV: "+clb.MaHLV;
            lbl_MaDonVi.Text = "Mã Đơn Vị: "+clb.MaDonVi;

            btn_Them.Enabled = false;
            dgv_DanhSachVoSinh.AutoGenerateColumns = false;
            LoadCLB();
            LoadCapDai();
            cbo_LocTheoCapDai.SelectedIndex = -1;
            cbo_SapXep.SelectedIndex = 0;
            cbo_LocTheoCapDai.SelectedText = "Lọc Theo Đai";
            
            LoadDanhSachTheoCLB(MaCLB);
            dgv_DanhSachVoSinh.MouseWheel += new MouseEventHandler(dataGridView1_MouseWheel);
            cbo_GioiTinh.SelectedIndex = 0;
        }
        
        private void LoadCapDai()
        {
            CapDaiBUS capDaiBUS = new CapDaiBUS();
            danhsachCapDai = capDaiBUS.LayDanhSachCapDai();
            cbo_CapDai.DataSource = danhsachCapDai;
            cbo_CapDai.DisplayMember = "TenDai";
            cbo_CapDai.ValueMember = "MaDai";

            col_CapDai.DataSource = new List<CapDaiDTO>(danhsachCapDai);
            col_CapDai.DisplayMember = "TenDai";
            col_CapDai.ValueMember = "MaDai";
            dgv_DanhSachVoSinh.AutoGenerateColumns = false;

            cbo_LocTheoCapDai.DataSource = new List<CapDaiDTO>(danhsachCapDai);
            cbo_LocTheoCapDai.DisplayMember = "TenDai";
            cbo_LocTheoCapDai.ValueMember = "MaDai";
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
        private void HienThiThongTin()
        {
            if (vosinh != null)
            {
                txt_MaVoSinh.Text = vosinh.MaVoSinh.ToString();
                txt_Ho.Text = vosinh.Ho;
                txt_Ten.Text = vosinh.Ten;
                txt_NgaySinh.Text = vosinh.NgaySinh;
                cbo_GioiTinh.Text = vosinh.GioiTinh;
                cbo_CapDai.SelectedValue = vosinh.MaDai;
                txt_NgayNhapHoc.Text = vosinh.NgayNhapHoc.ToString();
            }
            else
            {
                txt_Ho.Clear();
                txt_Ten.Clear();
                txt_NgaySinh.Clear();
                cbo_CapDai.SelectedValue = 0;
            }
        }
        private void LayThongTin()
        {
            vosinh = new VoSinhDTO();
            vosinh.MaVoSinh = txt_MaVoSinh.Text;
            vosinh.Ho = txt_Ho.Text;
            vosinh.Ten = txt_Ten.Text;
            vosinh.NgaySinh = txt_NgaySinh.Text;
            vosinh.GioiTinh = cbo_GioiTinh.Text;
            vosinh.MaDai = (int)cbo_CapDai.SelectedValue;
            vosinh.NgayNghi = DateTime.Now;
            vosinh.MaCLB = MaCLB;
            vosinh.NgayNhapHoc = txt_NgayNhapHoc.Text;

        }

        private void pnl_ChucNang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbo_CLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachTheoCLB(MaCLB);
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
            HienThiThongTin();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            CauLacBoDTO clb = new CauLacBoDTO();
            clb = cauLacBoBUS.LayThongTin(MaCLB);
            if (string.IsNullOrWhiteSpace(txt_MaVoSinh.Text))
            {
                MessageBox.Show($"Nhập Mã Võ Sinh Theo Định Dạng: \n\nMã Đơn Vị + Mã CLB + Mã HLV + Mã Võ Sinh\n\nVD: {clb.MaDonVi.Trim()}{clb.MaCLB.Trim()}{clb.MaHLV.Trim()}001", "Nhập Mã Võ Sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaVoSinh.PlaceholderText = "Nhập Số";
            }

            //if (string.IsNullOrWhiteSpace(txt_MaVoSinh.Text))
            //{
            //    txt_MaVoSinh.Text = clb.MaDonVi+clb.MaCLB+clb.MaHLV+"001";
            //}
            if (txt_MaVoSinh.Text != "")
            {
                txt_MaVoSinh.Clear();
            }
            btn_Them.Enabled = true;
            btn_Them.Image = Properties.Resources.iconThem;

            txt_Ho.ReadOnly = false;
            txt_Ten.ReadOnly = false;
            txt_NgaySinh.ReadOnly = false;
            txt_NgayNhapHoc.ReadOnly = false;

            if (dgv_DanhSachVoSinh.Rows.Count == 0)
            {
                txt_MaVoSinh.ReadOnly = false;
                return;
            }
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            int SoCuoiMoi;
            string MaVoSinhMax = voSinhBUS.LayMaVoSinhLonNhat(MaCLB);
            int MaVoSinhTiepTheo =int.Parse(MaVoSinhMax) + 1;
            SoCuoiMoi = int.Parse(MaVoSinhMax) + 1;
            txt_MaVoSinh.Text = "0" + MaVoSinhTiepTheo.ToString();
            dgv_DanhSachVoSinh.ClearSelection();
            txt_Ho.Clear();
            txt_Ten.Clear();
            txt_NgayNhapHoc.Clear();
            txt_NgaySinh.Clear();
            cbo_GioiTinh.SelectedIndex = 0;
            cbo_CapDai.SelectedValue = 1;

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachVoSinh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn võ sinh để sửa thông tin", "Sửa thông tin");
                return;
            }

            if (SuaThongTin() > 0)
            {
                MessageBox.Show("Cập nhật thông tin võ sinh thành công.", "Sửa thông tin");
                LoadDanhSachTheoCLB(MaCLB);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin võ sinh thất bại.", "Sửa thông tin");
            }
        }
        private int SuaThongTin()
        {
            LayThongTin();
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            int kq = voSinhBUS.SuaVoSinh(vosinh);
            return kq;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachVoSinh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn võ sinh để cho nghỉ", "Võ sinh nghỉ học");
                return;
            }
            DialogResult dr = MessageBox.Show($"Bạn có thật sự muốn cho võ sinh {txt_Ho.Text} {txt_Ten.Text} nghỉ học không?", "Võ sinh nghỉ học", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (XoaVoSinh() > 0)
                {
                    MessageBox.Show($"Võ sinh {txt_Ho.Text} {txt_Ten.Text} đã nghỉ học.", "Võ sinh nghỉ học");
                    LoadDanhSachTheoCLB(MaCLB);
                }
                else
                {
                    MessageBox.Show("Lỗi!!!", "Võ sinh nghỉ học");
                }
            }
            else
            {
                MessageBox.Show("Võ sinh vẫn còn học.", "Võ sinh nghỉ học");
            }
        }

        private int XoaVoSinh()
        {
            string MaVoSinh = txt_MaVoSinh.Text;
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            int kq = voSinhBUS.XoaVoSinh(MaVoSinh);
            return kq;
        }
        private void btn_Loc_Click(object sender, EventArgs e)
        {
            int MaDai = (int)cbo_LocTheoCapDai.SelectedValue;
            LayDanhSachTheoDaivaCLB(MaDai, MaCLB);
        }
        private void LayDanhSachTheoDaivaCLB(int MaDai,string MaCLB)
        {
            VoSinhBUS vosinhBUS = new VoSinhBUS();
            danhsachvosinhTheoCapDai = vosinhBUS.LayDanhSachVoSinhTheoDaivaCLB(MaDai, MaCLB);
            dgv_DanhSachVoSinh.DataSource = danhsachvosinhTheoCapDai;
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TimTheoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }
            string Ten = txt_TimTheoTen.Text;
            LayDanhSachTheoTen(Ten, MaCLB);
            if (dgv_DanhSachVoSinh.Rows.Count == 0)
            {
                MessageBox.Show($"Không có võ sinh tên {txt_TimTheoTen.Text}", "Tìm Kiếm");
            }
        }
        private void LayDanhSachTheoTen(string Ten,string MaCLB)
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            danhsachvosinhTheoTen = voSinhBUS.LayDanhSachVoSinhTheoTenVaCLB(Ten, MaCLB);
            dgv_DanhSachVoSinh.DataSource = danhsachvosinhTheoTen;
        }

        private void btn_Them_EnabledChanged(object sender, EventArgs e)
        {
            if(btn_Them.Enabled == false)
            {
                btn_Them.FillColor = Color.FromArgb(255, 192, 173);
            } 
            
        }

        private void lbl_DANHSACH_Click(object sender, EventArgs e)
        {

        }

        private void dgv_DanhSachVoSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txt_TimTheoTen_TextChanged(object sender, EventArgs e)
        {
            string Ten = txt_TimTheoTen.Text;
            LayDanhSachTheoTen(Ten, MaCLB);  
        }

        private void cbo_LocTheoCapDai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_LocTheoCapDai.SelectedIndex != -1)
            {
                int MaDai = cbo_LocTheoCapDai.SelectedIndex +1;
                LayDanhSachTheoDaivaCLB(MaDai, MaCLB);
            }    
        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_XemThpngTin_Click(object sender, EventArgs e)
        {
            frm_XemDiem = new frm_XemThongTin();
            frm_XemDiem.ShowDialog();
        }

        private void txt_MaVoSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_NgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void txt_NgayNhapHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_TimTheoTen_TextChanged_1(object sender, EventArgs e)
        {
            string Ten = txt_TimTheoTen.Text;
            LayDanhSachTheoTen(Ten, MaCLB);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbo_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_SapXep.SelectedIndex == 0)
            {
                SapXepTheoDai();
            } 
            if(cbo_SapXep.SelectedIndex == 1)
            {
                SapXepTheoTen();
            }
            if (cbo_SapXep.SelectedIndex == 2)
            {
                SapXepTheoNgayNhapHoc();
            }
        }

        private void SapXepTheoNgayNhapHoc()
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            danhsachvosinh = voSinhBUS.SapXepTheoNgayNhapHoc(MaCLB);
            dgv_DanhSachVoSinh.DataSource = danhsachvosinh;
        }

        private void SapXepTheoTen()
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            danhsachvosinh = voSinhBUS.SapXepTheoTen(MaCLB);
            dgv_DanhSachVoSinh.DataSource = danhsachvosinh;
        }

        private void SapXepTheoDai()
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            danhsachvosinh = voSinhBUS.SapXepTheoDai(MaCLB);
            dgv_DanhSachVoSinh.DataSource = danhsachvosinh;
        }
    }
}
