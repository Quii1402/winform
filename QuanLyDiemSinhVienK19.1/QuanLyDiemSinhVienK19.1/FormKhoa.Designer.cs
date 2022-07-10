namespace QuanLyDiemSinhVienK19._1
{
    partial class FormKhoa
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.RTB_makhoa = new Telerik.WinControls.UI.RadTextBox();
            this.RTB_tenkhoa = new Telerik.WinControls.UI.RadTextBox();
            this.RTB_timkiem = new Telerik.WinControls.UI.RadTextBox();
            this.RGV_bangkhoa = new Telerik.WinControls.UI.RadGridView();
            this.RB_luu = new Telerik.WinControls.UI.RadButton();
            this.RB_thoat = new Telerik.WinControls.UI.RadButton();
            this.RB_huy = new Telerik.WinControls.UI.RadButton();
            this.RB_xoa = new Telerik.WinControls.UI.RadButton();
            this.RB_sua = new Telerik.WinControls.UI.RadButton();
            this.RB_them = new Telerik.WinControls.UI.RadButton();
            this.RB_timkiem = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTB_makhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTB_tenkhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTB_timkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGV_bangkhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGV_bangkhoa.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_luu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_thoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_huy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_timkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.Red;
            this.radLabel1.Location = new System.Drawing.Point(282, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(413, 33);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "DANH SÁCH CÁC ĐƠN VỊ TRỰC THUỘC";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.radLabel2.Location = new System.Drawing.Point(85, 130);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(50, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Mã khoa";
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.radLabel3.Location = new System.Drawing.Point(391, 129);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(53, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Tên Khoa";
            // 
            // RTB_makhoa
            // 
            this.RTB_makhoa.Location = new System.Drawing.Point(141, 128);
            this.RTB_makhoa.Name = "RTB_makhoa";
            this.RTB_makhoa.ReadOnly = true;
            this.RTB_makhoa.Size = new System.Drawing.Size(141, 20);
            this.RTB_makhoa.TabIndex = 3;
            // 
            // RTB_tenkhoa
            // 
            this.RTB_tenkhoa.Location = new System.Drawing.Point(450, 128);
            this.RTB_tenkhoa.Name = "RTB_tenkhoa";
            this.RTB_tenkhoa.ReadOnly = true;
            this.RTB_tenkhoa.Size = new System.Drawing.Size(141, 20);
            this.RTB_tenkhoa.TabIndex = 4;
            // 
            // RTB_timkiem
            // 
            this.RTB_timkiem.Location = new System.Drawing.Point(764, 125);
            this.RTB_timkiem.Name = "RTB_timkiem";
            this.RTB_timkiem.Size = new System.Drawing.Size(100, 20);
            this.RTB_timkiem.TabIndex = 5;
            // 
            // RGV_bangkhoa
            // 
            this.RGV_bangkhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RGV_bangkhoa.Location = new System.Drawing.Point(9, 184);
            // 
            // 
            // 
            this.RGV_bangkhoa.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.RGV_bangkhoa.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.RGV_bangkhoa.Name = "RGV_bangkhoa";
            this.RGV_bangkhoa.Size = new System.Drawing.Size(971, 248);
            this.RGV_bangkhoa.TabIndex = 6;
            this.RGV_bangkhoa.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.GetalliteamRow_CellClick);
            // 
            // RB_luu
            // 
            this.RB_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RB_luu.ForeColor = System.Drawing.Color.Black;
            this.RB_luu.Image = global::QuanLyDiemSinhVienK19._1.Properties.Resources.Save;
            this.RB_luu.Location = new System.Drawing.Point(529, 454);
            this.RB_luu.Name = "RB_luu";
            this.RB_luu.Size = new System.Drawing.Size(110, 24);
            this.RB_luu.TabIndex = 13;
            this.RB_luu.Text = "Lưu";
            this.RB_luu.Click += new System.EventHandler(this.RB_luu_Click);
            // 
            // RB_thoat
            // 
            this.RB_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RB_thoat.ForeColor = System.Drawing.Color.Black;
            this.RB_thoat.Image = global::QuanLyDiemSinhVienK19._1.Properties.Resources.Exit;
            this.RB_thoat.Location = new System.Drawing.Point(854, 454);
            this.RB_thoat.Name = "RB_thoat";
            this.RB_thoat.Size = new System.Drawing.Size(110, 24);
            this.RB_thoat.TabIndex = 12;
            this.RB_thoat.Text = "Thoát";
            this.RB_thoat.Click += new System.EventHandler(this.RB_thoat_Click);
            // 
            // RB_huy
            // 
            this.RB_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RB_huy.ForeColor = System.Drawing.Color.Black;
            this.RB_huy.Image = global::QuanLyDiemSinhVienK19._1.Properties.Resources.Cancel;
            this.RB_huy.Location = new System.Drawing.Point(691, 454);
            this.RB_huy.Name = "RB_huy";
            this.RB_huy.Size = new System.Drawing.Size(110, 24);
            this.RB_huy.TabIndex = 11;
            this.RB_huy.Text = "Hủy";
            this.RB_huy.Click += new System.EventHandler(this.RB_huy_Click);
            // 
            // RB_xoa
            // 
            this.RB_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RB_xoa.ForeColor = System.Drawing.Color.Black;
            this.RB_xoa.Image = global::QuanLyDiemSinhVienK19._1.Properties.Resources.Delete;
            this.RB_xoa.Location = new System.Drawing.Point(362, 454);
            this.RB_xoa.Name = "RB_xoa";
            this.RB_xoa.Size = new System.Drawing.Size(110, 24);
            this.RB_xoa.TabIndex = 10;
            this.RB_xoa.Text = "Xóa";
            this.RB_xoa.Click += new System.EventHandler(this.RB_xoa_Click);
            // 
            // RB_sua
            // 
            this.RB_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RB_sua.ForeColor = System.Drawing.Color.Black;
            this.RB_sua.Image = global::QuanLyDiemSinhVienK19._1.Properties.Resources.Modify;
            this.RB_sua.Location = new System.Drawing.Point(191, 454);
            this.RB_sua.Name = "RB_sua";
            this.RB_sua.Size = new System.Drawing.Size(110, 24);
            this.RB_sua.TabIndex = 9;
            this.RB_sua.Text = "Sửa";
            this.RB_sua.Click += new System.EventHandler(this.RB_sua_Click);
            // 
            // RB_them
            // 
            this.RB_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RB_them.ForeColor = System.Drawing.Color.Black;
            this.RB_them.Image = global::QuanLyDiemSinhVienK19._1.Properties.Resources.Create;
            this.RB_them.Location = new System.Drawing.Point(23, 454);
            this.RB_them.Name = "RB_them";
            this.RB_them.Size = new System.Drawing.Size(110, 24);
            this.RB_them.TabIndex = 8;
            this.RB_them.Text = "Thêm";
            this.RB_them.Click += new System.EventHandler(this.RB_them_Click);
            // 
            // RB_timkiem
            // 
            this.RB_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RB_timkiem.ForeColor = System.Drawing.Color.Black;
            this.RB_timkiem.Image = global::QuanLyDiemSinhVienK19._1.Properties.Resources.Find;
            this.RB_timkiem.Location = new System.Drawing.Point(870, 123);
            this.RB_timkiem.Name = "RB_timkiem";
            this.RB_timkiem.Size = new System.Drawing.Size(110, 24);
            this.RB_timkiem.TabIndex = 7;
            this.RB_timkiem.Text = "Tìm kiếm";
            this.RB_timkiem.Click += new System.EventHandler(this.RB_timkiem_Click);
            // 
            // FormKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 511);
            this.Controls.Add(this.RB_luu);
            this.Controls.Add(this.RB_thoat);
            this.Controls.Add(this.RB_huy);
            this.Controls.Add(this.RB_xoa);
            this.Controls.Add(this.RB_sua);
            this.Controls.Add(this.RB_them);
            this.Controls.Add(this.RB_timkiem);
            this.Controls.Add(this.RGV_bangkhoa);
            this.Controls.Add(this.RTB_timkiem);
            this.Controls.Add(this.RTB_tenkhoa);
            this.Controls.Add(this.RTB_makhoa);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "FormKhoa";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FormKhoa";
            this.Load += new System.EventHandler(this.frmKhoa_load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTB_makhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTB_tenkhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTB_timkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGV_bangkhoa.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGV_bangkhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_luu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_thoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_huy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB_timkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox RTB_makhoa;
        private Telerik.WinControls.UI.RadTextBox RTB_tenkhoa;
        private Telerik.WinControls.UI.RadTextBox RTB_timkiem;
        private Telerik.WinControls.UI.RadGridView RGV_bangkhoa;
        private Telerik.WinControls.UI.RadButton RB_timkiem;
        private Telerik.WinControls.UI.RadButton RB_them;
        private Telerik.WinControls.UI.RadButton RB_sua;
        private Telerik.WinControls.UI.RadButton RB_xoa;
        private Telerik.WinControls.UI.RadButton RB_huy;
        private Telerik.WinControls.UI.RadButton RB_thoat;
        private Telerik.WinControls.UI.RadButton RB_luu;
    }
}
