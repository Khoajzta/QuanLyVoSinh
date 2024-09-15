namespace QuanLyVoSinhGUI
{
    partial class frm_NhapDiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_NhapDiem = new Guna.UI2.WinForms.Guna2Button();
            this.cbo_CapDai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbl_nav = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgv_DanhSachVoSinh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_MaVoSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenVoSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CapDai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_MaCLB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachVoSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NhapDiem
            // 
            this.btn_NhapDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btn_NhapDiem.BorderRadius = 7;
            this.btn_NhapDiem.BorderThickness = 1;
            this.btn_NhapDiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_NhapDiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_NhapDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_NhapDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_NhapDiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(173)))));
            this.btn_NhapDiem.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_NhapDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.btn_NhapDiem.Location = new System.Drawing.Point(12, 208);
            this.btn_NhapDiem.Name = "btn_NhapDiem";
            this.btn_NhapDiem.Size = new System.Drawing.Size(199, 36);
            this.btn_NhapDiem.TabIndex = 11;
            this.btn_NhapDiem.Text = "Nhập Điểm";
            this.btn_NhapDiem.Click += new System.EventHandler(this.btn_NhapDiem_Click);
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
            this.cbo_CapDai.Location = new System.Drawing.Point(12, 153);
            this.cbo_CapDai.Name = "cbo_CapDai";
            this.cbo_CapDai.Size = new System.Drawing.Size(199, 36);
            this.cbo_CapDai.TabIndex = 10;
            this.cbo_CapDai.SelectedIndexChanged += new System.EventHandler(this.cbo_CapDai_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 124);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(63, 23);
            this.guna2HtmlLabel3.TabIndex = 9;
            this.guna2HtmlLabel3.Text = "Cấp Đai:";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.lbl_nav);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(238, 5);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1052, 38);
            this.guna2CustomGradientPanel2.TabIndex = 13;
            // 
            // lbl_nav
            // 
            this.lbl_nav.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_nav.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nav.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.lbl_nav.Location = new System.Drawing.Point(350, 2);
            this.lbl_nav.Name = "lbl_nav";
            this.lbl_nav.Size = new System.Drawing.Size(220, 30);
            this.lbl_nav.TabIndex = 1;
            this.lbl_nav.Text = "DANH SÁCH VÕ SINH";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_NhapDiem);
            this.guna2CustomGradientPanel1.Controls.Add(this.cbo_CapDai);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(5, 5);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(233, 673);
            this.guna2CustomGradientPanel1.TabIndex = 12;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(50, 57);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(101, 28);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Nhập Điểm";
            // 
            // dgv_DanhSachVoSinh
            // 
            this.dgv_DanhSachVoSinh.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_DanhSachVoSinh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DanhSachVoSinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachVoSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DanhSachVoSinh.ColumnHeadersHeight = 56;
            this.dgv_DanhSachVoSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_DanhSachVoSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaVoSinh,
            this.col_Ho,
            this.col_TenVoSinh,
            this.col_NgaySinh,
            this.col_GioiTinh,
            this.col_CapDai,
            this.col_MaCLB,
            this.col_Diem});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSachVoSinh.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DanhSachVoSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachVoSinh.GridColor = System.Drawing.Color.Black;
            this.dgv_DanhSachVoSinh.Location = new System.Drawing.Point(238, 43);
            this.dgv_DanhSachVoSinh.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachVoSinh.Name = "dgv_DanhSachVoSinh";
            this.dgv_DanhSachVoSinh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachVoSinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DanhSachVoSinh.RowHeadersVisible = false;
            this.dgv_DanhSachVoSinh.RowHeadersWidth = 51;
            this.dgv_DanhSachVoSinh.RowTemplate.Height = 46;
            this.dgv_DanhSachVoSinh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_DanhSachVoSinh.Size = new System.Drawing.Size(1052, 635);
            this.dgv_DanhSachVoSinh.TabIndex = 14;
            this.dgv_DanhSachVoSinh.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgv_DanhSachVoSinh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.dgv_DanhSachVoSinh.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DanhSachVoSinh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DanhSachVoSinh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.dgv_DanhSachVoSinh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_DanhSachVoSinh.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.dgv_DanhSachVoSinh.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgv_DanhSachVoSinh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.dgv_DanhSachVoSinh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DanhSachVoSinh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DanhSachVoSinh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DanhSachVoSinh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_DanhSachVoSinh.ThemeStyle.HeaderStyle.Height = 56;
            this.dgv_DanhSachVoSinh.ThemeStyle.ReadOnly = false;
            this.dgv_DanhSachVoSinh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.dgv_DanhSachVoSinh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DanhSachVoSinh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DanhSachVoSinh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DanhSachVoSinh.ThemeStyle.RowsStyle.Height = 46;
            this.dgv_DanhSachVoSinh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.dgv_DanhSachVoSinh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // col_MaVoSinh
            // 
            this.col_MaVoSinh.DataPropertyName = "MaVoSinh";
            this.col_MaVoSinh.FillWeight = 106.4294F;
            this.col_MaVoSinh.HeaderText = "Mã Võ Sinh";
            this.col_MaVoSinh.Name = "col_MaVoSinh";
            this.col_MaVoSinh.ReadOnly = true;
            // 
            // col_Ho
            // 
            this.col_Ho.DataPropertyName = "Ho";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.col_Ho.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_Ho.FillWeight = 123.8299F;
            this.col_Ho.HeaderText = "Họ";
            this.col_Ho.Name = "col_Ho";
            this.col_Ho.ReadOnly = true;
            // 
            // col_TenVoSinh
            // 
            this.col_TenVoSinh.DataPropertyName = "Ten";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.col_TenVoSinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_TenVoSinh.FillWeight = 60.9137F;
            this.col_TenVoSinh.HeaderText = "Tên";
            this.col_TenVoSinh.MinimumWidth = 6;
            this.col_TenVoSinh.Name = "col_TenVoSinh";
            this.col_TenVoSinh.ReadOnly = true;
            // 
            // col_NgaySinh
            // 
            this.col_NgaySinh.DataPropertyName = "NgaySinh";
            this.col_NgaySinh.FillWeight = 94.54391F;
            this.col_NgaySinh.HeaderText = "Ngày Sinh";
            this.col_NgaySinh.MinimumWidth = 6;
            this.col_NgaySinh.Name = "col_NgaySinh";
            this.col_NgaySinh.ReadOnly = true;
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.DataPropertyName = "GioiTinh";
            this.col_GioiTinh.FillWeight = 84.36321F;
            this.col_GioiTinh.HeaderText = "Giới Tính";
            this.col_GioiTinh.MinimumWidth = 6;
            this.col_GioiTinh.Name = "col_GioiTinh";
            this.col_GioiTinh.ReadOnly = true;
            // 
            // col_CapDai
            // 
            this.col_CapDai.DataPropertyName = "MaDai";
            this.col_CapDai.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.col_CapDai.FillWeight = 120.6273F;
            this.col_CapDai.HeaderText = "Cấp Đai";
            this.col_CapDai.MinimumWidth = 6;
            this.col_CapDai.Name = "col_CapDai";
            this.col_CapDai.ReadOnly = true;
            this.col_CapDai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_CapDai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_MaCLB
            // 
            this.col_MaCLB.DataPropertyName = "MaCLB";
            this.col_MaCLB.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.col_MaCLB.FillWeight = 141.6576F;
            this.col_MaCLB.HeaderText = "Câu Lạc Bộ";
            this.col_MaCLB.Name = "col_MaCLB";
            this.col_MaCLB.ReadOnly = true;
            this.col_MaCLB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_MaCLB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_Diem
            // 
            this.col_Diem.DataPropertyName = "Diem";
            this.col_Diem.FillWeight = 67.63492F;
            this.col_Diem.HeaderText = "Điểm";
            this.col_Diem.Name = "col_Diem";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 40;
            this.guna2Elipse2.TargetControl = this.dgv_DanhSachVoSinh;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 40;
            this.guna2Elipse3.TargetControl = this;
            // 
            // frm_NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 683);
            this.Controls.Add(this.dgv_DanhSachVoSinh);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_NhapDiem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "frm_NhapDiem";
            this.Load += new System.EventHandler(this.frm_NhapDiem_Load);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachVoSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_NhapDiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_CapDai;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_DanhSachVoSinh;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_nav;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaVoSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenVoSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_CapDai;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_MaCLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Diem;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
    }
}