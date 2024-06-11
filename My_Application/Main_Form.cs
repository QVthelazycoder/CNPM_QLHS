using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;


namespace My_Application
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            Main_Form_Load(new object(), new EventArgs());
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            // Mọi người đều có thể sử dụng chức năng tra cứu mà không cần đăng nhập
            tsmi_Tracuu.Visible = true;

            tsmi_Bangdiemmon.Visible = false;
            tsmi_Baocao.Visible = false;
            tsmi_ThaydoiQuydinh.Visible = false;
            tsmi_Tiepnhanhocsinh.Visible = false;
            tsmi_Xeplop.Visible = false;

            tsmi_Admin.Visible = true;
            tsmi_BGH.Visible = true;
            tsmi_Gvi.Visible = true;
            tsmi_Gvu.Visible = true;


            tsmi_Dangxuat.Visible = false;
        }

        private void AddForm(Form f)
        {
            this.panel_Content.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            this.panel_Content.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            f.Show();
        }


        // Đóng form, gửi thông báo cho người dùng
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            // Xác nhận với người dùng trước khi đóng form
            switch (MessageBox.Show(this, "Bạn có chắc chắn muốn thoát ?", "Đóng", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true; // Cancel the close operation
                    break;
                default:
                    break;
            }
        }

        private void tsmi_Hosohocsinh_Click(object sender, EventArgs e)
        {
            Ho_so_hs f = new Ho_so_hs();
            AddForm(f);
        }

        private void tsmi_Xeplop_Click(object sender, EventArgs e)
        {
            Xep_lop f = new Xep_lop();
            AddForm(f);
        }

        private void tsmi_Monhoc_Click(object sender, EventArgs e)
        {
            Danh_sach_mon_hoc f = new Danh_sach_mon_hoc();
            AddForm(f);
        }

        private void tsmi_Tracuu_Click(object sender, EventArgs e)
        {
            Tra_cuu f = new Tra_cuu();
            f.ShowDialog();
        }

        private void tsmi_Bangdiemmon_Click(object sender, EventArgs e)
        {
            Bang_diem_mon f;
            if (String.Equals(lb_Trangthaidangnhap.Text, "Tài khoản đang đăng nhập: Ban giám hiệu"))
                f = new Bang_diem_mon(0);
            else if (String.Equals(lb_Trangthaidangnhap.Text, "Tài khoản đang đăng nhập: Giáo viên"))
                f = new Bang_diem_mon(1);
            else
                f = new Bang_diem_mon(2);
            AddForm(f);
        }

        private void tsmi_BaocaoMon_Click(object sender, EventArgs e)
        {
            Bao_cao_Mon f;
            if (String.Equals(lb_Trangthaidangnhap.Text, "Tài khoản đang đăng nhập: Ban giám hiệu"))
                f = new Bao_cao_Mon(0);
            else if (String.Equals(lb_Trangthaidangnhap.Text, "Tài khoản đang đăng nhập: Giáo viên"))
                f = new Bao_cao_Mon(1);
            else
                f = new Bao_cao_Mon(2);
            AddForm(f);
        }

        private void tsmi_BaocaoHocky_Click(object sender, EventArgs e)
        {
            Bao_cao_Hocky f;
            if (String.Equals(lb_Trangthaidangnhap.Text, "Tài khoản đang đăng nhập: Ban giám hiệu"))
                f = new Bao_cao_Hocky(0);
            else if (String.Equals(lb_Trangthaidangnhap.Text, "Tài khoản đang đăng nhập: Giáo viên"))
                f = new Bao_cao_Hocky(1);
            else
                f = new Bao_cao_Hocky(2);
            AddForm(f);
        }

        private void tsmi_Tuoiquydinh_Click(object sender, EventArgs e)
        {
            Tuoiqd f = new Tuoiqd();
            f.Show();
        }

        private void tsmi_Danhsachmonhoc_Click(object sender, EventArgs e)
        {
            Danh_sach_mon_hoc f = new Danh_sach_mon_hoc();
            AddForm(f);
        }

        private void tsmi_Danhsachcaclop_Click(object sender, EventArgs e)
        {
            Danh_sach_khoi_lop f = new Danh_sach_khoi_lop();
            AddForm(f);
        }

        private void tsmi_Diemdat_Click(object sender, EventArgs e)
        {
            Diem_dat f = new Diem_dat();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dang_nhap f = new Dang_nhap(0);
            f.ShowDialog();
            if (f.Check())
            {
                tsmi_Chucnang.Visible = true;
                tsmi_Chucnang.Visible = true;
                tsmi_Bangdiemmon.Visible = true;
                tsmi_Baocao.Visible = true;
                tsmi_ThaydoiQuydinh.Visible = true;
                tsmi_Tiepnhanhocsinh.Visible = true;
                tsmi_Xeplop.Visible = true;
                tsmi_Tracuu.Visible = true;
                tsmi_Dangxuat.Visible = true;

                tsmi_Baocao.Text = "Báo cáo tổng kết";
                tsmi_Bangdiemmon.Text = "Bảng điểm môn học";


                tsmi_Admin.Visible = false;
                tsmi_BGH.Visible = false;
                tsmi_Gvu.Visible = false;
                tsmi_Gvi.Visible = false;

                lb_Trangthaidangnhap.Text = "Tài khoản đang đăng nhập: Admin";
            }
        }

        private void banGiámGiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dang_nhap f = new Dang_nhap(1);
            f.ShowDialog();
            if (f.Check())
            {
                tsmi_Chucnang.Visible = true;
                tsmi_Tracuu.Visible = true;
                tsmi_ThaydoiQuydinh.Visible = true;
                tsmi_Baocao.Visible = true;
                tsmi_Dangxuat.Visible = true;
                tsmi_Bangdiemmon.Visible = true;

                tsmi_Baocao.Text = "Xem báo cáo tổng kết";
                tsmi_Bangdiemmon.Text = "Xem bảng điểm môn học";

                tsmi_Tiepnhanhocsinh.Visible = false;
                tsmi_Xeplop.Visible = false;

                tsmi_Admin.Visible = false;
                tsmi_BGH.Visible = false;
                tsmi_Gvu.Visible = false;
                tsmi_Gvi.Visible = false;


                lb_Trangthaidangnhap.Text = "Tài khoản đang đăng nhập: Ban giám hiệu";
            }
        }

        private void giáoVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dang_nhap f = new Dang_nhap(2);
            f.ShowDialog();
            if (f.Check())
            {
                tsmi_Chucnang.Visible = true;
                tsmi_Tiepnhanhocsinh.Visible = true;
                tsmi_Xeplop.Visible = true;
                tsmi_Tracuu.Visible = true;
                tsmi_Dangxuat.Visible = true;

                tsmi_Bangdiemmon.Visible = false;
                tsmi_Baocao.Visible= false;
                tsmi_ThaydoiQuydinh.Visible = false;

                tsmi_Admin.Visible = false;
                tsmi_BGH.Visible = false;
                tsmi_Gvu.Visible = false;
                tsmi_Gvi.Visible = false;


                lb_Trangthaidangnhap.Text = "Tài khoản đang đăng nhập: Giáo vụ";
            }
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dang_nhap f = new Dang_nhap(3);
            f.ShowDialog();
            if (f.Check())
            {
                tsmi_Chucnang.Visible = true;
                tsmi_Bangdiemmon.Visible = true;
                tsmi_Baocao.Visible = true;
                tsmi_Tracuu.Visible = true;
                tsmi_Dangxuat.Visible = true;

                tsmi_Baocao.Text = "Lập báo cáo tổng kết";
                tsmi_Bangdiemmon.Text = "Nhận bảng điểm môn học";

                tsmi_ThaydoiQuydinh.Visible = false;
                tsmi_Tiepnhanhocsinh.Visible = false;
                tsmi_Xeplop.Visible = false;

                tsmi_Admin.Visible = false;
                tsmi_BGH.Visible = false;
                tsmi_Gvu.Visible = false;
                tsmi_Gvi.Visible = false;


                lb_Trangthaidangnhap.Text = "Tài khoản đang đăng nhập: Giáo viên";
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Bạn muốn đăng xuất khỏi tài khoản hiện tại ?", "Xác Nhận Đăng Xuất", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    Main_Form_Load(sender, e);
                    this.panel_Content.Controls.Clear();
                    lb_Trangthaidangnhap.Text = "Đăng xuất";
                    break;
                default:
                    break;
            }
        }
    }
}
