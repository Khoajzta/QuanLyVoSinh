namespace QuanLyVoSinhGUI
{
    partial class frm_InDanhSach
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
            this.rpv_XemDanhSach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // rpv_XemDanhSach
            // 
            this.rpv_XemDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.rpv_XemDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_XemDanhSach.Location = new System.Drawing.Point(0, 0);
            this.rpv_XemDanhSach.Name = "rpv_XemDanhSach";
            this.rpv_XemDanhSach.ServerReport.BearerToken = null;
            this.rpv_XemDanhSach.Size = new System.Drawing.Size(800, 450);
            this.rpv_XemDanhSach.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frm_InDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpv_XemDanhSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_InDanhSach";
            this.Text = "frm_InDanhSach";
            this.Load += new System.EventHandler(this.frm_InDanhSach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_XemDanhSach;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}