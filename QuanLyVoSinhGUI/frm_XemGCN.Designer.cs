namespace QuanLyVoSinhGUI
{
    partial class frm_XemGCN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_ChucNang = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_ThongTinChiTiet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbo_CapDai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_MaSo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_InLe = new Guna.UI2.WinForms.Guna2Button();
            this.btn_InBanChuaDiem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_NhapTay = new Guna.UI2.WinForms.Guna2Button();
            this.btn_NhapMay = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_HienThi = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_ChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ChucNang
            // 
            this.pnl_ChucNang.Controls.Add(this.lbl_ThongTinChiTiet);
            this.pnl_ChucNang.Controls.Add(this.cbo_CapDai);
            this.pnl_ChucNang.Controls.Add(this.guna2HtmlLabel1);
            this.pnl_ChucNang.Controls.Add(this.guna2HtmlLabel3);
            this.pnl_ChucNang.Controls.Add(this.txt_MaSo);
            this.pnl_ChucNang.Controls.Add(this.btn_InLe);
            this.pnl_ChucNang.Controls.Add(this.btn_InBanChuaDiem);
            this.pnl_ChucNang.Controls.Add(this.btn_NhapTay);
            this.pnl_ChucNang.Controls.Add(this.btn_NhapMay);
            this.pnl_ChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_ChucNang.Location = new System.Drawing.Point(0, 0);
            this.pnl_ChucNang.Name = "pnl_ChucNang";
            this.pnl_ChucNang.Size = new System.Drawing.Size(228, 642);
            this.pnl_ChucNang.TabIndex = 0;
            // 
            // lbl_ThongTinChiTiet
            // 
            this.lbl_ThongTinChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ThongTinChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ThongTinChiTiet.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongTinChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.lbl_ThongTinChiTiet.Location = new System.Drawing.Point(10, 35);
            this.lbl_ThongTinChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_ThongTinChiTiet.Name = "lbl_ThongTinChiTiet";
            this.lbl_ThongTinChiTiet.Size = new System.Drawing.Size(208, 28);
            this.lbl_ThongTinChiTiet.TabIndex = 55;
            this.lbl_ThongTinChiTiet.Text = "IN GIẤY CHỨNG NHẬN";
            // 
            // cbo_CapDai
            // 
            this.cbo_CapDai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.cbo_CapDai.BorderColor = System.Drawing.Color.Black;
            this.cbo_CapDai.BorderRadius = 7;
            this.cbo_CapDai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_CapDai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_CapDai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.cbo_CapDai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.cbo_CapDai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.cbo_CapDai.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.cbo_CapDai.ForeColor = System.Drawing.Color.Black;
            this.cbo_CapDai.ItemHeight = 30;
            this.cbo_CapDai.Items.AddRange(new object[] {
            "Trắng - Vàng",
            "Vàng - Cam",
            "Cam - Xanh Lá",
            "Xanh Lá - Xanh Dương",
            "Xanh Dương - Đỏ",
            "Đỏ - Tím",
            "Tím - Nâu",
            "Nâu - Nâu 1 "});
            this.cbo_CapDai.Location = new System.Drawing.Point(12, 119);
            this.cbo_CapDai.Name = "cbo_CapDai";
            this.cbo_CapDai.Size = new System.Drawing.Size(200, 36);
            this.cbo_CapDai.TabIndex = 54;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 164);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(53, 23);
            this.guna2HtmlLabel1.TabIndex = 53;
            this.guna2HtmlLabel1.Text = "Mã Số:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(13, 90);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(63, 23);
            this.guna2HtmlLabel3.TabIndex = 53;
            this.guna2HtmlLabel3.Text = "Cấp Đai:";
            // 
            // txt_MaSo
            // 
            this.txt_MaSo.Animated = true;
            this.txt_MaSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.txt_MaSo.BorderColor = System.Drawing.Color.Black;
            this.txt_MaSo.BorderRadius = 7;
            this.txt_MaSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaSo.DefaultText = "";
            this.txt_MaSo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaSo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaSo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaSo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaSo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.txt_MaSo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.txt_MaSo.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txt_MaSo.ForeColor = System.Drawing.Color.Black;
            this.txt_MaSo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.txt_MaSo.Location = new System.Drawing.Point(13, 197);
            this.txt_MaSo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_MaSo.MaxLength = 4;
            this.txt_MaSo.Name = "txt_MaSo";
            this.txt_MaSo.PasswordChar = '\0';
            this.txt_MaSo.PlaceholderText = "";
            this.txt_MaSo.SelectedText = "";
            this.txt_MaSo.Size = new System.Drawing.Size(200, 36);
            this.txt_MaSo.TabIndex = 39;
            this.txt_MaSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaSo_KeyPress);
            // 
            // btn_InLe
            // 
            this.btn_InLe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_InLe.BorderRadius = 7;
            this.btn_InLe.BorderThickness = 1;
            this.btn_InLe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_InLe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_InLe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_InLe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_InLe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_InLe.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_InLe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.btn_InLe.Image = global::QuanLyVoSinhGUI.Properties.Resources.mayinthe;
            this.btn_InLe.ImageOffset = new System.Drawing.Point(-18, 0);
            this.btn_InLe.Location = new System.Drawing.Point(12, 478);
            this.btn_InLe.Name = "btn_InLe";
            this.btn_InLe.Size = new System.Drawing.Size(200, 45);
            this.btn_InLe.TabIndex = 12;
            this.btn_InLe.Text = "In Lẻ GCN";
            this.btn_InLe.TextOffset = new System.Drawing.Point(-13, 0);
            this.btn_InLe.Click += new System.EventHandler(this.btn_InLe_Click);
            // 
            // btn_InBanChuaDiem
            // 
            this.btn_InBanChuaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_InBanChuaDiem.BorderRadius = 7;
            this.btn_InBanChuaDiem.BorderThickness = 1;
            this.btn_InBanChuaDiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_InBanChuaDiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_InBanChuaDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_InBanChuaDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_InBanChuaDiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_InBanChuaDiem.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_InBanChuaDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.btn_InBanChuaDiem.Image = global::QuanLyVoSinhGUI.Properties.Resources.mayinthe;
            this.btn_InBanChuaDiem.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btn_InBanChuaDiem.Location = new System.Drawing.Point(13, 406);
            this.btn_InBanChuaDiem.Name = "btn_InBanChuaDiem";
            this.btn_InBanChuaDiem.Size = new System.Drawing.Size(200, 45);
            this.btn_InBanChuaDiem.TabIndex = 12;
            this.btn_InBanChuaDiem.Text = "In Bản Chưa Điểm";
            this.btn_InBanChuaDiem.TextOffset = new System.Drawing.Point(1, 0);
            this.btn_InBanChuaDiem.Click += new System.EventHandler(this.btn_InBanChuaDiem_Click);
            // 
            // btn_NhapTay
            // 
            this.btn_NhapTay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_NhapTay.BorderRadius = 7;
            this.btn_NhapTay.BorderThickness = 1;
            this.btn_NhapTay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_NhapTay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_NhapTay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_NhapTay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_NhapTay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_NhapTay.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_NhapTay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.btn_NhapTay.Image = global::QuanLyVoSinhGUI.Properties.Resources.mayinthe;
            this.btn_NhapTay.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btn_NhapTay.Location = new System.Drawing.Point(13, 334);
            this.btn_NhapTay.Name = "btn_NhapTay";
            this.btn_NhapTay.Size = new System.Drawing.Size(200, 45);
            this.btn_NhapTay.TabIndex = 12;
            this.btn_NhapTay.Text = "In Bản Ghi Tay";
            this.btn_NhapTay.TextOffset = new System.Drawing.Point(-5, 0);
            this.btn_NhapTay.Click += new System.EventHandler(this.btn_NhapTay_Click);
            // 
            // btn_NhapMay
            // 
            this.btn_NhapMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_NhapMay.BorderRadius = 7;
            this.btn_NhapMay.BorderThickness = 1;
            this.btn_NhapMay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_NhapMay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_NhapMay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_NhapMay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_NhapMay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_NhapMay.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_NhapMay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.btn_NhapMay.Image = global::QuanLyVoSinhGUI.Properties.Resources.mayinthe;
            this.btn_NhapMay.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btn_NhapMay.Location = new System.Drawing.Point(13, 262);
            this.btn_NhapMay.Name = "btn_NhapMay";
            this.btn_NhapMay.Size = new System.Drawing.Size(200, 45);
            this.btn_NhapMay.TabIndex = 12;
            this.btn_NhapMay.Text = "In Bản Nhập Máy";
            this.btn_NhapMay.Click += new System.EventHandler(this.btn_NhapMay_Click);
            // 
            // pnl_HienThi
            // 
            this.pnl_HienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_HienThi.Location = new System.Drawing.Point(228, 0);
            this.pnl_HienThi.Name = "pnl_HienThi";
            this.pnl_HienThi.Size = new System.Drawing.Size(842, 642);
            this.pnl_HienThi.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frm_XemGCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1070, 642);
            this.Controls.Add(this.pnl_HienThi);
            this.Controls.Add(this.pnl_ChucNang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_XemGCN";
            this.Text = "frm_XemGCN";
            this.Load += new System.EventHandler(this.frm_XemGCN_Load);
            this.pnl_ChucNang.ResumeLayout(false);
            this.pnl_ChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_ChucNang;
        private Guna.UI2.WinForms.Guna2Panel pnl_HienThi;
        private Guna.UI2.WinForms.Guna2Button btn_NhapTay;
        private Guna.UI2.WinForms.Guna2Button btn_NhapMay;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaSo;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_CapDai;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_ThongTinChiTiet;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_InBanChuaDiem;
        private Guna.UI2.WinForms.Guna2Button btn_InLe;
    }
}