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
    public partial class frm_XemThongTin : Form
    {
        string MaVoSinh;
        public frm_XemThongTin()
        {
            InitializeComponent();
        }
        public frm_XemThongTin(string maVoSinh)
        {
            InitializeComponent();
            MaVoSinh = maVoSinh;
        }
        private void frm_XemDiem_Load(object sender, EventArgs e)
        {
            UpdateControlText(this);
        }

        private void btn_XemThpngTin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_MaVoSinh.Text))
            {
                MessageBox.Show("Vui lòng nhập mã võ sinh!");
                return;
            }    
            if(KiemTraMaVoSinh(txt_MaVoSinh.Text)==0)
            {
                MessageBox.Show("Võ sinh không tồn tại");
                return;
            }    
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            lbl_16.Visible = true;
            ThongTinVoSinhDTO thongtin = new ThongTinVoSinhDTO();
            string MaVoSinh = txt_MaVoSinh.Text;
            ThongTinVoSinhBUS thongTinVoSinhBUS = new ThongTinVoSinhBUS();
            thongtin = thongTinVoSinhBUS.LayThongTin(MaVoSinh);

            lbl_HT.Text = thongtin.HoTen.ToString();
            lbl_NS.Text = thongtin.NgaySinh.ToString("dd/MM/yyyy");
            lbl_NNH.Text = thongtin.NgayNhapHoc.ToString("dd/MM/yyyy");
            lbl_CLB.Text = thongtin.TenCLB;
            lbl_DonVi.Text = thongtin.DonVi;
            lbl_HLV.Text = thongtin.TenHLV;
            lbl_CapDai.Text = thongtin.TenDai;
            lbl_DV.Text = (thongtin.DiemDaiVang.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiVang.ToString());
            lbl_DCam.Text = (thongtin.DiemDaiCam.ToString()=="0"?"Chưa có":thongtin.DiemDaiCam.ToString());
            lbl_DXanhLuc.Text = (thongtin.DiemDaiXanhLuc.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiXanhLuc.ToString());
            lbl_DXD.Text =  (thongtin.DiemDaiXanhDuong.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiXanhDuong.ToString());
            lbl_DD.Text = (thongtin.DiemDaiDo.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiDo.ToString());
            lbl_DT.Text = (thongtin.DiemDaiTim.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiTim.ToString());
            lbl_DN.Text = (thongtin.DiemDaiNau.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiNau.ToString());
            lbl_DN1.Text =(thongtin.DiemDaiNau1.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiNau1.ToString());
            if(thongtin.TrangThai == 1)
            {
                lbl_TT.Text ="Còn học";
            }    
            else
            {
                lbl_TT.Text ="Đã nghỉ";
            }    
        }
        private void UpdateControlText(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                // Check if the control is a type that has a Text property
                if (control is TextBox || control is Label || control is Button || control is CheckBox || control is RadioButton)
                {
                    // Check if the control's Text property equals "0"
                    if (control.Text == "0")
                    {
                        // Update the control's Text property to "Chưa có"
                        control.Text = "Chưa có";
                    }
                }

                // Recursively call UpdateControlText for any child controls
                if (control.HasChildren)
                {
                    UpdateControlText(control);
                }
            }
        }
        private int KiemTraMaVoSinh(string MaVoSinh)
        {
            VoSinhBUS voSinhBUS = new VoSinhBUS();
            int kq = voSinhBUS.KiemTraMaVoSinh(MaVoSinh);
            return kq;
        }
        private void txt_MaVoSinh_TextChanged(object sender, EventArgs e)
        {
            if(txt_MaVoSinh.TextLength == 10)
            {
                if (string.IsNullOrWhiteSpace(txt_MaVoSinh.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã võ sinh!");
                    return;
                }
                if (KiemTraMaVoSinh(txt_MaVoSinh.Text) == 0)
                {
                    MessageBox.Show("Võ sinh không tồn tại");
                    return;
                }
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                lbl_16.Visible = true;
                ThongTinVoSinhDTO thongtin = new ThongTinVoSinhDTO();
                string MaVoSinh = txt_MaVoSinh.Text;
                ThongTinVoSinhBUS thongTinVoSinhBUS = new ThongTinVoSinhBUS();
                thongtin = thongTinVoSinhBUS.LayThongTin(MaVoSinh);

                lbl_HT.Text = thongtin.HoTen.ToString();
                lbl_NS.Text = thongtin.NgaySinh.ToString("dd/MM/yyyy");
                lbl_NNH.Text = thongtin.NgayNhapHoc.ToString("dd/MM/yyyy");
                lbl_CLB.Text = thongtin.TenCLB;
                lbl_DonVi.Text = thongtin.DonVi;
                lbl_HLV.Text = thongtin.TenHLV;
                lbl_CapDai.Text = thongtin.TenDai;
                lbl_DV.Text = (thongtin.DiemDaiVang.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiVang.ToString());
                lbl_DCam.Text = (thongtin.DiemDaiCam.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiCam.ToString());
                lbl_DXanhLuc.Text = (thongtin.DiemDaiXanhLuc.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiXanhLuc.ToString());
                lbl_DXD.Text = (thongtin.DiemDaiXanhDuong.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiXanhDuong.ToString());
                lbl_DD.Text = (thongtin.DiemDaiDo.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiDo.ToString());
                lbl_DT.Text = (thongtin.DiemDaiTim.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiTim.ToString());
                lbl_DN.Text = (thongtin.DiemDaiNau.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiNau.ToString());
                lbl_DN1.Text = (thongtin.DiemDaiNau1.ToString() == "0" ? "Chưa có" : thongtin.DiemDaiNau1.ToString());
                if (thongtin.TrangThai == 1)
                {
                    lbl_TT.Text = "Còn học";
                }
                else
                {
                    lbl_TT.Text = "Đã nghỉ";
                }
            }    
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
    }
}
