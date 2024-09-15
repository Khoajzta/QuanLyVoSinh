using Guna.UI2.WinForms;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyVoSinhGUI
{
    public partial class frm_main : Form
    {
        bool SidebarExpand;
        private bool isDragging = false;
        private Point clickOffset;  

        TaiKhoanDTO taikhoan;
        frm_DanhSach frm_DanhSach;
        frm_Login frm_Login;
        frm_DanhSachNghi frm_DanhSachNghi;
        frm_XemGCN frm_XemGCN;
        frm_NhapDiem frm_NhapDiem;
        frm_CapNhatDai frm_CapNhatDai;
        frm_InDanhSach frm_InDanhSach;
        frm_Admin frm_Admin;
        frm_TaiKhoan frm_TaiKhoan;
        frm_XemThongTin frm_XemThongTin;

        List<CauLacBoDTO> danhsachCLB;
        List<CauLacBoDTO> danhsachCLBCuaHLV;

        public frm_main()
        {
            InitializeComponent();
        }
        public frm_main(TaiKhoanDTO TK)
        {
            this.taikhoan = TK;
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

        }

        private Guna2ComboBox GetCbo_CLB()
        {
            return cbo_CLB;
        }

        private void LoadCLB()
        {
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            danhsachCLB = cauLacBoBUS.LayDanhSachCLB();
            cbo_CLB.DataSource = danhsachCLB;
            cbo_CLB.DisplayMember = "TenCLB";
            cbo_CLB.ValueMember = "MaCLB";
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thoát", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ThemFormConVaoPanel(Form f)
        {
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            pnl_HienThi.Controls.Clear();
            pnl_HienThi.Controls.Add(f);
            f.Show();
        }
        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            string MaCLB = cbo_CLB.SelectedValue.ToString();
            
            if (frm_DanhSach == null || frm_DanhSach.IsDisposed)
            {
                frm_DanhSach = new frm_DanhSach(taikhoan,MaCLB);
            }
            else
            {
                frm_DanhSach.Dispose();
                frm_DanhSach = new frm_DanhSach(taikhoan,MaCLB);
            }
            ThemFormConVaoPanel(frm_DanhSach);
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.guna2Elipse1.BorderRadius = 40;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.guna2Elipse1.BorderRadius = 0;
            }
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn đăng xuất ?", "Đăng Xuất", MessageBoxButtons.YesNo);
            if(dr== DialogResult.Yes)
            {
                frm_Login = new frm_Login();
                frm_Login.Show();
                this.Close();
            }    
        }

        private void btn_DSVS_Nghi_Click(object sender, EventArgs e)
        {
            string MaCLB = cbo_CLB.SelectedValue.ToString();
            
            if (frm_DanhSachNghi == null || frm_DanhSachNghi.IsDisposed)
            {
                frm_DanhSachNghi = new frm_DanhSachNghi(taikhoan, MaCLB);
            }
            else
            {
                frm_DanhSachNghi.Dispose();
                frm_DanhSachNghi = new frm_DanhSachNghi(taikhoan, MaCLB);
            }
            ThemFormConVaoPanel(frm_DanhSachNghi);
        }

        private void btn_NhapDiem_Click(object sender, EventArgs e)
        {
            string MaCLB = cbo_CLB.SelectedValue.ToString();


            if (frm_NhapDiem == null || frm_NhapDiem.IsDisposed)
            {
                frm_NhapDiem = new frm_NhapDiem(taikhoan,MaCLB);
            }
            else
            {
                frm_NhapDiem.Dispose();
                frm_NhapDiem = new frm_NhapDiem(taikhoan,MaCLB);
            }
            ThemFormConVaoPanel(frm_NhapDiem);
        }

        private void btn_InGCN_Click(object sender, EventArgs e)
        {
            string MaCLB = cbo_CLB.SelectedValue.ToString();
            

            if (frm_XemGCN == null || frm_XemGCN.IsDisposed)
            {
                frm_XemGCN = new frm_XemGCN(taikhoan,MaCLB);
            }
            else
            {
                frm_XemGCN.Dispose();
                frm_XemGCN = new frm_XemGCN(taikhoan,MaCLB);
            }
            ThemFormConVaoPanel(frm_XemGCN);
        }

        private void btn_CapNhatDai_Click(object sender, EventArgs e)
        {
            
            string MaCLB = cbo_CLB.SelectedValue.ToString();
            

            if (frm_CapNhatDai == null || frm_CapNhatDai.IsDisposed)
            {
                frm_CapNhatDai = new frm_CapNhatDai(taikhoan,MaCLB);
            }
            else
            {
                frm_CapNhatDai.Dispose();
                frm_CapNhatDai = new frm_CapNhatDai(taikhoan,MaCLB);
            }
            ThemFormConVaoPanel(frm_CapNhatDai);
            MessageBox.Show($"Lưu ý: \n\nHãy cập nhật lần lượt từ đai lớn đến đai nhỏ để tránh bị trộn giữa cấp đai cũ và cấp đai mới","Cập Nhật Đai",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btn_InDanhSach_Click(object sender, EventArgs e)
        {
            string MaCLB = cbo_CLB.SelectedValue.ToString();
            
            if (frm_InDanhSach == null || frm_InDanhSach.IsDisposed)
            {
                frm_InDanhSach = new frm_InDanhSach(taikhoan,MaCLB);
            }
            else
            {
                frm_InDanhSach.Dispose();
                frm_InDanhSach = new frm_InDanhSach(taikhoan,MaCLB);
            }
            ThemFormConVaoPanel(frm_InDanhSach);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thoát", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thoát Chương Trình", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2CirclePictureBox2_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.guna2Elipse1.BorderRadius = 40;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.guna2Elipse1.BorderRadius = 0;
            }
        }

        private void guna2CirclePictureBox3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void cbo_CLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaCLB = "";
            if(cbo_CLB.SelectedValue != null)
            {
                MaCLB = cbo_CLB.SelectedValue.ToString();
            }

            pnl_HienThi.Controls.Clear();
            if (btn_DanhSach.Checked == true)
            {
                frm_DanhSach = new frm_DanhSach(taikhoan, MaCLB);
                ThemFormConVaoPanel(frm_DanhSach);
            }
            if (btn_DSVS_Nghi.Checked == true)
            {
                frm_DanhSachNghi = new frm_DanhSachNghi(taikhoan, MaCLB);
                ThemFormConVaoPanel(frm_DanhSachNghi);
            }
            if (btn_NhapDiem.Checked == true)
            {
                frm_NhapDiem = new frm_NhapDiem(taikhoan, MaCLB);
                ThemFormConVaoPanel(frm_NhapDiem);
            }
            if (btn_InGCN.Checked == true)
            {
                frm_XemGCN = new frm_XemGCN(taikhoan, MaCLB);
                ThemFormConVaoPanel(frm_XemGCN);
            }
            if (btn_CapNhatDai.Checked == true)
            {
                frm_CapNhatDai = new frm_CapNhatDai(taikhoan, MaCLB);
                ThemFormConVaoPanel(frm_CapNhatDai);
            }
            if(btn_InDanhSach.Checked == true)
            {
                frm_InDanhSach = new frm_InDanhSach(taikhoan,MaCLB);
                ThemFormConVaoPanel(frm_InDanhSach);
            }
            if (btn_Admin.Checked == true)
            {
                frm_Admin = new frm_Admin(this, taikhoan);
                ThemFormConVaoPanel(frm_Admin);
            }
        }

        

        private void btn_Thu_Click(object sender, EventArgs e)
        {
            btn_Thu.Visible = false;
            btn_Bu.Visible = true;
            cbo_CLB.Visible = false;
            lbl_CauLacBo.Visible = false;
            pnl_ChucNang.Width = 60;
            pnl_HienThi.Width = 1436; 
        }

        private void btn_Bu_Click_1(object sender, EventArgs e)
        {
            btn_Thu.Visible = true;
            btn_Bu.Visible = false;
            cbo_CLB.Visible = true;
            lbl_CauLacBo.Visible = true;
            pnl_ChucNang.Width = 282;
            pnl_HienThi.Width = 1214;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            if (taikhoan.LoaiTaiKhoan != true)
            {
                
                btn_Admin.Visible = false;
                btn_CheckThongTin.Visible = false;
                LoadCLBCuaHLV(taikhoan.MaHLV);
            }
            else 
            {
                LoadCLB();
            }
            if (this.WindowState == FormWindowState.Minimized)
            {
                guna2Elipse1.BorderRadius = 0;
            }
            
            btn_DanhSach.PerformClick();
        }

        private void LoadCLBCuaHLV(string maHLV)
        {
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            danhsachCLBCuaHLV = cauLacBoBUS.LayDanhSachCLBCuaHLV(maHLV);
            cbo_CLB.DataSource = danhsachCLBCuaHLV;
            cbo_CLB.DisplayMember = "TenCLB";
            cbo_CLB.ValueMember = "MaCLB";
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            if (frm_Admin == null || frm_Admin.IsDisposed)
            {
                frm_Admin = new frm_Admin(this,taikhoan);
            }
            else
            {
                frm_Admin.Dispose();
                frm_Admin = new frm_Admin(this,taikhoan);
            }
            ThemFormConVaoPanel(frm_Admin);
        }

       
        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            string MaCLB = cbo_CLB.SelectedValue.ToString();
            frm_TaiKhoan = new frm_TaiKhoan(taikhoan, MaCLB);
            frm_TaiKhoan.ShowDialog();
        }

        private void btn_CheckThongTin_Click(object sender, EventArgs e)
        {
            frm_XemThongTin = new frm_XemThongTin();
            frm_XemThongTin.ShowDialog();
        }

        private void pnl_ChucNang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Nav_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pnl_Nav_DoubleClick(object sender, EventArgs e)
        {
            guna2CirclePictureBox2_Click_1(null, null);
        }

        private void pnl_HienThi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
