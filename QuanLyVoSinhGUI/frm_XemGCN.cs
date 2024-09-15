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
    public partial class frm_XemGCN : Form
    {
        TaiKhoanDTO taikhoan;
        string MaCLB;
        List<CauLacBoDTO> danhsachCLB;
        frm_InGCNMay frm_InGCNBangMay;
        frm_InGCNTay frm_InGCNTay;
        frm_InGCNChuaDiem frm_InGCNChuaDiem;
        frm_InLe frm_InLe;
        public frm_XemGCN()
        {
            InitializeComponent();
        }
        public frm_XemGCN(TaiKhoanDTO tk, string maCLB)
        {
            this.taikhoan = tk;
            InitializeComponent();
            this.MaCLB = maCLB;
        }
        private void btn_NhapTay_Click(object sender, EventArgs e)
        {
            int MaDai = cbo_CapDai.SelectedIndex + 2;
            string MaSo = txt_MaSo.Text;
            if (frm_InGCNTay == null || frm_InGCNTay.IsDisposed)
            {
                frm_InGCNTay = new frm_InGCNTay(MaDai, MaCLB);
            }
            else
            {
                frm_InGCNTay.Dispose();
                frm_InGCNTay = new frm_InGCNTay(MaDai, MaCLB);
            }
            ThemFormConVaoPanel(frm_InGCNTay);
        }
        private void ThemFormConVaoPanel(Form f)
        {
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            pnl_HienThi.Controls.Clear();
            pnl_HienThi.Controls.Add(f);
            f.Show();
        }
        private void btn_NhapMay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSo.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số");
                return;
            }
            
            int MaDai = cbo_CapDai.SelectedIndex + 2;
            string MaSo = txt_MaSo.Text;
            if (frm_InGCNBangMay == null || frm_InGCNBangMay.IsDisposed)
            {
                frm_InGCNBangMay = new frm_InGCNMay(MaDai, MaSo, MaCLB);
            }
            else
            {
                frm_InGCNBangMay.Dispose();
                frm_InGCNBangMay = new frm_InGCNMay(MaDai, MaSo, MaCLB);
            }
            ThemFormConVaoPanel(frm_InGCNBangMay);
        }

        private void frm_XemGCN_Load(object sender, EventArgs e)
        { 
            cbo_CapDai.SelectedIndex = 0;
        }

        private void btn_InBanChuaDiem_Click(object sender, EventArgs e)
        {
            int MaDai = cbo_CapDai.SelectedIndex + 2;
            string MaSo = txt_MaSo.Text;
            if (frm_InGCNChuaDiem == null || frm_InGCNChuaDiem.IsDisposed)
            {
                frm_InGCNChuaDiem = new frm_InGCNChuaDiem(MaDai, MaCLB);
            }
            else
            {
                frm_InGCNChuaDiem.Dispose();
                frm_InGCNChuaDiem = new frm_InGCNChuaDiem(MaDai, MaCLB);
            }
            ThemFormConVaoPanel(frm_InGCNChuaDiem);
        }

        private void txt_MaSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_InLe_Click(object sender, EventArgs e)
        {
            frm_InLe = new frm_InLe(MaCLB);
            frm_InLe.ShowDialog();
        }
    }
}
