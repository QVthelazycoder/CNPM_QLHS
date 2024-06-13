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
    public partial class Them_khoi_lop : Form
    {
        private string tenlop;

        public Them_khoi_lop(string tenlop)
        {
            this.tenlop = tenlop;
            InitializeComponent();
        }

        public void Them_khoi_lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_ApplicationDataSet.LOP' table. You can move, or remove it, as needed.
            this.Khoi_TableAdapter.Fill(this.Khoi_DataSet.KHOILOP);

            if (string.IsNullOrEmpty(tenlop))
            {
                this.Text = "Thêm Lớp";
                cbb_Khoi.SelectedIndex = 0;
            }
            else
            {
                this.Text = "Cập Nhật Lớp";
                List<CustomParam> list = new List<CustomParam>();
                list.Add(new CustomParam()
                {
                    Key = "@TENLOP",
                    Value = tenlop,
                });
                var dr = DatabaseFunc.SelectRows("LOP", list);
                txt_Tenlop.Text = dr["TENLOP"].ToString();
                cbb_Khoi.Text = dr["MAKHOI"].ToString();
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu tên lớp cũ, dùng cho lệnh Update
            var tenlop_old = this.tenlop;
            // Lấy dữ liệu nhập từ TextBox
            var tenlop_new = txt_Tenlop.Text;
            var makhoi = cbb_Khoi.Text;
            // Taọ list chứa các dữ liệu của textbox
            List<CustomParam> list = new List<CustomParam>();
            // Thêm các giá trị theo kiểu (key, value) vào list
            list.Add(new CustomParam()
            {
                Key = "@TENLOP",
                Value = tenlop_new,
            });
            list.Add(new CustomParam()
            {
                Key = "@MAKHOI",
                Value = makhoi,
            });

            // Kiểm tra thông tin được nhập có khác rỗng không.
            if (String.IsNullOrEmpty(tenlop_new))
                MessageBox.Show("Không được để trống tên lớp !", "Lỗi");
            
            // Kiểm tra tên lớp mới có bị trùng với các lớp đã có hay không
            int tenlop_existed = (int)DatabaseFunc.Select_Value($"SELECT COUNT(*) FROM LOP WHERE TENLOP = '{tenlop_new}'");
            if (tenlop_existed > 0)
            {
                MessageBox.Show("Tên lớp đã tồn tại !", "Thông báo");
                return;
            }
            else
            {
                int result;
                switch (this.Text)
                {
                    case "Thêm Lớp":
                        // Nếu tên lớp chưa tồn tại, thực hiện thêm lớp mới
                        result = DatabaseFunc.Insert("LOP", list);
                        if (result != 0)
                        {
                            MessageBox.Show("Thêm lớp thành công !", "Thông báo");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi kết nối !", "Lỗi");
                        break;

                    case "Cập Nhật Lớp":
                        list.Add(new CustomParam()
                        {
                            Key = "@TENLOP_OLD",
                            Value = tenlop_old,
                        });
                        result = DatabaseFunc.Update("LOP", list);
                        if (result != 0)
                        {
                            MessageBox.Show("Cập nhật lớp thành công !", "Thông báo");
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
            }
        }

        private void Them_khoi_lop_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
