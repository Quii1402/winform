namespace QuanLyDiemSinhVienK19._1
{
    partial class MDIMainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MDIKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MDISinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.MDITimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.MDIThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MDIKhoa,
            this.MDISinhvien,
            this.MDITimkiem,
            this.MDIThoat});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1040, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MDIKhoa
            // 
            this.MDIKhoa.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MDIKhoa.Name = "MDIKhoa";
            this.MDIKhoa.Size = new System.Drawing.Size(104, 20);
            this.MDIKhoa.Text = "Danh Mục Khoa";
            this.MDIKhoa.Click += new System.EventHandler(this.MDIKhoa_Click);
            // 
            // MDISinhvien
            // 
            this.MDISinhvien.Name = "MDISinhvien";
            this.MDISinhvien.Size = new System.Drawing.Size(182, 20);
            this.MDISinhvien.Text = "Danh Mục Thông Tin Sinh Viên";
            this.MDISinhvien.Click += new System.EventHandler(this.MDISinhvien_Click);
            // 
            // MDITimkiem
            // 
            this.MDITimkiem.Name = "MDITimkiem";
            this.MDITimkiem.Size = new System.Drawing.Size(68, 20);
            this.MDITimkiem.Text = "Tìm kiếm";
            this.MDITimkiem.Click += new System.EventHandler(this.MDITimkiem_Click);
            // 
            // MDIThoat
            // 
            this.MDIThoat.Name = "MDIThoat";
            this.MDIThoat.Size = new System.Drawing.Size(49, 20);
            this.MDIThoat.Text = "Thoát";
            this.MDIThoat.Click += new System.EventHandler(this.MDIThoat_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1040, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 700);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1040, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyDiemSinhVienK19._1.Properties.Resources._73051444_2518440228242902_7160346987995332608_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 722);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIMainForm";
            this.Text = "MDIMainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MDIKhoa;
        private System.Windows.Forms.ToolStripMenuItem MDISinhvien;
        private System.Windows.Forms.ToolStripMenuItem MDITimkiem;
        private System.Windows.Forms.ToolStripMenuItem MDIThoat;
        private System.Windows.Forms.ToolTip toolTip;
    }
}



