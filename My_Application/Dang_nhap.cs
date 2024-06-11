using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My_Application
{
    public partial class Dang_nhap : Form
    {
        private int acccount;
        private DataRow result = null;
        private List<CustomParam> list = null;

        public Dang_nhap(int account)
        {
            this.acccount = account;
            InitializeComponent();
        }

        private void Dang_nhap_Load(object sender, EventArgs e)
        {
            frm_Load(sender, e);
        }

        private void frm_Load(object sender, EventArgs e)
        {
            switch (this.acccount)
            {
                case 0:
                    this.list = new List<CustomParam>();
                    list.Add(new CustomParam()
                    {
                        Key = "@TEN_USER",
                        Value = "Admin"
                    });
                    break;

                case 1:
                    this.list = new List<CustomParam>();
                    list.Add(new CustomParam()
                    {
                        Key = "@TEN_USER",
                        Value = "Ban Giám Hiệu"
                    });
                    break;

                case 2:
                    this.list = new List<CustomParam>();
                    list.Add(new CustomParam()
                    {
                        Key = "@TEN_USER",
                        Value = "Giáo Vụ"
                    });
                    break;

                case 3:
                    this.list = new List<CustomParam>();
                    list.Add(new CustomParam()
                    {
                        Key = "@TEN_USER",
                        Value = "Giáo Viên"
                    });
                    break;
            }
            this.result = DatabaseFunc.SelectRows("USERS", list);
            if (result == null)
            {
                MessageBox.Show("Đã xảy ra lỗi kết nối !", "Thông báo");
                this.Close();
            }
            txt_Taikhoan.Text = result["TAIKHOAN"].ToString();
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Matkhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu !", "Lỗi đăng nhập");
            }
            else if (Check())
            {
                MessageBox.Show("Đăng nhập thành công !", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không trùng khớp !", "Lỗi đăng nhập");
            }
        }

        public bool Check()
        {
            var matkhau_dung = this.result["MATKHAU"].ToString();
            var matkhau = txt_Matkhau.Text;
            if (String.Equals(matkhau, matkhau_dung))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txt_Matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Dangnhap.PerformClick();
            }
        }

        private void btn_Doimatkhau_Click(object sender, EventArgs e)
        {
            var taikhoan = this.result["TAIKHOAN"].ToString();
            var matkhau = this.result["MATKHAU"].ToString();

            Doi_mat_khau f = new Doi_mat_khau(taikhoan, matkhau);
            f.ShowDialog();
            if (f.IsDisposed)
            {
                this.frm_Load(sender, e);
            }
        }
    }
}
