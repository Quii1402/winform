using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace QuanLyDiemSinhVienK19._1
{
    public partial class FormKhoa : Telerik.WinControls.UI.RadForm
    {
        public int state;
        public FormKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_load(object sender, EventArgs e)
        {
            state = 0;
            QLDSV1Entities khoa = new QLDSV1Entities();
            RGV_bangkhoa.DataSource = khoa.sp_GetAllkhoa();
        }

        private void GetalliteamRow_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            RTB_makhoa.Text = RGV_bangkhoa.SelectedRows[0].Cells[0].Value.ToString();
            RTB_tenkhoa.Text = RGV_bangkhoa.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void RB_them_Click(object sender, EventArgs e)
        {
            state = 2;
            RTB_makhoa.ReadOnly = false;
            RTB_tenkhoa.ReadOnly = false;
        }

        private void RB_sua_Click(object sender, EventArgs e)
        {
            state = 1;
            RTB_makhoa.ReadOnly = false;
            RTB_tenkhoa.ReadOnly = false;
        }

        private void RB_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Khoa này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QLDSV1Entities QLDSV = new QLDSV1Entities();
                QLDSV.sp_DeleteKhoa(RTB_makhoa.Text);
                RGV_bangkhoa.DataSource = QLDSV.sp_GetAllkhoa();
            }
        }

        private void RB_luu_Click(object sender, EventArgs e)
        {
            QLDSV1Entities khoa = new QLDSV1Entities();
            if (state == 1)
            {
                khoa.Update_Info_KHOA(RTB_makhoa.Text, RTB_tenkhoa.Text);
                RGV_bangkhoa.DataSource = khoa.sp_GetAllkhoa();
                RTB_makhoa.ReadOnly = true;
                RTB_tenkhoa.ReadOnly = true;
            }
            if (state == 2)
            {
                khoa.sp_InserKHOA(RTB_makhoa.Text, RTB_tenkhoa.Text);
                RGV_bangkhoa.DataSource = khoa.sp_GetAllkhoa();
                RTB_makhoa.ReadOnly = true;
                RTB_tenkhoa.ReadOnly = true;
            }
        }

        private void RB_huy_Click(object sender, EventArgs e)
        {
            QLDSV1Entities khoa = new QLDSV1Entities();
            RTB_makhoa.Clear();
            RTB_tenkhoa.Clear();
            RTB_timkiem.Clear();
            RGV_bangkhoa.DataSource = khoa.sp_GetAllkhoa();
        }

        private void RB_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void RB_timkiem_Click(object sender, EventArgs e)
        {
            QLDSV1Entities timkiem = new QLDSV1Entities();
            RGV_bangkhoa.DataSource = timkiem.sp_TimkiemTenKhoa(RTB_timkiem.Text, RTB_timkiem.Text);
        }
    }
}
