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
    public partial class FormTimkiem : Telerik.WinControls.UI.RadForm
    {
        public FormTimkiem()
        {
            InitializeComponent();
        }

        private void FrmTimkiem_load(object sender, EventArgs e)
        {
            QLDSV1Entities timkiemsinhvien = new QLDSV1Entities();
            RGV_bangtimkiem.DataSource = timkiemsinhvien.sp_GetAllStudent();
        }

        private void RB_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void RB_huy_Click(object sender, EventArgs e)
        {
            QLDSV1Entities timkiemsinhvien = new QLDSV1Entities();
            RTB_timkiemsinhvien.Clear();
            RGV_bangtimkiem.DataSource = timkiemsinhvien.sp_GetAllStudent();
        }

        private void RB_timkiem_Click(object sender, EventArgs e)
        {
            QLDSV1Entities timkiemsinhvien = new QLDSV1Entities();
            RGV_bangtimkiem.DataSource = timkiemsinhvien.sp_TimkiemSinhvien(RTB_timkiemsinhvien.Text, RTB_timkiemsinhvien.Text, RTB_timkiemsinhvien.Text, RTB_timkiemsinhvien.Text, RTB_timkiemsinhvien.Text, RTB_timkiemsinhvien.Text);
        }

        private void FrmTimkiem_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            RTB_masv.Text = RGV_bangtimkiem.SelectedRows[0].Cells[0].Value.ToString();
            RTB_hovaten.Text = RGV_bangtimkiem.SelectedRows[0].Cells[1].Value.ToString();
            if (Boolean.Parse(RGV_bangtimkiem.SelectedRows[0].Cells[2].Value.ToString()) == true)
            {
                RRB_nam.IsChecked = true;
                RRB_nu.IsChecked = false;
            }
            if (Boolean.Parse(RGV_bangtimkiem.SelectedRows[0].Cells[2].Value.ToString()) == false)
            {
                RRB_nam.IsChecked = false;
                RRB_nu.IsChecked = true;
            }
            RDTP_ngaysinh.Text = RGV_bangtimkiem.SelectedRows[0].Cells[3].Value.ToString();
            RTB_lop.Text = RGV_bangtimkiem.SelectedRows[0].Cells[4].Value.ToString();
            RTB_tenkhoa.Text = RGV_bangtimkiem.SelectedRows[0].Cells[5].Value.ToString();
            RTB_hocky.Text = RGV_bangtimkiem.SelectedRows[0].Cells[6].Value.ToString();
            RTB_monhoc.Text = RGV_bangtimkiem.SelectedRows[0].Cells[7].Value.ToString();
            RTB_diemthilan1.Text = RGV_bangtimkiem.SelectedRows[0].Cells[8].Value.ToString();
            RTB_diemtrungbinh.Text = RGV_bangtimkiem.SelectedRows[0].Cells[9].Value.ToString();
            RTB_diemtongket.Text = RGV_bangtimkiem.SelectedRows[0].Cells[10].Value.ToString();
            RTB_hanhkiem.Text = RGV_bangtimkiem.SelectedRows[0].Cells[11].Value.ToString();
        }
    }
}
