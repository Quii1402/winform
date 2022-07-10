namespace QuanLyDiemSinhVienK19._1
{
    partial class Form1
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TB_user = new System.Windows.Forms.TextBox();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.BT_thoat = new System.Windows.Forms.Button();
            this.BT_dangnhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(115, 74);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(259, 33);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.radLabel2.Location = new System.Drawing.Point(65, 155);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(61, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Đăng nhập";
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.radLabel3.Location = new System.Drawing.Point(73, 215);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(53, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Mật khẩu";
            // 
            // TB_user
            // 
            this.TB_user.Location = new System.Drawing.Point(153, 155);
            this.TB_user.Name = "TB_user";
            this.TB_user.Size = new System.Drawing.Size(221, 20);
            this.TB_user.TabIndex = 3;
            // 
            // TB_pass
            // 
            this.TB_pass.Location = new System.Drawing.Point(153, 215);
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.PasswordChar = '*';
            this.TB_pass.Size = new System.Drawing.Size(221, 20);
            this.TB_pass.TabIndex = 4;
            // 
            // BT_thoat
            // 
            this.BT_thoat.BackColor = System.Drawing.Color.Transparent;
            this.BT_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BT_thoat.Location = new System.Drawing.Point(274, 301);
            this.BT_thoat.Name = "BT_thoat";
            this.BT_thoat.Size = new System.Drawing.Size(90, 35);
            this.BT_thoat.TabIndex = 6;
            this.BT_thoat.Text = "Thoát";
            this.BT_thoat.UseVisualStyleBackColor = false;
            this.BT_thoat.Click += new System.EventHandler(this.BT_thoat_Click);
            // 
            // BT_dangnhap
            // 
            this.BT_dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.BT_dangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BT_dangnhap.Location = new System.Drawing.Point(104, 300);
            this.BT_dangnhap.Name = "BT_dangnhap";
            this.BT_dangnhap.Size = new System.Drawing.Size(90, 36);
            this.BT_dangnhap.TabIndex = 5;
            this.BT_dangnhap.Text = "Đăng nhập";
            this.BT_dangnhap.UseVisualStyleBackColor = false;
            this.BT_dangnhap.Click += new System.EventHandler(this.BT_dangnhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDiemSinhVienK19._1.Properties.Resources.tải_xuống;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 79);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyDiemSinhVienK19._1.Properties.Resources.jkj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(492, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BT_thoat);
            this.Controls.Add(this.BT_dangnhap);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.TB_user);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.TextBox TB_user;
        private System.Windows.Forms.TextBox TB_pass;
        private System.Windows.Forms.Button BT_dangnhap;
        private System.Windows.Forms.Button BT_thoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

