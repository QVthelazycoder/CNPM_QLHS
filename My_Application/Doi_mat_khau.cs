using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Application
{
    public partial class Doi_mat_khau : Form
    {
        private string taikhoan;
        private string matkhau;

        public Doi_mat_khau(string taikhoan, string matkhau)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            InitializeComponent();
        }

        private void btn_Xacnhan_Click(object sender, EventArgs e)
        {
            var matkhaucu = txt_Matkhaucu.Text;
            var matkhaumoi = txt_Matkhaumoi.Text;

            if (!String.Equals(this.matkhau, matkhaucu))
            {
                MessageBox.Show("Mật khẩu cũ không đúng !\nĐổi mật khẩu thất bại", "Thông báo");
                return;
            }
            else
            {
                List<CustomParam> list = new List<CustomParam>();
                list.Add(new CustomParam()
                {
                    Key = "@TAIKHOAN",
                    Value = taikhoan
                });
                list.Add(new CustomParam()
                {
                    Key = "@MATKHAU",
                    Value = matkhaumoi
                });
                int result = DatabaseFunc.Update("USERS", list);
                if (result != 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo");
                    try
                    {
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã xảy ra lỗi !", "Thông báo");
                    }
                    this.Dispose();
                } 
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi kết nối !\nĐổi mật khẩu thất bại !", "Thông báo");
                    return;
                }
            }
        }
    }
}
