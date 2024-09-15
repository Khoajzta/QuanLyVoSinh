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
    public partial class frm_TaiKhoan : Form
    {
        TaiKhoanDTO taikhoan;
        string MaCLB;
        HuanLuyenVienDTO hlv;
        public frm_TaiKhoan()
        {
            InitializeComponent();
        }
        public frm_TaiKhoan(TaiKhoanDTO tk, string maCLB)
        {
            this.taikhoan = tk;
            InitializeComponent();
            MaCLB = maCLB;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            LoadHuanLuyenVien();
        }

        private void LoadHuanLuyenVien()
        {
            HuanLuyenVienBUS huanLuyenVienBUS = new HuanLuyenVienBUS();
            hlv = huanLuyenVienBUS.LayThongTin(taikhoan.MaHLV);
            txt_HLV.Text = hlv.TenHLV;
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

        private void LoadThongTin()
        {
            CauLacBoBUS cauLacBoBUS = new CauLacBoBUS();
            CauLacBoDTO clb = new CauLacBoDTO();
            clb = cauLacBoBUS.LayThongTin(MaCLB);
            txt_TenTaiKhoan.Text = taikhoan.TenTaiKhoan;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_PW_Cu.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (CheckMKCu() == false)
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_PW_Moi.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_CFPW.Text))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_CFPW.Text != txt_PW_Moi.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(DoiMatKhau()>0)
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private bool CheckMKCu()
        {
            bool kq = false;
            string MKCu = Utils.MaHoa(txt_PW_Cu.Text);
            if (MKCu == taikhoan.MatKhau)
                kq = true;
            return kq;
        }
        private int DoiMatKhau()
        {
            string TenTaiKhoan = taikhoan.TenTaiKhoan;
            string MatKhauMoi = Utils.MaHoa(txt_PW_Moi.Text);
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            int kq = taiKhoanBUS.DoiMatKhau(TenTaiKhoan,MatKhauMoi);
            return kq;
        }

        private void sw_Show_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void pic_AVT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Chỉ cho phép chọn các file hình ảnh
                openFileDialog.Title = "Chọn hình ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImageFromPath(openFileDialog.FileName);
                }
            }
        }

        private void LoadImageFromPath(string imagePath)
        {
            try
            {  
                if (System.IO.File.Exists(imagePath))
                {
                    Image img = Image.FromFile(imagePath);
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

        private void btn_ThayDoiAnh_Click(object sender, EventArgs e)
        {
            if(capNhat()>0)
            {
                MessageBox.Show("Thay đổi thành công", "Thay Đổi Thông Tin");
                LoadHuanLuyenVien();
            }    
            else
            {
                MessageBox.Show("Lỗi", "Thay Đổi Thông Tin");
            }    
        }
        private byte[] ImageToByteArray(PictureBox pic)
        {
            using (MemoryStream ms = new MemoryStream())
            {             
                if (pic.Image != null)
                {
                    pic.Image.Save(ms, pic.Image.RawFormat);
                    return ms.ToArray();
                }
                else
                {
                    return null; 
                }
            }
        }
        private int capNhat()
        {
            hlv.MaHLV = taikhoan.MaHLV;
            hlv.TenHLV = txt_HLV.Text;
            hlv.SDT = string.IsNullOrWhiteSpace(txt_SDT.Text) ? "Trống" : txt_SDT.Text;

            if (pic_AVT.Image != null)
            {
                hlv.HinhAnh = ImageToByteArray(pic_AVT);
            }
            else
            {
                hlv.HinhAnh = null;
            }
            HuanLuyenVienBUS huanLuyenVienBUS = new HuanLuyenVienBUS();
            int kq = huanLuyenVienBUS.SuaHLV(hlv);
            return kq;
        }
    }
}
