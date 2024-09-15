using QuanLyHocSinhTHPT;
using QuanLyVoSinhBUS;
using QuanLyVoSinhDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVoSinhGUI
{
    public partial class frm_Admin : Form
    {
        List<CauLacBoDTO> danhsachCLB;
        List<TaiKhoanDTO> danhsachTaiKhoan;
        List<DonViDTO> danhsachDonVi;
        List<HuanLuyenVienDTO> danhsachHLV;
        CauLacBoDTO clb;
        TaiKhoanDTO taiKhoan;
        DonViDTO dv;
        HuanLuyenVienDTO hlv;
        frm_Login frm_Login;
        frm_main frm_Main;
        TaiKhoanDTO TaiKhoan;
        public frm_Admin()
        {
            InitializeComponent();
        }
        public frm_Admin(frm_main frm_Main, TaiKhoanDTO tk)
        {
            this.frm_Main = frm_Main;
            InitializeComponent();
            TaiKhoan = tk;
        }
        private void btn_CLB_Click(object sender, EventArgs e)
        { 
            if(sepe_TK.Visible == true)
            {
                sepe_TK.Visible = false;
            }    
            if(sepe_DonVi.Visible == true)
            {
                sepe_DonVi.Visible = false;
            }
            if (sepe_HLV.Visible == true)
            {
                sepe_HLV.Visible = false;
            }
            sepe_CLB.Visible = true;
            if(pnl_ThemTK.Visible == true)
            {
                pnl_ThemTK.Visible = false;
            }
            if (pnl_DonVi.Visible == true)
            {
                pnl_DonVi.Visible = false;
            }
            if (pnl_HLV.Visible == true)
            {
                pnl_HLV.Visible = false;
            }
            pnl_ThemCLB.Visible = true;

            if(dgv_DanhSachTaiKhoan.Visible == true)
            {
                dgv_DanhSachTaiKhoan.Visible = false;
            }
            if (dgv_DanhSachHLV.Visible == true)
            {
                dgv_DanhSachHLV.Visible = false;
            }
            if (dgv_DanhSachDonVi.Visible == true)
            {
                dgv_DanhSachDonVi.Visible = false;
            }
            dgv_DanhSach_CLB.Visible = true;
            LoadCLB();
            LoadDonVicol();
            LoadHLVcol();
            if (TaiKhoan.TenTaiKhoan != "admin")
            {
                btn_XoaCLB.Visible = false;
            }    
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            if (sepe_CLB.Visible == true)
            {
                sepe_CLB.Visible = false;
            }
            if (sepe_DonVi.Visible == true)
            {
                sepe_DonVi.Visible = false;
            }
            if (sepe_HLV.Visible == true)
            {
                sepe_HLV.Visible = false;
            }
            sepe_TK.Visible = true;
            if (pnl_ThemCLB.Visible == true)
            {
                pnl_ThemCLB.Visible = false;
            }
            if (pnl_DonVi.Visible == true)
            {
                pnl_DonVi.Visible = false;
            }
            if (pnl_HLV.Visible == true)
            {
                pnl_HLV.Visible = false;
            }
            pnl_ThemTK.Visible = true;
            if (dgv_DanhSach_CLB.Visible == true)
            {
                dgv_DanhSach_CLB.Visible = false;
            }
            if (dgv_DanhSachHLV.Visible == true)
            {
                dgv_DanhSachHLV.Visible = false;
            }
            if (dgv_DanhSachDonVi.Visible == true)
            {
                dgv_DanhSachDonVi.Visible = false;
            }
            dgv_DanhSachTaiKhoan.Visible=true;
            LoadTaiKhoan();
            LoadCLB();

            if(TaiKhoan.TenTaiKhoan != "admin")
            {
                btn_CapQuyen.Visible = false;
                btn_XoaQuyen.Visible = false;
            }    
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            LoadHLV();
            dgv_DanhSachTaiKhoan.AutoGenerateColumns = false;     
            dgv_DanhSach_CLB.AutoGenerateColumns = false;
            dgv_DanhSachHLV.AutoGenerateColumns = false;
            
            dgv_DanhSachTaiKhoan.MouseWheel += new MouseEventHandler(dgv_DanhSachTaiKhoan_MouseWheel);
            dgv_DanhSach_CLB.MouseWheel += new MouseEventHandler(dgv_DanhSach_CLB_MouseWheel);
            dgv_DanhSachDonVi.MouseWheel += new MouseEventHandler(dgv_DanhSachDonVi_MouseWheel);
            dgv_DanhSachHLV.MouseWheel += new MouseEventHandler(dgv_DanhSachHLV_MouseWheel);
            btn_DonVi_Click(sender, e);
            txt_LuuY.Multiline = true;
            txt_LuuY.Text = "Lưu ý: \r\nTài khoản sau khi được tạo, mật khẩu mặc định là 1. \r\nHLV đăng nhập vào tài khoản, vào mục thông tin tài khoản để đổi mật khẩu.";
        }
        private void dgv_DanhSachTaiKhoan_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (dgv_DanhSachTaiKhoan.FirstDisplayedScrollingRowIndex > 0)
                {
                    dgv_DanhSachTaiKhoan.FirstDisplayedScrollingRowIndex--;
                }
            }
            else if (e.Delta < 0)
            {
                if (dgv_DanhSachTaiKhoan.FirstDisplayedScrollingRowIndex < dgv_DanhSachTaiKhoan.RowCount - 1)
                {
                    dgv_DanhSachTaiKhoan.FirstDisplayedScrollingRowIndex++;
                }
            }
        }
        private void dgv_DanhSach_CLB_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) 
            {
                if (dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex > 0)
                {
                    dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex--;
                }
            }
            else if (e.Delta < 0) 
            {
                if (dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex < dgv_DanhSach_CLB.RowCount - 1)
                {
                    dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex++;
                }
            }
        }
        private void dgv_DanhSachDonVi_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex > 0)
                {
                    dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex--;
                }
            }
            else if (e.Delta < 0)
            {
                if (dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex < dgv_DanhSach_CLB.RowCount - 1)
                {
                    dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex++;
                }
            }
        }
        private void dgv_DanhSachHLV_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex > 0)
                {
                    dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex--;
                }
            }
            else if (e.Delta < 0)
            {
                if (dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex < dgv_DanhSach_CLB.RowCount - 1)
                {
                    dgv_DanhSach_CLB.FirstDisplayedScrollingRowIndex++;
                }
            }
        }
        private void LoadTaiKhoan()
        {
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            danhsachTaiKhoan = taiKhoanBUS.LayDanhSachTaiKhoan();
            dgv_DanhSachTaiKhoan.DataSource = danhsachTaiKhoan;
            
        }

        private void LoadCLB()
        {
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            danhsachCLB = cauLacBoBUS.LayDanhSachCLB();
            dgv_DanhSach_CLB.DataSource = danhsachCLB;
        }
        
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemCLB_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_MaCLB.Text) || string.IsNullOrWhiteSpace(txt_TenCLB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }    
            if(TrungCLB()>0)
            {
                MessageBox.Show("Mã Câu lạc bộ đã tồn tại");
                return;
            }    
            if(ThemCLB()>0)
            {
                MessageBox.Show("Thêm thành công.");
                LoadCLB();
                txt_TenCLB.ReadOnly = true;
                DialogResult dr2 = MessageBox.Show("Đăng nhập lại.", "", MessageBoxButtons.OK);
                if (dr2 == DialogResult.OK)
                {
                    frm_Main.Close();
                    frm_Login = new frm_Login();
                    frm_Login.Show();
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }
        private int TrungCLB()
        {
            LayThongTinCLB();
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            int kq = cauLacBoBUS.TrungCLB(clb);
            return kq;
        }
        private void LayThongTinCLB()
        {
            clb = new CauLacBoDTO();
            clb.MaCLB = txt_MaCLB.Text;
            clb.TenCLB = txt_TenCLB.Text;
            clb.MaDonVi = cbo_DonViCLB.SelectedValue.ToString();
            clb.MaHLV = cbo_HLVCLB.SelectedValue.ToString();
        }
        private int ThemCLB()
        {
            LayThongTinCLB();
            int kq = 0;
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            kq = cauLacBoBUS.ThemCLB(clb);
            return kq;
        }

        private void btn_SuaCLB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaCLB.Text) || string.IsNullOrWhiteSpace(txt_TenCLB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (SuaCLB() > 0)
            {
                MessageBox.Show("Sửa thành công.");
                LoadCLB();
                txt_TenCLB.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Sửa thất bại.");
            }
        }
        private int SuaCLB()
        {
            LayThongTinCLB();
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            int kq = cauLacBoBUS.SuaCLB(clb);
            return kq;
        }

        private void dgv_DanhSach_CLB_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSach_CLB.SelectedRows.Count > 0)
            {
                clb = dgv_DanhSach_CLB.SelectedRows[0].DataBoundItem as CauLacBoDTO;
            }
            else
            {
                clb = null;
            }
            HienThiThongTinCLB();
        }

        private void HienThiThongTinCLB()
        {
            if(clb!=null)
            {
                txt_MaCLB.Text = clb.MaCLB;
                txt_TenCLB.Text = clb.TenCLB;
                cbo_HLVCLB.SelectedValue = clb.MaHLV;
            }    
        }

        private void btn_XoaCLB_Click(object sender, EventArgs e)
        {
            if (clb == null)
            {
                MessageBox.Show("Vui lòng chọn câu lạc bộ muốn xóa");
                return;
            }
            if(string.IsNullOrWhiteSpace(txt_TenCLB.Text))
            {
                MessageBox.Show("Vui lòng chọn câu lạc bộ muốn xóa");
                return;
            }    
            LayThongTinCLB();

            if (LayMaAdmin() == clb.MaHLV)
            {
                MessageBox.Show("Không thể xóa câu lạc bộ của admin", "Xóa câu lạc bộ");
                return;
            }
            DialogResult dr = MessageBox.Show($"Bạn thật sự muốn xóa câu lạc bộ {txt_TenCLB.Text} ?", "Xóa Câu Lạc Bộ", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                if (XoaBangDiemVoSinh(clb.MaCLB) >= 0)
                {
                    if (XoaDiemVoSinh(clb.MaCLB) >= 0)
                    {
                        if (XoaVoSinh(clb.MaCLB) >= 0)
                        {
                            if (XoaTaiKhoanCuaCLB(clb.MaHLV) >= 0)
                            {
                                if (XoaCLB() > 0)
                                {
                                    MessageBox.Show("Xóa câu lạc bộ thành công", "Xóa Câu Lạc Bộ");
                                    DialogResult dr2 = MessageBox.Show("Đăng nhập lại.", "", MessageBoxButtons.OK);
                                    if (dr2 == DialogResult.OK)
                                    {
                                        frm_Main.Close();
                                        frm_Login = new frm_Login();
                                        frm_Login.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Xóa câu lạc bộ thất bại", "Xóa Câu Lạc Bộ");
                                    }
                                }
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Xóa câu lạc bộ thất bại", "Xóa Câu Lạc Bộ");
            }

        }

        private string LayMaAdmin()
        {
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            string MaAdmin = taiKhoanBUS.LayMaAdmin();
            return MaAdmin;
        }

        private int XoaTaiKhoanCuaCLB(string MaHLV)
        {
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            int kq = taiKhoanBUS.XoaTaiKhoanCuaCLB(MaHLV);
            return kq;
        }
        private int XoaBangDiemVoSinh(string MaCLB)
        {
            BangDiemVoSinhBUS bangDiemVoSinhBUS = new BangDiemVoSinhBUS();
            int kq = bangDiemVoSinhBUS.XoaBangDiemVoSinh(MaCLB);
            return kq;
        }
        private int XoaDiemVoSinh(string MaCLB)
        {
            DiemSoBUS diemSoBUS = new DiemSoBUS();
            int kq = diemSoBUS.XoaDiemVoSinh(MaCLB);
            return kq;
        }
        private int XoaVoSinh(string MaCLB)
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            int kq = voSinhBUS.XoaVoSinhTheoCLB(MaCLB);
            return kq;
        }
        private int XoaCLB()
        {
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            int kq = cauLacBoBUS.XoaCLB(clb);
            return kq;
        }
        
        private void btn_ResetCLB_Click(object sender, EventArgs e)
        {
            txt_MaCLB.ReadOnly = false;
            txt_MaCLB.Clear();
            txt_TenCLB.Clear();
            txt_TenCLB.ReadOnly = false;
        }

        private void dgv_DanhSachTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachTaiKhoan.SelectedRows.Count > 0)
            {
                taiKhoan = dgv_DanhSachTaiKhoan.SelectedRows[0].DataBoundItem as TaiKhoanDTO;
            }
            else
            {
                taiKhoan = null;
            }
            HienThiThongTinTaiKhoan();
        }

        private void HienThiThongTinTaiKhoan()
        {
            if(taiKhoan != null)
            {
                txt_TenTaiKhoan.Text = taiKhoan.TenTaiKhoan;
                cbo_TKHLV.SelectedValue = taiKhoan.MaHLV;
            }    
        }

        private void dgv_DanhSachTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_DanhSachTaiKhoan.Columns[e.ColumnIndex].Name == "col_LoaiTaiKhoan")
            {
                // Kiểm tra nếu giá trị trong ô là true
                if (e.Value != null && e.Value is bool && (bool)e.Value == true)
                {
                    e.Value = "Admin";
                    e.FormattingApplied = true;
                }
                // Kiểm tra nếu giá trị trong ô là false
                else if (e.Value != null && e.Value is bool && (bool)e.Value == false)
                {
                    e.Value = "HLV";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btn_ResetTK_Click(object sender, EventArgs e)
        {
            dgv_DanhSachTaiKhoan.ClearSelection();
            txt_TenTaiKhoan.Clear();
            //cbo_CLB.SelectedIndex = 0;
            txt_TenTaiKhoan.ReadOnly = false;
        }

        private void btn_ThemTK_Click(object sender, EventArgs e)
        {
            if(TrungUsername()>0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại.");
                return;
            }    
            if(string.IsNullOrWhiteSpace(txt_TenTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }    

            if(ThemTaiKhoan()>0)
            {
                MessageBox.Show("Thêm tài khoản thành công.", "Thêm tài khoản");
                LoadTaiKhoan();
            }    
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại.", "Thêm tài khoản");
            }
        }

        private int TrungUsername()
        {
            string Username = txt_TenTaiKhoan.Text;
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            int kq = taiKhoanBUS.TrungUsername(Username);
            return kq;
        }

        private void LayThongTinTK()
        {
            taiKhoan = new TaiKhoanDTO();
            taiKhoan.TenTaiKhoan = txt_TenTaiKhoan.Text;
            taiKhoan.MatKhau = Utils.MaHoa("1");
            taiKhoan.MaHLV = cbo_TKHLV.SelectedValue.ToString();
            //taiKhoan.MaCLB = cbo_CLB.SelectedValue.ToString();
        }
        private int ThemTaiKhoan()
        {
            LayThongTinTK();
            TaiKhoanBUS khoanBUS = new TaiKhoanBUS();
            int kq = TaiKhoanBUS.ThemTaiKhoan(taiKhoan);
            return kq;
        }

        private void btn_XoaTK_Click(object sender, EventArgs e)
        {
            if(txt_TenTaiKhoan.Text == TaiKhoan.TenTaiKhoan)
            {
                MessageBox.Show("Đây là tài của bạn, không thể xóa.","Xóa Tài Khoản");
                return;
            } 
            if(TaiKhoan.TenTaiKhoan != "admin")
            {
                if(KiemTraAdmin().LoaiTaiKhoan == true)
                {
                    MessageBox.Show("Đây là tài khoàn admin, không thể xóa.", "Xóa Tài Khoản");
                    return;
                }    
            }    
            DialogResult dr = MessageBox.Show($"Bạn muốn xóa tài khoản {txt_TenTaiKhoan.Text} ?", "Xóa Tài Khoản",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            { 
                if(XoaTaiKhoan()>0)
                {
                    MessageBox.Show("Xóa Tài khoản thành công","Xóa Tài Khoản");
                    LoadTaiKhoan();
                }    
                else
                {
                    MessageBox.Show("Xóa Tài khoản thất bại", "Xóa Tài Khoản");
                }    
            }
        }
        private TaiKhoanDTO KiemTraAdmin()
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            string TenTaiKhoan = txt_TenTaiKhoan.Text;
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            tk = taiKhoanBUS.KiemTraAdmin(TenTaiKhoan);
            return tk;
        }
        private int XoaTaiKhoan()
        {
            LayThongTinTK();
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            int kq = taiKhoanBUS.XoaTaiKhoan(taiKhoan);
            return kq;
        }

        private void btn_CapQuyen_Click(object sender, EventArgs e)
        {
            if(KiemTraAdmin().LoaiTaiKhoan == true)
            {
                MessageBox.Show("Tài khoản đã là Admin","Cấp Quyền Admin");
                return;
            }    
            if(CapQuyenAdmin()>0)
            {
                MessageBox.Show("Cấp quyền admin thành công.", "Cấp Quyền Admin");
                LoadTaiKhoan();
            }    
            else
            {
                MessageBox.Show("Cấp quyền admin thất bại.", "Cấp Quyền Admin");
            }    
        }
        private int CapQuyenAdmin()
        {
            LayThongTinTK();
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            int kq = taiKhoanBUS.CapQuyenAdmin(taiKhoan);
            return kq;
        }

        private void btn_XoaQuyen_Click(object sender, EventArgs e)
        {
            if(txt_TenTaiKhoan.Text == "admin")
            {
                MessageBox.Show("Không thể xóa quyền Admin tài khoản này", "Xóa Quyền Admin");
                return;
            }
            if (XoaQuyenAdmin() > 0)
            {
                MessageBox.Show("Xóa quyền admin thành công.", "Xóa Quyền Admin");
                LoadTaiKhoan();
            }
            else
            {
                MessageBox.Show("Xóa quyền admin thất bại.", "Xóa Quyền Admin");
            }
        }

        private int XoaQuyenAdmin()
        {
            LayThongTinTK();
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            int kq = taiKhoanBUS.XoaQuyenAdmin(taiKhoan);
            return kq;
        }

        private void btn_ResetPW_Click(object sender, EventArgs e)
        {
            if (ResetPW() > 0)
            {
                MessageBox.Show("Reset password thành công.", "Reset password");
                LoadTaiKhoan();
            }
            else
            {
                MessageBox.Show("Reset password thất bại.", "Reset password");
            }
        }
        private int ResetPW()
        {
            string TenTaiKhoan = txt_TenTaiKhoan.Text;
            string MKReset = Utils.MaHoa("1");
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            int kq = taiKhoanBUS.ResetPW(TenTaiKhoan, MKReset);
            return kq;
        }

        private void txt_MaCLB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pnl_ThemTK_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_DonVi_Click(object sender, EventArgs e)
        {
            if (sepe_TK.Visible == true)
            {
                sepe_TK.Visible = false;
            }
            if (sepe_CLB.Visible == true)
            {
                sepe_CLB.Visible = false;
            }
            if (sepe_HLV.Visible == true)
            {
                sepe_HLV.Visible = false;
            }
            sepe_DonVi.Visible = true;
            if (pnl_ThemTK.Visible == true)
            {
                pnl_ThemTK.Visible = false;
            }
            if (pnl_ThemCLB.Visible == true)
            {
                pnl_ThemCLB.Visible = false;
            }
            if (pnl_HLV.Visible == true)
            {
                pnl_HLV.Visible = false;
            }
            pnl_DonVi.Visible = true;
            if (dgv_DanhSachTaiKhoan.Visible == true)
            {
                dgv_DanhSachTaiKhoan.Visible = false;
            }
            if (dgv_DanhSachHLV.Visible == true)
            {
                dgv_DanhSachHLV.Visible = false;
            }
            if (dgv_DanhSach_CLB.Visible == true)
            {
                dgv_DanhSach_CLB.Visible = false;
            }
            dgv_DanhSachDonVi.Visible = true;
            LoadDonVi();
            if (TaiKhoan.TenTaiKhoan != "admin")
            {
                btn_XoaDonVi.Visible = false;
            }
        }

        private void LoadDonVi()
        {
            DonViBUS donViBUS = new DonViBUS();
            danhsachDonVi = donViBUS.LayDanhSach();
            dgv_DanhSachDonVi.DataSource = danhsachDonVi;
        }
        private void LoadDonVicol()
        {
            DonViBUS donViBUS = new DonViBUS();
            danhsachDonVi = donViBUS.LayDanhSach();
            col_DonVi.DataSource = danhsachDonVi;
            col_DonVi.DisplayMember = "TenDonVi";
            col_DonVi.ValueMember = "MaDonVi";

            cbo_DonViCLB.DataSource = new List<DonViDTO>(danhsachDonVi);
            cbo_DonViCLB.DisplayMember = "TenDonVi";
            cbo_DonViCLB.ValueMember = "MaDonVi";
        }
        private void btn_HLV_Click(object sender, EventArgs e)
        {
            if (sepe_TK.Visible == true)
            {
                sepe_TK.Visible = false;
            }
            if (sepe_DonVi.Visible == true)
            {
                sepe_DonVi.Visible = false;
            }
            if (sepe_CLB.Visible == true)
            {
                sepe_CLB.Visible = false;
            }
            sepe_HLV.Visible = true;
            if (pnl_ThemTK.Visible == true)
            {
                pnl_ThemTK.Visible = false;
            }
            if (pnl_DonVi.Visible == true)
            {
                pnl_DonVi.Visible = false;
            }
            if (pnl_ThemCLB.Visible == true)
            {
                pnl_ThemCLB.Visible = false;
            }
            pnl_HLV.Visible = true;
            if (dgv_DanhSachTaiKhoan.Visible == true)
            {
                dgv_DanhSachTaiKhoan.Visible = false;
            }
            if (dgv_DanhSachDonVi.Visible == true)
            {
                dgv_DanhSachDonVi.Visible = false;
            }
            if (dgv_DanhSach_CLB.Visible == true)
            {
                dgv_DanhSach_CLB.Visible = false;
            }
            dgv_DanhSachHLV.Visible = true;
            LoadHLV();
            if (TaiKhoan.TenTaiKhoan != "admin")
            {
                btn_XoaHLV.Visible = false;
            }
        }

        private void LoadHLV()
        {
            dgv_DanhSachHLV.AutoGenerateColumns = false;
            HuanLuyenVienBUS huanLuyenVienBUS = new HuanLuyenVienBUS();
            danhsachHLV = huanLuyenVienBUS.LayDanhSach();
            dgv_DanhSachHLV.DataSource = danhsachHLV;

            cbo_TKHLV.DataSource = new List<HuanLuyenVienDTO>(danhsachHLV);
            cbo_TKHLV.DisplayMember = "TenHLV";
            cbo_TKHLV.ValueMember = "MaHLV";

            col_MâHLV2.DataSource = new List<HuanLuyenVienDTO>(danhsachHLV);
            col_MâHLV2.DisplayMember = "TenHLV";
            col_MâHLV2.ValueMember = "MaHLV";
        }
        private void LoadHLVcol()
        {
            HuanLuyenVienBUS huanLuyenVienBUS = new HuanLuyenVienBUS();
            danhsachHLV = huanLuyenVienBUS.LayDanhSach();
            col_HLV.DataSource = danhsachHLV;
            col_HLV.DisplayMember = "TenHLV";
            col_HLV.ValueMember = "MaHLV";

            cbo_HLVCLB.DataSource = new List<HuanLuyenVienDTO>(danhsachHLV);
            cbo_HLVCLB.DisplayMember = "TenHLV";
            cbo_HLVCLB.ValueMember = "MaHLV";

            
        }
        private void dgv_DanhSachDonVi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachDonVi.SelectedRows.Count > 0)
            {
                dv = dgv_DanhSachDonVi.SelectedRows[0].DataBoundItem as DonViDTO;
            }
            else
            {
                dv = null;
            }
            HienThiThongTinDonVi();
        }

        private void HienThiThongTinDonVi()
        {
            if(dv!=null)
            {
                txt_MaDonVi.Text = dv.MaDonVi.ToString();
                txt_TenDonVi.Text=dv.TenDonVi.ToString();
            }    
        }

        private void btn_ThemDonVi_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_MaDonVi.Text) || string.IsNullOrWhiteSpace(txt_TenDonVi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thêm Đơn Vị");
                return;
            }    
            if(TrungMaDonVi()>0)
            {
                MessageBox.Show("Mã đơn vị đã tồn tại", "Trùng Mã Đơn vị");
                return;
            }    
            if(ThemDonVi()>0)
            {
                MessageBox.Show("Thêm đơn vị thành công", "Thêm Đơn Vị");
                LoadDonVi();
                txt_MaDonVi.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Thêm đơn vị không thành công", "Thêm Đơn Vị");
            }
        }

        private int TrungMaDonVi()
        {
            string MaDonVi = txt_MaDonVi.Text;
            DonViBUS donViBUS = new DonViBUS();
            int kq = donViBUS.TrungMaDonVi(MaDonVi);
            return kq;
        }

        private int ThemDonVi()
        {
            LayThongTinDonVi();
            DonViBUS donViBUS = new DonViBUS();
            int kq = donViBUS.ThemDonVi(dv);
            return kq;
        }

        private void LayThongTinDonVi()
        {
            dv = new DonViDTO();
            dv.MaDonVi = txt_MaDonVi.Text;
            dv.TenDonVi = txt_TenDonVi.Text;
        }

        private void btn_ResetDonVi_Click(object sender, EventArgs e)
        {
            txt_MaDonVi.ReadOnly = false;
            dgv_DanhSachDonVi.ClearSelection();
            txt_MaDonVi.Clear();
            txt_TenDonVi.Clear();
        }

        private void btn_SuaDonVi_Click(object sender, EventArgs e)
        {
            if(dv !=null)
            {
                if (SuaDonVi() > 0)
                {
                    MessageBox.Show("Sửa tên đơn vị thành công", "Sửa đơn vị");
                    LoadDonVi();
                }
                else
                {
                    MessageBox.Show("Sửa tên đơn vị không thành công", "Sửa đơn vị");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn vị để sửa", "Sửa đơn vị");
            }
            
        }

        private int SuaDonVi()
        {
            LayThongTinDonVi();
            DonViBUS donViBUS = new DonViBUS();
            int kq = donViBUS.SuaDonVi(dv);
            return kq;
        }

        private void btn_XoaDonVi_Click(object sender, EventArgs e)
        {
            if(dv !=null)
            {
                if (KiemTraDonViTrongCLB(dv.MaDonVi) > 0)
                {
                    MessageBox.Show($"Bạn phải xóa các câu lạc bộ thuộc đơn vị {txt_TenDonVi.Text} trước, sau đó mới xóa đơn vị {txt_TenDonVi.Text}", "Xóa Dơn vị");
                    return;
                }

                DialogResult dr = MessageBox.Show($"Bạn có thật sự muốn xóa đơn vị {dv.TenDonVi} không ?", "Xóa Đơn Vị", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if(XoaDonVi()>0)
                    {
                        MessageBox.Show("Xóa đơn vị thành công.","Xóa Đơn Vị");
                        LoadDonVi();
                    }   
                    else
                    {
                        MessageBox.Show("Xóa đơn vị không thành công", "Xóa Đơn Vị");
                    }    
                }  
            }
              
        }

        private int XoaDonVi()
        {
            LayThongTinDonVi();
            DonViBUS donViBUS=new DonViBUS();
            int kq = donViBUS.XoaDonVi(dv);
            return kq;
        }

        private int KiemTraDonViTrongCLB(string MaDonVi)
        {
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            int kq = cauLacBoBUS.KiemTraDonViTrongCLB(MaDonVi);
            return kq;  
        }

        private void dgv_DanhSachHLV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachHLV.SelectedRows.Count > 0)
            {
                hlv = dgv_DanhSachHLV.SelectedRows[0].DataBoundItem as HuanLuyenVienDTO;
            }
            else
            {
                hlv = null;
            }
            HienThiThongTinHLV();
        }

        private void HienThiThongTinHLV()
        {
            if(hlv != null)
            {
                txt_MaHLV.Text = hlv.MaHLV;
                txt_TenHLV2.Text = hlv.TenHLV;
                txt_SDT.Text = hlv.SDT;
                byte[] imageBytes = hlv.HinhAnh;
                if (imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pic_AVT.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pic_AVT.Image = Properties.Resources.icon_User1;
                }    
            }    
        }

        private void btn_ThemHLV_Click(object sender, EventArgs e)
        {
               
            if (string.IsNullOrWhiteSpace(txt_MaHLV.Text) || string.IsNullOrWhiteSpace(txt_TenHLV2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thêm Huấn Luyện Viên");
                return;
            }
            if (txt_MaHLV.TextLength < 3)
            {
                MessageBox.Show("Mã huấn luyện viên bắt buộc 3 chữ số");
                return;
            }
            if (TrungMaHLV() > 0)
            {
                MessageBox.Show("Mã Huấn luyện viên đã tồn tại", "Trùng Huấn Luyện Viên");
                return;
            }
            if(ThemHLV()>0)
            {
                MessageBox.Show("Thêm huấn luyện viên thành công","Thêm Huấn Luyện Viên");
                LoadHLV();
                txt_MaHLV.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Thêm huấn luyện viên không thành công", "Thêm Huấn Luyện Viên");
            }    

        }

        private int ThemHLV()
        {
            LayThongTinHLV();
            HuanLuyenVienBUS huanLuyenVienBUS = new HuanLuyenVienBUS();
            int kq = huanLuyenVienBUS.ThemHLV(hlv);
            return kq;
        }

        private void LayThongTinHLV()
        {
            hlv = new HuanLuyenVienDTO();
            hlv.MaHLV = txt_MaHLV.Text;

            hlv.SDT = string.IsNullOrWhiteSpace(txt_SDT.Text) ? "Trống" : txt_SDT.Text;

            hlv.TenHLV = txt_TenHLV2.Text;

            // Kiểm tra hình ảnh của PictureBox có tồn tại không
            if (pic_AVT.Image != null)
            {
                hlv.HinhAnh = ImageToByteArray(pic_AVT);
            }
            else
            {
                hlv.HinhAnh = null; // Hoặc bạn có thể đặt giá trị mặc định khác nếu cần
            }
        }

        private byte[] ImageToByteArray(PictureBox pic)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Kiểm tra hình ảnh có tồn tại không trước khi lưu
                if (pic.Image != null)
                {
                    pic.Image.Save(ms, pic.Image.RawFormat);
                    return ms.ToArray();
                }
                else
                {
                    return null; // Hoặc bạn có thể trả về mảng byte rỗng hoặc giá trị mặc định khác
                }
            }
        }


        private int TrungMaHLV()
        {
            string MaHLV = txt_MaHLV.Text;
            HuanLuyenVienBUS huanLuyenVienBUS = new HuanLuyenVienBUS();
            int kq = huanLuyenVienBUS.TrungMaHLV(MaHLV);
            return kq;
        }

        private void btn_ResetHLV_Click(object sender, EventArgs e)
        {
            txt_MaHLV.ReadOnly = false;
            dgv_DanhSachHLV.ClearSelection();
            txt_MaHLV.Clear();
            txt_TenHLV2.Clear();
            txt_SDT.Clear();
            pic_AVT.Image = Properties.Resources.icon_User1;
        }

        private void btn_SuaHLV_Click(object sender, EventArgs e)
        {
            if(hlv!=null)
            {
                if(SuaHLV()>0)
                {
                    MessageBox.Show("Sửa huấn luyện viên thành công", "Sửa Huấn Luyện Viên");
                    LoadHLV();
                }
                else
                {
                    MessageBox.Show("Sửa huấn luyện viên khôngthành công", "Sửa Huấn Luyện Viên");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn huấn luyện viên để sửa", "Sửa Huấn Luyện Viên");
            }
        }

        private int SuaHLV()
        {
            LayThongTinHLV();
            HuanLuyenVienBUS huanLuyenVienBUS = new HuanLuyenVienBUS();
            int kq = huanLuyenVienBUS.SuaHLV(hlv);
            return kq;
        }

        private void btn_XoaHLV_Click(object sender, EventArgs e)
        {
            if (hlv != null)
            {
                if (KiemTraHLVTrongCLB(hlv.MaHLV) > 0)
                {
                    MessageBox.Show($"Bạn phải thay đổi huấn luyện viên cho các câu lạc bộ mà huấn luyện viên {txt_TenHLV2.Text} đang giảng dạy trước, sau đó mới xóa huấn luyện viên {txt_TenHLV2.Text}.");
                    return;
                }

                DialogResult dr = MessageBox.Show($"Bạn có thật sự muốn xóa huấn luyện viên {txt_TenHLV2.Text} không ?", "Xóa Huấn Luyện Viên", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (XoaHLV() > 0)
                    {
                        MessageBox.Show("Xóa huấn luyện viên thành công.", "Xóa Huấn Luyện Viên");
                        LoadHLV();
                    }
                    else
                    {
                        MessageBox.Show("Xóa huấn luyện viên không thành công", "Xóa Huấn Luyện Viên");
                    }
                }
            }
        }

        private int XoaHLV()
        {
            LayThongTinHLV();
            HuanLuyenVienBUS huanLuyenVienBUS = new HuanLuyenVienBUS();
            int kq = huanLuyenVienBUS.XoaHLV(hlv);
            return kq;
        }

        private int KiemTraHLVTrongCLB(string maHLV)
        {
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            int kq = cauLacBoBUS.KiemTraHLVTrongCLB(maHLV);
            return kq;
        }

        private void dgv_DanhSachHLV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void pic_AVT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Chỉ cho phép chọn các file hình ảnh
                openFileDialog.Title = "Chọn hình ảnh";

                // Nếu người dùng chọn file và nhấn OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Gọi hàm để hiển thị ảnh
                    LoadImageFromPath(openFileDialog.FileName);
                }
            }
        }
        private void LoadImageFromPath(string imagePath)
        {
            try
            {
                // Kiểm tra file ảnh có tồn tại không
                if (System.IO.File.Exists(imagePath))
                {
                    // Load hình ảnh từ đường dẫn
                    Image img = Image.FromFile(imagePath);

                    // Hiển thị hình ảnh trong PictureBox
                    pic_AVT.Image = img;
                }
                else
                {
                    MessageBox.Show("File ảnh không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
