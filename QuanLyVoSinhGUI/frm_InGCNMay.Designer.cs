namespace QuanLyVoSinhGUI
{
    partial class frm_InGCNMay
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
            this.rpv_InGCNMay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // rpv_InGCNMay
            // 
            this.rpv_InGCNMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.rpv_InGCNMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_InGCNMay.Location = new System.Drawing.Point(0, 0);
            this.rpv_InGCNMay.Name = "rpv_InGCNMay";
            this.rpv_InGCNMay.ServerReport.BearerToken = null;
            this.rpv_InGCNMay.Size = new System.Drawing.Size(800, 450);
            this.rpv_InGCNMay.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frm_InGCNMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpv_InGCNMay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_InGCNMay";
            this.Text = "frm_InGCNMây";
            this.Load += new System.EventHandler(this.frm_InGCNMây_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_InGCNMay;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}