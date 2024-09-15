namespace QuanLyVoSinhGUI
{
    partial class frm_InLe
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
            this.pnl_nav = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.rpv_InGCNLe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbo_CapDai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_InLe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_MaSo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaVoSinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_nav
            // 
            this.pnl_nav.Controls.Add(this.guna2CirclePictureBox1);
            this.pnl_nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_nav.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.pnl_nav.Location = new System.Drawing.Point(0, 0);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(1250, 27);
            this.pnl_nav.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.guna2CirclePictureBox1.Image = global::QuanLyVoSinhGUI.Properties.Resources.icon_do_removebg_preview1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1221, 4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(22, 22);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // rpv_InGCNLe
            // 
            this.rpv_InGCNLe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.rpv_InGCNLe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_InGCNLe.Location = new System.Drawing.Point(241, 27);
            this.rpv_InGCNLe.Name = "rpv_InGCNLe";
            this.rpv_InGCNLe.ServerReport.BearerToken = null;
            this.rpv_InGCNLe.Size = new System.Drawing.Size(1009, 743);
            this.rpv_InGCNLe.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.guna2Panel2.Controls.Add(this.cbo_CapDai);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Controls.Add(this.btn_InLe);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.txt_MaSo);
            this.guna2Panel2.Controls.Add(this.txt_MaVoSinh);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 27);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(241, 743);
            this.guna2Panel2.TabIndex = 3;
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
            this.cbo_CapDai.Location = new System.Drawing.Point(14, 154);
            this.cbo_CapDai.Name = "cbo_CapDai";
            this.cbo_CapDai.Size = new System.Drawing.Size(200, 36);
            this.cbo_CapDai.TabIndex = 2;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(15, 125);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(63, 23);
            this.guna2HtmlLabel3.TabIndex = 57;
            this.guna2HtmlLabel3.Text = "Cấp Đai:";
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
            this.btn_InLe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_InLe.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_InLe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_InLe.Image = global::QuanLyVoSinhGUI.Properties.Resources.mayinthe;
            this.btn_InLe.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btn_InLe.Location = new System.Drawing.Point(14, 272);
            this.btn_InLe.Name = "btn_InLe";
            this.btn_InLe.Size = new System.Drawing.Size(200, 45);
            this.btn_InLe.TabIndex = 56;
            this.btn_InLe.Text = "In";
            this.btn_InLe.Click += new System.EventHandler(this.btn_InLe_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 199);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(53, 23);
            this.guna2HtmlLabel2.TabIndex = 55;
            this.guna2HtmlLabel2.Text = "Mã Số:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 56);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(89, 23);
            this.guna2HtmlLabel1.TabIndex = 55;
            this.guna2HtmlLabel1.Text = "Mã Võ Sinh:";
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
            this.txt_MaSo.Location = new System.Drawing.Point(15, 226);
            this.txt_MaSo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_MaSo.MaxLength = 4;
            this.txt_MaSo.Name = "txt_MaSo";
            this.txt_MaSo.PasswordChar = '\0';
            this.txt_MaSo.PlaceholderText = "";
            this.txt_MaSo.SelectedText = "";
            this.txt_MaSo.Size = new System.Drawing.Size(200, 36);
            this.txt_MaSo.TabIndex = 3;
            this.txt_MaSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaSo_KeyPress);
            // 
            // txt_MaVoSinh
            // 
            this.txt_MaVoSinh.Animated = true;
            this.txt_MaVoSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.txt_MaVoSinh.BorderColor = System.Drawing.Color.Black;
            this.txt_MaVoSinh.BorderRadius = 7;
            this.txt_MaVoSinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaVoSinh.DefaultText = "";
            this.txt_MaVoSinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaVoSinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaVoSinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaVoSinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaVoSinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.txt_MaVoSinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.txt_MaVoSinh.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txt_MaVoSinh.ForeColor = System.Drawing.Color.Black;
            this.txt_MaVoSinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.txt_MaVoSinh.Location = new System.Drawing.Point(14, 83);
            this.txt_MaVoSinh.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_MaVoSinh.MaxLength = 10;
            this.txt_MaVoSinh.Name = "txt_MaVoSinh";
            this.txt_MaVoSinh.PasswordChar = '\0';
            this.txt_MaVoSinh.PlaceholderText = "";
            this.txt_MaVoSinh.SelectedText = "";
            this.txt_MaVoSinh.Size = new System.Drawing.Size(200, 36);
            this.txt_MaVoSinh.TabIndex = 1;
            this.txt_MaVoSinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaVoSinh_KeyPress);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnl_nav;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frm_InLe
            // 
            this.AcceptButton = this.btn_InLe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1250, 770);
            this.Controls.Add(this.rpv_InGCNLe);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.pnl_nav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_InLe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_InLe";
            this.Load += new System.EventHandler(this.frm_InLe_Load);
            this.pnl_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_nav;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_InGCNLe;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_CapDai;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btn_InLe;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaSo;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaVoSinh;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}