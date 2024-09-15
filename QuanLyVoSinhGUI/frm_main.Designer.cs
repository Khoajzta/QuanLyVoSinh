namespace QuanLyVoSinhGUI
{
    partial class frm_main
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
            Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnl_Nav = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cbo_CLB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_HienThi = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tr = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_ChucNang = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbl_CauLacBo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Bu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Thu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_DangXuat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Admin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_InDanhSach = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_CheckThongTin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_CapNhatDai = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_InGCN = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_NhapDiem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_DSVS_Nghi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_DanhSach = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_TaiKhoan = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_Nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.pnl_ChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockForm = true;
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this.pnl_Nav;
            guna2DragControl1.TransparentWhileDrag = false;
            // 
            // pnl_Nav
            // 
            this.pnl_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.pnl_Nav.Controls.Add(this.guna2CirclePictureBox3);
            this.pnl_Nav.Controls.Add(this.guna2CirclePictureBox2);
            this.pnl_Nav.Controls.Add(this.guna2CirclePictureBox1);
            this.tr.SetDecoration(this.pnl_Nav, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnl_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Nav.Location = new System.Drawing.Point(0, 0);
            this.pnl_Nav.Name = "pnl_Nav";
            this.pnl_Nav.Size = new System.Drawing.Size(1521, 30);
            this.pnl_Nav.TabIndex = 0;
            this.pnl_Nav.DoubleClick += new System.EventHandler(this.pnl_Nav_DoubleClick);
            this.pnl_Nav.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Nav_MouseDoubleClick);
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tr.SetDecoration(this.guna2CirclePictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox3.Image = global::QuanLyVoSinhGUI.Properties.Resources.icon_vang_removebg_preview;
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(1418, 5);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(22, 22);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 1;
            this.guna2CirclePictureBox3.TabStop = false;
            this.guna2CirclePictureBox3.Click += new System.EventHandler(this.guna2CirclePictureBox3_Click_1);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tr.SetDecoration(this.guna2CirclePictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(1450, 5);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(22, 22);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 2;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click_1);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tr.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox1.Image = global::QuanLyVoSinhGUI.Properties.Resources.icon_do_removebg_preview1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1482, 5);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(22, 22);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click_1);
            // 
            // cbo_CLB
            // 
            this.cbo_CLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_CLB.AutoRoundedCorners = true;
            this.cbo_CLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.cbo_CLB.BorderColor = System.Drawing.Color.Black;
            this.cbo_CLB.BorderRadius = 17;
            this.cbo_CLB.BorderThickness = 2;
            this.tr.SetDecoration(this.cbo_CLB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbo_CLB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_CLB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_CLB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.cbo_CLB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.cbo_CLB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.cbo_CLB.Font = new System.Drawing.Font("Segoe UI Variable Display", 12.75F, System.Drawing.FontStyle.Bold);
            this.cbo_CLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.cbo_CLB.ItemHeight = 30;
            this.cbo_CLB.Location = new System.Drawing.Point(3, 36);
            this.cbo_CLB.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_CLB.Name = "cbo_CLB";
            this.cbo_CLB.Size = new System.Drawing.Size(277, 36);
            this.cbo_CLB.TabIndex = 47;
            this.cbo_CLB.SelectedIndexChanged += new System.EventHandler(this.cbo_CLB_SelectedIndexChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 40;
            this.guna2Elipse2.TargetControl = this.pnl_HienThi;
            // 
            // pnl_HienThi
            // 
            this.pnl_HienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.tr.SetDecoration(this.pnl_HienThi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnl_HienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_HienThi.Location = new System.Drawing.Point(0, 0);
            this.pnl_HienThi.Name = "pnl_HienThi";
            this.pnl_HienThi.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_HienThi.Size = new System.Drawing.Size(1229, 873);
            this.pnl_HienThi.TabIndex = 6;
            this.pnl_HienThi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_HienThi_Paint);
            // 
            // tr
            // 
            this.tr.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.tr.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tr.DefaultAnimation = animation1;
            this.tr.MaxAnimationTime = 50000;
            this.tr.TimeStep = 0.035F;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.pnl_ChucNang);
            this.tr.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 30);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(1521, 888);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.guna2Panel2.Controls.Add(this.pnl_HienThi);
            this.tr.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(282, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1229, 873);
            this.guna2Panel2.TabIndex = 3;
            // 
            // pnl_ChucNang
            // 
            this.pnl_ChucNang.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ChucNang.Controls.Add(this.lbl_CauLacBo);
            this.pnl_ChucNang.Controls.Add(this.cbo_CLB);
            this.pnl_ChucNang.Controls.Add(this.btn_Bu);
            this.pnl_ChucNang.Controls.Add(this.btn_Thu);
            this.pnl_ChucNang.Controls.Add(this.guna2Separator1);
            this.pnl_ChucNang.Controls.Add(this.btn_DangXuat);
            this.pnl_ChucNang.Controls.Add(this.btn_Admin);
            this.pnl_ChucNang.Controls.Add(this.btn_InDanhSach);
            this.pnl_ChucNang.Controls.Add(this.btn_CheckThongTin);
            this.pnl_ChucNang.Controls.Add(this.btn_CapNhatDai);
            this.pnl_ChucNang.Controls.Add(this.btn_InGCN);
            this.pnl_ChucNang.Controls.Add(this.btn_NhapDiem);
            this.pnl_ChucNang.Controls.Add(this.btn_DSVS_Nghi);
            this.pnl_ChucNang.Controls.Add(this.btn_DanhSach);
            this.pnl_ChucNang.Controls.Add(this.btn_TaiKhoan);
            this.tr.SetDecoration(this.pnl_ChucNang, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnl_ChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_ChucNang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.pnl_ChucNang.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.pnl_ChucNang.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.pnl_ChucNang.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.pnl_ChucNang.Location = new System.Drawing.Point(0, 5);
            this.pnl_ChucNang.Name = "pnl_ChucNang";
            this.pnl_ChucNang.Size = new System.Drawing.Size(282, 873);
            this.pnl_ChucNang.TabIndex = 2;
            this.pnl_ChucNang.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_ChucNang_Paint);
            // 
            // lbl_CauLacBo
            // 
            this.lbl_CauLacBo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CauLacBo.BackColor = System.Drawing.Color.Transparent;
            this.tr.SetDecoration(this.lbl_CauLacBo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbl_CauLacBo.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CauLacBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.lbl_CauLacBo.Location = new System.Drawing.Point(10, -2);
            this.lbl_CauLacBo.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_CauLacBo.Name = "lbl_CauLacBo";
            this.lbl_CauLacBo.Size = new System.Drawing.Size(115, 30);
            this.lbl_CauLacBo.TabIndex = 46;
            this.lbl_CauLacBo.Text = "Câu Lạc Bộ:";
            // 
            // btn_Bu
            // 
            this.tr.SetDecoration(this.btn_Bu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Bu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Bu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Bu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Bu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Bu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_Bu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Bu.ForeColor = System.Drawing.Color.White;
            this.btn_Bu.Image = global::QuanLyVoSinhGUI.Properties.Resources.muiten_khong_chan_pahi_removebg_preview__1_;
            this.btn_Bu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Bu.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btn_Bu.Location = new System.Drawing.Point(36, 610);
            this.btn_Bu.Name = "btn_Bu";
            this.btn_Bu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Bu.Size = new System.Drawing.Size(44, 42);
            this.btn_Bu.TabIndex = 20;
            this.btn_Bu.Visible = false;
            this.btn_Bu.Click += new System.EventHandler(this.btn_Bu_Click_1);
            // 
            // btn_Thu
            // 
            this.tr.SetDecoration(this.btn_Thu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Thu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Thu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_Thu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Thu.ForeColor = System.Drawing.Color.White;
            this.btn_Thu.Image = global::QuanLyVoSinhGUI.Properties.Resources.muiten_khong_chan_removebg_preview;
            this.btn_Thu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Thu.ImageOffset = new System.Drawing.Point(-7, 0);
            this.btn_Thu.Location = new System.Drawing.Point(259, 610);
            this.btn_Thu.Name = "btn_Thu";
            this.btn_Thu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Thu.Size = new System.Drawing.Size(44, 42);
            this.btn_Thu.TabIndex = 19;
            this.btn_Thu.Click += new System.EventHandler(this.btn_Thu_Click);
            // 
            // guna2Separator1
            // 
            this.tr.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(15, 626);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(249, 10);
            this.guna2Separator1.TabIndex = 17;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DangXuat.Animated = true;
            this.btn_DangXuat.AutoRoundedCorners = true;
            this.btn_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btn_DangXuat.BorderRadius = 33;
            this.tr.SetDecoration(this.btn_DangXuat, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_DangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangXuat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DangXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DangXuat.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DangXuat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DangXuat.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_DangXuat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_DangXuat.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DangXuat.Image = global::QuanLyVoSinhGUI.Properties.Resources.dangxuat;
            this.btn_DangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_DangXuat.ImageOffset = new System.Drawing.Point(-6, 0);
            this.btn_DangXuat.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_DangXuat.Location = new System.Drawing.Point(2, 800);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(392, 69);
            this.btn_DangXuat.TabIndex = 9;
            this.btn_DangXuat.Text = "Đăng Xuất";
            this.btn_DangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_DangXuat.TextOffset = new System.Drawing.Point(6, 0);
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Admin.Animated = true;
            this.btn_Admin.AutoRoundedCorners = true;
            this.btn_Admin.BackColor = System.Drawing.Color.Transparent;
            this.btn_Admin.BorderRadius = 33;
            this.btn_Admin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tr.SetDecoration(this.btn_Admin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Admin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Admin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Admin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Admin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_Admin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_Admin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_Admin.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_Admin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_Admin.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_Admin.Image = global::QuanLyVoSinhGUI.Properties.Resources.admin;
            this.btn_Admin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Admin.ImageOffset = new System.Drawing.Point(2, 0);
            this.btn_Admin.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Admin.Location = new System.Drawing.Point(2, 650);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(392, 69);
            this.btn_Admin.TabIndex = 10;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Admin.TextOffset = new System.Drawing.Point(6, 0);
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_InDanhSach
            // 
            this.btn_InDanhSach.Animated = true;
            this.btn_InDanhSach.AutoRoundedCorners = true;
            this.btn_InDanhSach.BackColor = System.Drawing.Color.Transparent;
            this.btn_InDanhSach.BorderRadius = 33;
            this.btn_InDanhSach.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tr.SetDecoration(this.btn_InDanhSach, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_InDanhSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_InDanhSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_InDanhSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_InDanhSach.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_InDanhSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_InDanhSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_InDanhSach.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_InDanhSach.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_InDanhSach.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.btn_InDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_InDanhSach.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_InDanhSach.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_InDanhSach.Image = global::QuanLyVoSinhGUI.Properties.Resources.mayinthe;
            this.btn_InDanhSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_InDanhSach.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_InDanhSach.Location = new System.Drawing.Point(0, 455);
            this.btn_InDanhSach.Name = "btn_InDanhSach";
            this.btn_InDanhSach.Size = new System.Drawing.Size(392, 69);
            this.btn_InDanhSach.TabIndex = 10;
            this.btn_InDanhSach.Text = "In Danh Sách";
            this.btn_InDanhSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_InDanhSach.TextOffset = new System.Drawing.Point(6, 0);
            this.btn_InDanhSach.Click += new System.EventHandler(this.btn_InDanhSach_Click);
            // 
            // btn_CheckThongTin
            // 
            this.btn_CheckThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CheckThongTin.Animated = true;
            this.btn_CheckThongTin.AutoRoundedCorners = true;
            this.btn_CheckThongTin.BackColor = System.Drawing.Color.Transparent;
            this.btn_CheckThongTin.BorderRadius = 33;
            this.btn_CheckThongTin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tr.SetDecoration(this.btn_CheckThongTin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_CheckThongTin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CheckThongTin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CheckThongTin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CheckThongTin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CheckThongTin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CheckThongTin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_CheckThongTin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_CheckThongTin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_CheckThongTin.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.btn_CheckThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_CheckThongTin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_CheckThongTin.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_CheckThongTin.Image = global::QuanLyVoSinhGUI.Properties.Resources.Circle_icons_check_svg;
            this.btn_CheckThongTin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CheckThongTin.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_CheckThongTin.Location = new System.Drawing.Point(2, 725);
            this.btn_CheckThongTin.Name = "btn_CheckThongTin";
            this.btn_CheckThongTin.Size = new System.Drawing.Size(392, 69);
            this.btn_CheckThongTin.TabIndex = 11;
            this.btn_CheckThongTin.Text = "Check Thông Tin";
            this.btn_CheckThongTin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CheckThongTin.TextOffset = new System.Drawing.Point(6, 0);
            this.btn_CheckThongTin.Click += new System.EventHandler(this.btn_CheckThongTin_Click);
            // 
            // btn_CapNhatDai
            // 
            this.btn_CapNhatDai.Animated = true;
            this.btn_CapNhatDai.AutoRoundedCorners = true;
            this.btn_CapNhatDai.BackColor = System.Drawing.Color.Transparent;
            this.btn_CapNhatDai.BorderRadius = 33;
            this.btn_CapNhatDai.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tr.SetDecoration(this.btn_CapNhatDai, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_CapNhatDai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhatDai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhatDai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CapNhatDai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CapNhatDai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CapNhatDai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_CapNhatDai.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_CapNhatDai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_CapNhatDai.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhatDai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_CapNhatDai.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_CapNhatDai.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_CapNhatDai.Image = global::QuanLyVoSinhGUI.Properties.Resources.update;
            this.btn_CapNhatDai.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CapNhatDai.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_CapNhatDai.Location = new System.Drawing.Point(0, 525);
            this.btn_CapNhatDai.Name = "btn_CapNhatDai";
            this.btn_CapNhatDai.Size = new System.Drawing.Size(392, 69);
            this.btn_CapNhatDai.TabIndex = 11;
            this.btn_CapNhatDai.Text = "Cập Nhật Đai";
            this.btn_CapNhatDai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CapNhatDai.TextOffset = new System.Drawing.Point(6, 0);
            this.btn_CapNhatDai.Click += new System.EventHandler(this.btn_CapNhatDai_Click);
            // 
            // btn_InGCN
            // 
            this.btn_InGCN.Animated = true;
            this.btn_InGCN.AutoRoundedCorners = true;
            this.btn_InGCN.BackColor = System.Drawing.Color.Transparent;
            this.btn_InGCN.BorderRadius = 33;
            this.btn_InGCN.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tr.SetDecoration(this.btn_InGCN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_InGCN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_InGCN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_InGCN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_InGCN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_InGCN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_InGCN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_InGCN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_InGCN.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            this.btn_InGCN.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.btn_InGCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_InGCN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_InGCN.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_InGCN.Image = global::QuanLyVoSinhGUI.Properties.Resources.mayinthe;
            this.btn_InGCN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_InGCN.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_InGCN.Location = new System.Drawing.Point(0, 385);
            this.btn_InGCN.Name = "btn_InGCN";
            this.btn_InGCN.Size = new System.Drawing.Size(392, 69);
            this.btn_InGCN.TabIndex = 12;
            this.btn_InGCN.Text = "In Giấy Chứng Nhận";
            this.btn_InGCN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_InGCN.TextOffset = new System.Drawing.Point(6, 0);
            this.btn_InGCN.Click += new System.EventHandler(this.btn_InGCN_Click);
            // 
            // btn_NhapDiem
            // 
            this.btn_NhapDiem.Animated = true;
            this.btn_NhapDiem.AutoRoundedCorners = true;
            this.btn_NhapDiem.BackColor = System.Drawing.Color.Transparent;
            this.btn_NhapDiem.BorderRadius = 33;
            this.btn_NhapDiem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tr.SetDecoration(this.btn_NhapDiem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_NhapDiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_NhapDiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_NhapDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_NhapDiem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_NhapDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_NhapDiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_NhapDiem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_NhapDiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            this.btn_NhapDiem.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.btn_NhapDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_NhapDiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_NhapDiem.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_NhapDiem.Image = global::QuanLyVoSinhGUI.Properties.Resources.diem;
            this.btn_NhapDiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_NhapDiem.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_NhapDiem.Location = new System.Drawing.Point(0, 315);
            this.btn_NhapDiem.Name = "btn_NhapDiem";
            this.btn_NhapDiem.Size = new System.Drawing.Size(392, 69);
            this.btn_NhapDiem.TabIndex = 13;
            this.btn_NhapDiem.Text = "Nhập Điểm";
            this.btn_NhapDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_NhapDiem.TextOffset = new System.Drawing.Point(6, 0);
            this.btn_NhapDiem.Click += new System.EventHandler(this.btn_NhapDiem_Click);
            // 
            // btn_DSVS_Nghi
            // 
            this.btn_DSVS_Nghi.Animated = true;
            this.btn_DSVS_Nghi.AutoRoundedCorners = true;
            this.btn_DSVS_Nghi.BackColor = System.Drawing.Color.Transparent;
            this.btn_DSVS_Nghi.BorderRadius = 33;
            this.btn_DSVS_Nghi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tr.SetDecoration(this.btn_DSVS_Nghi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_DSVS_Nghi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DSVS_Nghi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DSVS_Nghi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DSVS_Nghi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DSVS_Nghi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DSVS_Nghi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DSVS_Nghi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DSVS_Nghi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DSVS_Nghi.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DSVS_Nghi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_DSVS_Nghi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_DSVS_Nghi.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DSVS_Nghi.Image = global::QuanLyVoSinhGUI.Properties.Resources.icondanhsach_removebg_preview;
            this.btn_DSVS_Nghi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_DSVS_Nghi.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_DSVS_Nghi.Location = new System.Drawing.Point(0, 245);
            this.btn_DSVS_Nghi.Name = "btn_DSVS_Nghi";
            this.btn_DSVS_Nghi.Size = new System.Drawing.Size(392, 69);
            this.btn_DSVS_Nghi.TabIndex = 14;
            this.btn_DSVS_Nghi.Text = "Danh Sách Võ Sinh Nghỉ";
            this.btn_DSVS_Nghi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_DSVS_Nghi.TextOffset = new System.Drawing.Point(6, 0);
            this.btn_DSVS_Nghi.Click += new System.EventHandler(this.btn_DSVS_Nghi_Click);
            // 
            // btn_DanhSach
            // 
            this.btn_DanhSach.Animated = true;
            this.btn_DanhSach.AutoRoundedCorners = true;
            this.btn_DanhSach.BackColor = System.Drawing.Color.Transparent;
            this.btn_DanhSach.BorderRadius = 33;
            this.btn_DanhSach.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tr.SetDecoration(this.btn_DanhSach, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_DanhSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DanhSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DanhSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DanhSach.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DanhSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DanhSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DanhSach.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DanhSach.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DanhSach.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_DanhSach.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_DanhSach.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_DanhSach.Image = global::QuanLyVoSinhGUI.Properties.Resources.icondanhsach_removebg_preview;
            this.btn_DanhSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_DanhSach.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_DanhSach.Location = new System.Drawing.Point(0, 175);
            this.btn_DanhSach.Name = "btn_DanhSach";
            this.btn_DanhSach.Size = new System.Drawing.Size(392, 69);
            this.btn_DanhSach.TabIndex = 15;
            this.btn_DanhSach.Text = "Danh Sách Võ Sinh";
            this.btn_DanhSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_DanhSach.TextOffset = new System.Drawing.Point(6, 0);
            this.btn_DanhSach.Click += new System.EventHandler(this.btn_DanhSach_Click);
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.Animated = true;
            this.btn_TaiKhoan.AutoRoundedCorners = true;
            this.btn_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btn_TaiKhoan.BorderRadius = 33;
            this.btn_TaiKhoan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tr.SetDecoration(this.btn_TaiKhoan, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_TaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TaiKhoan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TaiKhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_TaiKhoan.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_TaiKhoan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_TaiKhoan.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_TaiKhoan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_TaiKhoan.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.btn_TaiKhoan.Image = global::QuanLyVoSinhGUI.Properties.Resources.icon_User;
            this.btn_TaiKhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TaiKhoan.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_TaiKhoan.Location = new System.Drawing.Point(0, 104);
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.Size = new System.Drawing.Size(392, 69);
            this.btn_TaiKhoan.TabIndex = 16;
            this.btn_TaiKhoan.Text = "Thông Tin Tài Khoản";
            this.btn_TaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TaiKhoan.TextOffset = new System.Drawing.Point(6, 0);
            this.btn_TaiKhoan.Click += new System.EventHandler(this.btn_TaiKhoan_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1521, 918);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnl_Nav);
            this.tr.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pnl_Nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.pnl_ChucNang.ResumeLayout(false);
            this.pnl_ChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnl_Nav;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Transition tr;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_CLB;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnl_ChucNang;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Bu;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Thu;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_DangXuat;
        private Guna.UI2.WinForms.Guna2GradientButton btn_InDanhSach;
        private Guna.UI2.WinForms.Guna2GradientButton btn_CapNhatDai;
        private Guna.UI2.WinForms.Guna2GradientButton btn_InGCN;
        private Guna.UI2.WinForms.Guna2GradientButton btn_NhapDiem;
        private Guna.UI2.WinForms.Guna2GradientButton btn_DSVS_Nghi;
        private Guna.UI2.WinForms.Guna2GradientButton btn_DanhSach;
        private Guna.UI2.WinForms.Guna2GradientButton btn_TaiKhoan;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Admin;
        private Guna.UI2.WinForms.Guna2GradientButton btn_CheckThongTin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_CauLacBo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2GradientPanel pnl_HienThi;
    }
}