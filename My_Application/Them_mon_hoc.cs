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
    public partial class Them_mon_hoc : Form
    {
        private string mamon;

        public Them_mon_hoc(string mamon)
        {
            this.mamon = mamon;
            InitializeComponent();
            Them_mon_hoc_Load(new object(), new EventArgs());
        }

        public void Them_mon_hoc_Load(object sender, EventArgs e)
        {
            // Nếu không có mã học sinh, form sẽ hiển thị "Thêm Hồ Sơ"
            if (string.IsNullOrEmpty(mamon))
            {
                this.Text = "Thêm Môn Học";
            }
            // Nếu có mã học sinh truyền vào, form sẽ hiển thị "Cập Nhật Hồ Sơ" của học sinh tương ứng
            else
            {
                this.Text = "Cập Nhật Môn Học";
                txt_Mamon.ReadOnly = true;
                List<CustomParam> list = new List<CustomParam>();
                list.Add(new CustomParam()
                {
                    Key = "@MAMON",
                    Value = mamon,
                });
                var dr = DatabaseFunc.SelectRows("MONHOC", list);
                txt_Mamon.Text = dr["MAMON"].ToString();
                txt_Tenmon.Text = dr["TENMON"].ToString();
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu nhập từ TextBox
            var mamon = txt_Mamon.Text;
            var tenmon = txt_Tenmon.Text;
            // Taọ list chứa các dữ liệu của textbox
            List<CustomParam> list = new List<CustomParam>();
            // Thêm các giá trị theo kiểu (key, value) vào list
            list.Add(new CustomParam()
            {
                Key = "@MAMON",
                Value = mamon,
            });
            list.Add(new CustomParam()
            {
                Key = "@TENMON",
                Value = tenmon,
            });

            // Kiểm tra thông tin được nhập có khác rỗng không.
            if (String.IsNullOrEmpty(mamon))
            {
                MessageBox.Show("Không được để trống mã môn !", "Lỗi");
                return;
            }
            else if (String.IsNullOrEmpty(tenmon))
            {
                MessageBox.Show("Không được để trống tên môn !", "Lỗi");
                return;
            }
            else
            {
                // Kiểm tra mã môn mới có bị trùng với các mã môn đã có hay không
                int mamon_existed = (int)DatabaseFunc.Select_Value($"SELECT COUNT(*) FROM MONHOC WHERE MAMON = '{mamon}'");
                int tenmon_existed = (int)DatabaseFunc.Select_Value($"SELECT COUNT(*) FROM MONHOC WHERE TENMON = N'{tenmon}'");
                if (mamon_existed > 0)
                {
                    MessageBox.Show("Mã môn học đã tồn tại !", "Thông báo");
                    return;
                }
                else if (tenmon_existed > 0)
                {
                    MessageBox.Show("Tên môn học đã tồn tại !", "Thông báo");
                    return;
                }
                int result;
                switch (this.Text)
                {
                    case "Thêm Môn Học":
                        // Nếu mã môn chưa tồn tại, thực hiện thêm mã môn mới
                        result = DatabaseFunc.Insert("MONHOC", list);
                        if (result != 0)
                        {
                            MessageBox.Show("Thêm môn học thành công !", "Thông báo");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi kết nối !", "Lỗi");
                            return;
                        }
                        break;

                    case "Cập Nhật Môn Học":

                        result = DatabaseFunc.Update("MONHOC", list);
                        if (result != 0)
                        {
                            MessageBox.Show("Cập nhật môn học thành công !", "Thông báo");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi kết nối !", "Lỗi");
                            return;
                        }
                        break;
                }
                this.Dispose();
                return;
            }
        }

        private void Them_mon_hoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            throw new NotImplementedException();
        }
    }
}
