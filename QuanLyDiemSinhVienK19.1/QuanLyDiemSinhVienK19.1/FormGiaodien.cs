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
    public partial class FormGiaodien : Form
    {
        public int state;
        public FormGiaodien()
        {
            InitializeComponent();
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void FormGiaodien_Load(object sender, EventArgs e)
        {
            state = 0;
            QLDSV1Entities QLDSV = new QLDSV1Entities();
            RGV_bangsinhvien.DataSource = QLDSV.sp_GetAllStudent1();
            RDDL_makhoa.DataSource = QLDSV.sp_GetKhoaIf();
            RDDL_makhoa.DisplayMember = "TENKHOA";
            RDDL_makhoa.ValueMember = "MAKHOA";
            RDDL_makhoa.Text = null;
        }

        private void GetiteamRow_cellclick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            RTB_masv.Text = RGV_bangsinhvien.SelectedRows[0].Cells[0].Value.ToString();
            RTB_hovaten.Text = RGV_bangsinhvien.SelectedRows[0].Cells[1].Value.ToString();
            if (Boolean.Parse(RGV_bangsinhvien.SelectedRows[0].Cells[2].Value.ToString()) == true)
            {
                RRB_nam.IsChecked = true;
                RRB_nu.IsChecked = false;
            }
            if (Boolean.Parse(RGV_bangsinhvien.SelectedRows[0].Cells[2].Value.ToString()) == false)
            {
                RRB_nam.IsChecked = false;
                RRB_nu.IsChecked = true;
            }
            RDTP_ngaysinh.Text = RGV_bangsinhvien.SelectedRows[0].Cells[3].Value.ToString();
            RTB_lop.Text = RGV_bangsinhvien.SelectedRows[0].Cells[4].Value.ToString();
         
            RTB_hocky.Text = RGV_bangsinhvien.SelectedRows[0].Cells[5].Value.ToString();
            RTB_monhoc.Text = RGV_bangsinhvien.SelectedRows[0].Cells[6].Value.ToString();
            RTB_diemthilan1.Text = RGV_bangsinhvien.SelectedRows[0].Cells[7].Value.ToString();
            RTB_diemtrungbinh.Text = RGV_bangsinhvien.SelectedRows[0].Cells[8].Value.ToString();
            RTB_diemtongket.Text = RGV_bangsinhvien.SelectedRows[0].Cells[9].Value.ToString();
            RTB_hanhkiem.Text = RGV_bangsinhvien.SelectedRows[0].Cells[10].Value.ToString();
            RDDL_makhoa.Text = RGV_bangsinhvien.SelectedRows[0].Cells[11].Value.ToString();
            imageSinhvien.Image = byteArrayToImage((byte[])RGV_bangsinhvien.SelectedRows[0].Cells[12].Value);
        }

        private void RB_sua_Click(object sender, EventArgs e)
        {
            state = 1;
            RTB_hovaten.ReadOnly = false;
            RTB_hanhkiem.ReadOnly = false;
            RTB_diemtrungbinh.ReadOnly = false;
            RTB_diemthilan1.ReadOnly = false;
            RTB_diemtongket.ReadOnly = false;
            RDDL_makhoa.ReadOnly = false;
            RTB_lop.ReadOnly = false;
            RTB_monhoc.ReadOnly = false;
            RDTP_ngaysinh.ReadOnly = false;
            RRB_nam.ReadOnly = false;
            RRB_nu.ReadOnly = false;
            RTB_hocky.ReadOnly = false;
            RTB_masv.Focus();
        }

        private void RB_them_Click(object sender, EventArgs e)
        {
            state = 2;
            RTB_masv.Clear();
            RTB_hovaten.Clear();
            RTB_hanhkiem.Clear();
            RTB_diemtrungbinh.Clear();
            RTB_diemthilan1.Clear();
            RTB_diemtongket.Clear();
            RTB_lop.Clear();
            RTB_monhoc.Clear();
            RTB_hocky.Clear();


            RTB_masv.ReadOnly = false;
            RTB_hovaten.ReadOnly = false;
            RTB_hanhkiem.ReadOnly = false;
            RTB_diemtrungbinh.ReadOnly = false;
            RTB_diemthilan1.ReadOnly = false;
            RTB_diemtongket.ReadOnly = false;
            RDDL_makhoa.ReadOnly = false;
            RTB_lop.ReadOnly = false;
            RTB_monhoc.ReadOnly = false;
            RDTP_ngaysinh.ReadOnly = false;
            RRB_nam.ReadOnly = false;
            RRB_nu.ReadOnly = false;
            RTB_hocky.ReadOnly = false;
        }
        private void RB_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá Sinh viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QLDSV1Entities QLDSV = new QLDSV1Entities();
                QLDSV.sp_Deletestudent(RTB_masv.Text);
                RGV_bangsinhvien.DataSource = QLDSV.sp_GetAllStudent1();
            }
        }

        private void RB_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void RB_huy_Click(object sender, EventArgs e)
        {
            QLDSV1Entities QLDSV = new QLDSV1Entities();
            RTB_masv.Clear();
            RTB_hovaten.Clear();
            RTB_hanhkiem.Clear();
            RTB_diemtrungbinh.Clear();
            RTB_diemthilan1.Clear();
            RTB_diemtongket.Clear();
            RTB_lop.Clear();
            RTB_monhoc.Clear();
            RTB_hocky.Clear();
            imageSinhvien.Image = null;
            RDTP_ngaysinh.Text = null;
            RDDL_makhoa.Text = null;
            RGV_bangsinhvien.DataSource = QLDSV.sp_GetAllStudent1();
        }

        private void Makhoa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RDDL_makhoa.Text))
            {
                e.Cancel = true;
                RDDL_makhoa.Focus();
                errormakhoa.SetError(RDDL_makhoa, "Mã Khoa không được để trống");
            }
            else
            {
                e.Cancel = false;
                errormakhoa.SetError(RDDL_makhoa, "");
            }
        }

        private void Lop_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_lop.Text))
            {
                e.Cancel = true;
                RTB_lop.Focus();
                errorlop.SetError(RTB_lop, "Thông tin Lớp không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorlop.SetError(RTB_lop, "");
            }
        }

        private void Monhoc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_monhoc.Text))
            {
                e.Cancel = true;
                RTB_monhoc.Focus();
                errormonhoc.SetError(RTB_monhoc, "Thông tin Môn Học không được để trống");
            }
            else
            {
                e.Cancel = false;
                errormonhoc.SetError(RTB_monhoc, "");
            }
        }

        private void Hocky_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_hocky.Text))
            {
                e.Cancel = true;
                RTB_hocky.Focus();
                errorhocky.SetError(RTB_hocky, "Dữ liệu không được không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorhocky.SetError(RTB_hocky, "");
            }
        }

        private void Masv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_masv.Text))
            {
                e.Cancel = true;
                RTB_masv.Focus();
                errormasv.SetError(RTB_masv, "Mã Sinh Viên không được để trống");
            }
            else
            {
                e.Cancel = false;
                errormasv.SetError(RTB_masv, "");
            }
        }

        private void Hovaten_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_hovaten.Text))
            {
                e.Cancel = true;
                RTB_hovaten.Focus();
                errorhovaten.SetError(RTB_hovaten, "Thông tin họ và tên không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorhovaten.SetError(RTB_hovaten, "");
            }
        }

        private void Diemtrungbinh_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_diemtrungbinh.Text))
            {
                e.Cancel = true;
                RTB_diemtrungbinh.Focus();
                errordiemtrungbinh.SetError(RTB_diemtrungbinh, "Dữ liệu không được không được để trống");
            }
            else
            {
                e.Cancel = false;
                errordiemtrungbinh.SetError(RTB_diemtrungbinh, "");
            }
        }

        private void Hanhkiem_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_hanhkiem.Text))
            {
                e.Cancel = true;
                RTB_hanhkiem.Focus();
                errorhanhkiem.SetError(RTB_hanhkiem, "Dữ liệu không được không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorhanhkiem.SetError(RTB_hanhkiem, "");
            }
        }

        private void Diemtongket_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_diemtongket.Text))
            {
                e.Cancel = true;
                RTB_diemtongket.Focus();
                errordiemtongket.SetError(RTB_diemtongket, "Dữ liệu không được không được để trống");
            }
            else
            {
                e.Cancel = false;
                errordiemtongket.SetError(RTB_diemtongket, "");
            }
        }

        private void Diemthilan1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RTB_diemthilan1.Text))
            {
                e.Cancel = true;
                RTB_diemthilan1.Focus();
                errordiemthilan1.SetError(RTB_diemthilan1, "Dữ liệu không được không được để trống");
            }
            else
            {
                e.Cancel = false;
                errordiemthilan1.SetError(RTB_diemthilan1, "");
            }
        }

        private void BT_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image file (*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
            if (of.ShowDialog() == DialogResult.OK)
                imageSinhvien.Image = new Bitmap(of.FileName);

        }

        private void RB_luu_Click(object sender, EventArgs e)
        {
            QLDSV1Entities QLDSV = new QLDSV1Entities();

            if (state == 1)
            {
                if (RRB_nam.IsChecked == true)
                    QLDSV.Update_Info_student1(RTB_masv.Text,
                                               RTB_hovaten.Text,
                                               true,
                                               DateTime.Parse(RDTP_ngaysinh.Text),
                                               RTB_lop.Text,
                                               RDDL_makhoa.SelectedValue.ToString(),
                                               RTB_hocky.Text,
                                               RTB_monhoc.Text,
                                               RTB_diemthilan1.Text,
                                               RTB_diemtrungbinh.Text,
                                               RTB_diemtongket.Text,
                                               RTB_hanhkiem.Text,
                                               ImageToByteArray(imageSinhvien.Image));

                else
                    QLDSV.Update_Info_student1(RTB_masv.Text,
                                               RTB_hovaten.Text,
                                               false,
                                               DateTime.Parse(RDTP_ngaysinh.Text),
                                               RTB_lop.Text,
                                               RDDL_makhoa.SelectedValue.ToString(),
                                               RTB_hocky.Text,
                                               RTB_monhoc.Text,
                                               RTB_diemthilan1.Text,
                                               RTB_diemtrungbinh.Text,
                                               RTB_diemtongket.Text,
                                               RTB_hanhkiem.Text,
                                               ImageToByteArray(imageSinhvien.Image));
                RGV_bangsinhvien.DataSource = QLDSV.sp_GetAllStudent1();

                RTB_masv.ReadOnly = true;
                RTB_hovaten.ReadOnly = true;
                RTB_hanhkiem.ReadOnly = true;
                RTB_diemtrungbinh.ReadOnly = true;
                RTB_diemthilan1.ReadOnly = true;
                RTB_diemtongket.ReadOnly = true;
                RDDL_makhoa.ReadOnly = true;
                RTB_lop.ReadOnly = true;
                RTB_monhoc.ReadOnly = true;
                RDTP_ngaysinh.ReadOnly = true;
                RRB_nam.ReadOnly = true;
                RRB_nu.ReadOnly = true;
                RTB_hocky.ReadOnly = true;
            }
            if (state == 2)
            {

                if (RRB_nam.IsChecked == true)
                    QLDSV.sp_InserSinhvien(RTB_masv.Text,
                                           RTB_hovaten.Text, 
                                           true,
                                           DateTime.Parse(RDTP_ngaysinh.Text),
                                           RTB_lop.Text,
                                           RDDL_makhoa.SelectedValue.ToString(),
                                           RTB_hocky.Text,
                                           RTB_monhoc.Text,
                                           RTB_diemthilan1.Text,
                                           RTB_diemtrungbinh.Text,
                                           RTB_diemtongket.Text,
                                           RTB_hanhkiem.Text,
                                           ImageToByteArray(imageSinhvien.Image));
                else
                    QLDSV.sp_InserSinhvien
                                           (RTB_masv.Text,
                                            RTB_hovaten.Text,
                                            false,
                                            DateTime.Parse(RDTP_ngaysinh.Text),
                                            RTB_lop.Text,
                                            RDDL_makhoa.SelectedValue.ToString(),
                                            RTB_hocky.Text,
                                            RTB_monhoc.Text,
                                            RTB_diemthilan1.Text,
                                            RTB_diemtrungbinh.Text,
                                            RTB_diemtongket.Text,
                                            RTB_hanhkiem.Text,
                                            ImageToByteArray(imageSinhvien.Image));
                RGV_bangsinhvien.DataSource = QLDSV.sp_GetAllStudent1();

                RTB_masv.ReadOnly = true;
                RTB_hovaten.ReadOnly = true;
                RTB_hanhkiem.ReadOnly = true;
                RTB_diemtrungbinh.ReadOnly = true;
                RTB_diemthilan1.ReadOnly = true;
                RTB_diemtongket.ReadOnly = true;
                RDDL_makhoa.ReadOnly = true;
                RTB_lop.ReadOnly = true;
                RTB_monhoc.ReadOnly = true;
                RDTP_ngaysinh.ReadOnly = true;
                RRB_nam.ReadOnly = true;
                RRB_nu.ReadOnly = true;
                RTB_hocky.ReadOnly = true;
            }
        }
    }
}
