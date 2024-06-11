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
    public partial class Them_ho_so : Form
    {
        private string mahs;

        public Them_ho_so(string mahs)
        {
            this.mahs = mahs;
            InitializeComponent();
            Them_ho_so_Load(new object(), new EventArgs());
        }

        public void Them_ho_so_Load(object sender, EventArgs e)
        {
            // Nếu không có mã học sinh, form sẽ hiển thị "Thêm Hồ Sơ"
            if (string.IsNullOrEmpty(mahs))
            {
                this.Text = "Thêm Hồ Sơ";
                cbb_Gioitinh.SelectedIndex = 0;
            }
            // Nếu có mã học sinh truyền vào, form sẽ hiển thị "Cập Nhật Hồ Sơ" của học sinh tương ứng
            else
            {
                this.Text = "Sửa Hồ Sơ";
                List<CustomParam> list = new List<CustomParam>();
                list.Add(new CustomParam()
                {
                    Key = "@MAHS",
                    Value = mahs,
                });
                var dr = DatabaseFunc.SelectRows("HOCSINH", list);
                txt_Ho.Text = dr["HO"].ToString();
                txt_Dem.Text = dr["DEM"].ToString();
                txt_Ten.Text = dr["TEN"].ToString();
                dtp_Ngaysinh.Text = dr["NGAYSINH"].ToString();
                txt_Email.Text = dr["EMAIL"].ToString();
                txt_Diachi.Text = dr["DIACHI"].ToString();
                cbb_Gioitinh.Text = dr["GIOITINH"].ToString();
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu nhập từ TextBox
            var ho = txt_Ho.Text;
            var tendem = txt_Dem.Text;
            var ten = txt_Ten.Text;
            DateTime ngaysinh = dtp_Ngaysinh.Value;
            var gioitinh = cbb_Gioitinh.Text;
            var email = txt_Email.Text;
            var diachi = txt_Diachi.Text;
            // Taọ list chứa các dữ liệu của textbox
            List<CustomParam> list_Hocsinh = new List<CustomParam>();
            // Thêm các giá trị theo kiểu (key, value) vào list
            list_Hocsinh.Add(new CustomParam()
            {
                Key = "@HO",
                Value = ho,
            });
            list_Hocsinh.Add(new CustomParam()
            {
                Key = "@DEM",
                Value = tendem,
            });
            list_Hocsinh.Add(new CustomParam()
            {
                Key = "@TEN",
                Value = ten,
            }); 
            list_Hocsinh.Add(new CustomParam()
            {
                Key = "@NGAYSINH",
                Value = ngaysinh.ToString(),
            }); 
            list_Hocsinh.Add(new CustomParam()
            {
                Key = "@GIOITINH",
                Value = gioitinh,
            }); 
            list_Hocsinh.Add(new CustomParam()
            {
                Key = "@EMAIL",
                Value = email,
            });
            list_Hocsinh.Add(new CustomParam()
            {
                Key = "@DIACHI",
                Value = diachi,
            });

            // Kiểm tra thông tin được nhập có khác rỗng không.
            // Nếu rỗng sẽ báo lỗi, ngược lại sẽ tiếp tục kiểm tra điều kiện tuổi

            if (String.IsNullOrEmpty(ho) || String.IsNullOrEmpty(ten) || 
                String.IsNullOrEmpty(ngaysinh.ToString()) || String.IsNullOrEmpty(diachi))
                MessageBox.Show("Không được để trống các thông tin sau: họ, tên, ngày sinh, địa chỉ", "Lỗi");
            else
            {
                // Kiểm tra điều kiện tuổi của hồ sơ
                int max_age = (int)DatabaseFunc.Select_Value("SELECT GIATRI FROM QUYDINH WHERE TENQD = N'Tuổi tối đa'");
                int min_age = (int)DatabaseFunc.Select_Value("SELECT GIATRI FROM QUYDINH WHERE TENQD = N'Tuổi tối thiểu'");

                if (max_age == -2 || min_age == -2)
                {
                    MessageBox.Show("Đã xảy ra lỗi kết nối !", "Lỗi");
                    return;
                }

                if (DateTime.Now.Year - ngaysinh.Year >= min_age
                    && DateTime.Now.Year - ngaysinh.Year <= max_age)
                {
                    int result;
                    switch (this.Text) {
                        case "Thêm Hồ Sơ":
                            result = DatabaseFunc.Insert("HOCSINH", list_Hocsinh);
                            if (result != 0)
                            {
                                MessageBox.Show("Thêm hồ sơ thành công !", "Thông báo");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Đã xảy ra lỗi kết nối !\nCập nhật hồ sơ thất bại");
                            }
                            break;

                        case "Sửa Hồ Sơ":

                            list_Hocsinh.Add(new CustomParam()
                            {
                                Key = "@MAHS",
                                Value = mahs,
                            });
                            result = DatabaseFunc.Update("HOCSINH", list_Hocsinh);
                            if (result != 0)
                            {
                                MessageBox.Show("Cập nhật hồ sơ thành công !", "Thông báo");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Đã xảy ra lỗi kết nối !\nCập nhật hồ sơ thất bại");
                                return;
                            }
                            break;
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show($"Tuổi không hợp lệ !\nTuổi phải từ {min_age} đến {max_age} theo quy định.");
                }
            }
        }

        private void Them_ho_so_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
