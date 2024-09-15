using QuanLyHocSinhTHPT;
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
    public partial class frm_Login : Form
    {
        private bool isDragging = false;
        private Point clickOffset;

        TaiKhoanDTO taiKhoan = null;
        frm_main formMain;
        public frm_Login()
        {
            InitializeComponent();
            pnl_Nav.MouseDown += Panel1_MouseDown;
            pnl_Nav.MouseMove += Panel1_MouseMove;
            pnl_Nav.MouseUp += Panel1_MouseUp;
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                clickOffset = e.Location;
            }
        }
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToClient(Cursor.Position);
                this.Location = new Point(
                    this.Location.X + (newLocation.X - clickOffset.X),
                    this.Location.Y + (newLocation.Y - clickOffset.Y)
                );
            }
        }
        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void lbl_Thanh1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Login",MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_Username.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Đăng nhập");
                return;
            }
            if(LayTaiKhoan() != null)
            {
                frm_main frmMain = new frm_main(taiKhoan);
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username hoặc password không chính xác!", "Đăng nhập");
                return;
            }    
            
        }
        private TaiKhoanDTO LayTaiKhoan()
        {
            string username = txt_Username.Text;
            string password = Utils.MaHoa(txt_Password.Text);

            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            taiKhoan = taiKhoanBUS.LayTaiKhoan(username, password);
            return taiKhoan;
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar == true)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
            txt_Username.Text = Properties.Settings.Default.username;
            txt_Password.Text = Properties.Settings.Default.password;
            if(Properties.Settings.Default.username != "")
            {
                sw_LuuTaiKhoan.Checked = true;
            }    
        }

        private void sw_LuuTaiKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_Username.Text != "" && txt_Password.Text != "")
            {
                if(sw_LuuTaiKhoan.Checked == true)
                {
                    string username = txt_Username.Text;
                    string password = txt_Password.Text;
                    Properties.Settings.Default.username = username;
                    Properties.Settings.Default.password = password;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }    
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void lbl_Thanh1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
