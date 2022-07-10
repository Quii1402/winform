using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVienK19._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_dangnhap_Click(object sender, EventArgs e)
        {
            if (this.TB_user.Text == "admin" && this.TB_pass.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MDIMainForm MDIMainForm = new MDIMainForm();
                MDIMainForm.ShowDialog();
            }
            else

            if (this.TB_user.Text == "user" && this.TB_pass.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormTimkiem formTimkiem = new FormTimkiem();
                formTimkiem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mật khẩu của bạn không đúng!" + "\r\n" + "Vui lòng kiểm tra lại tài khoản và mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BT_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
