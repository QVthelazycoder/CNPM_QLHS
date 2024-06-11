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
    public partial class Bang_diem_mon : Form
    {
        DataTable dt;
        private readonly int taikhoan;
        public Bang_diem_mon(int taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
        }

        private void Bang_diem_mon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mONHOC_DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOC_TableAdapter.Fill(this.MONHOC_DataSet.MONHOC);
            // TODO: This line of code loads data into the 'my_ApplicationDataSet.LOP' table. You can move, or remove it, as needed.
            this.LOP_TableAdapter.Fill(this.LOP_DataSet.LOP);
            cbb_Hocky.SelectedIndex = 0;
            frm_Load();
        }

        private void frm_Load()
        {
            btn_Timbangdiem_Click(new object(), new EventArgs());
            switch (this.taikhoan)
            {
                // Ban Giám Hiệu chỉ được xem bảng điểm, không chỉnh sửa
                case 0:
                    txt_Hoten.ReadOnly = true;
                    txt_STT.ReadOnly = true;
                    txt_Diem15.ReadOnly = true;
                    txt_Diem1T.ReadOnly = true;
                    txt_DiemTB.ReadOnly = true;
                    btn_Luu.Enabled = false;
                    break;
                // Giáo viên được chỉnh sửa bảng điểm
                case 1:
                    txt_Hoten.ReadOnly = false;
                    txt_STT.ReadOnly = false;
                    txt_Diem15.ReadOnly = false;
                    txt_Diem1T.ReadOnly = false;
                    txt_DiemTB.ReadOnly = false;
                    btn_Luu.Enabled = true;
                    break;
                // Admin được toàn quyền chỉnh sửa và xem báo cáo
                default:
                    txt_Hoten.ReadOnly = false;
                    txt_STT.ReadOnly = false;
                    txt_Diem15.ReadOnly = false;
                    txt_Diem1T.ReadOnly = false;
                    txt_DiemTB.ReadOnly = false;
                    btn_Luu.Enabled = true;
                    break;
            }
        }


        private void txt_Hoten_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Hoten.Text))
            {
                StatusLabel_Hoten.Visible = true;
            }
            else
            {
                StatusLabel_Hoten.Visible = false;
            }
        }

        private void txt_Hoten_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_Hoten.Text))
            {
                StatusLabel_Hoten.Visible = false;
            }
            else
                StatusLabel_Hoten.Visible = true;
        }

        private void txt_STT_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_STT.Text))
            {
                StatusLabel_STT.Visible = true;
            }
            else
            {
                StatusLabel_STT.Visible = false;
            }
        }

        private void txt_STT_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_STT.Text))
            {
                StatusLabel_STT.Visible = false;
            }
            else
            {
                if (!int.TryParse(txt_STT.Text.ToString(), out int result) || result <= 0)
                {
                    StatusLabel_Diem15.Text = "Giá trị nhập không hợp lệ !";
                    StatusLabel_Diem15.Visible = true;
                }
                else
                    StatusLabel_STT.Visible = true;
            }
        }


        private void txt_Diem15_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Diem15.Text))
            {
                StatusLabel_Diem15.Visible = true;
            }
            else
            {
                if (!double.TryParse(txt_Diem15.Text.ToString(), out double result))
                {
                    StatusLabel_Diem15.Text = "Giá trị nhập không hợp lệ !";
                    StatusLabel_Diem15.Visible = true;
                }
                else
                {
                    if (result < 0 || result > 10)
                    {
                        StatusLabel_Diem15.Text = "Điểm phải từ 0 đến 10";
                        StatusLabel_Diem15.Visible = true;
                    }
                    else
                    {
                        StatusLabel_Diem15.Visible = false;
                    }
                }
            }
        }

        private void txt_Diem15_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_Diem15.Text))
            {
                StatusLabel_Diem15.Visible = false;
            }
            else
                StatusLabel_Diem15.Visible = true;
        }


        private void txt_Diem1T_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Diem1T.Text))
            {
                StatusLabel_Diem1T.Visible = true;
            }
            else
            {
                if (!double.TryParse(txt_Diem1T.Text.ToString(), out double result))
                {
                    StatusLabel_Diem1T.Text = "Giá trị nhập không hợp lệ !";
                    StatusLabel_Diem1T.Visible = true;
                }
                else
                {
                    if (result < 0 || result > 10)
                    {
                        StatusLabel_Diem1T.Text = "Điểm phải từ 0 đến 10";
                        StatusLabel_Diem1T.Visible = true;
                    }
                    else
                    {
                        StatusLabel_Diem1T.Visible = false;
                    }
                }
            }
        }

        private void txt_Diem1T_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_Diem1T.Text))
            {
                StatusLabel_Diem1T.Visible = false;
            }
            else
                StatusLabel_Diem1T.Visible = true;
        }


        private void txt_DiemTB_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Diem1T.Text))
            {
                StatusLabel_DiemTB.Visible = true;
            }
            else
            {
                if (!double.TryParse(txt_DiemTB.Text.ToString(), out double result))
                {
                    StatusLabel_DiemTB.Text = "Giá trị nhập không hợp lệ !";
                    StatusLabel_DiemTB.Visible = true;
                }
                else
                {
                    if (result < 0 || result > 10)
                    {
                        StatusLabel_DiemTB.Text = "Điểm phải từ 0 đến 10";
                        StatusLabel_DiemTB.Visible = true;
                    }
                    else
                    {
                        StatusLabel_DiemTB.Visible = false;
                    }
                }
            }
        }

        private void txt_DiemTB_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_DiemTB.Text))
            {
                StatusLabel_DiemTB.Visible = false;
            }
            else
                StatusLabel_DiemTB.Visible = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txt_Hoten.Text)) || String.IsNullOrEmpty(txt_STT.Text))
            {
                MessageBox.Show("Bạn cần hoàn thiện các thông tin !", "Thông báo");
                return;
            }
            else if ((!double.TryParse(txt_Diem15.Text, out double diem15) && !String.IsNullOrEmpty(txt_Diem15.Text)) || (!double.TryParse(txt_Diem1T.Text, out double diem1T) && !String.IsNullOrEmpty(txt_Diem1T.Text)) ||
                (!double.TryParse(txt_DiemTB.Text, out double diemTB) && !String.IsNullOrEmpty(txt_DiemTB.Text)))
            {
                MessageBox.Show("Giá trị nhập không hợp lệ !", "Lỗi");
                return;
            }
            else if ((diem15 < 0 || diem15 >10) || (diem1T < 0 || diem1T > 10) || (diemTB < 0 || diemTB > 10))
            {
                MessageBox.Show("Điểm bạn nhập phải nằm trong khoảng từ 0 đến 10 !", "Lỗi");
                return;
            }
            else
            {
                // Kiểm tra tên học sinh và STT có trùng khớp hay không
                string hoten = txt_Hoten.Text;
                var tenlop = cbb_Chonlop.Text;
                string cmd = "SELECT STT FROM XEPLOP JOIN HOCSINH " +
                             "ON XEPLOP.MAHS = HOCSINH.MAHS " +
                             $"WHERE TENLOP = '{tenlop}' AND " +
                             $"(UPPER(CONCAT(HO, ' ', TEN)) LIKE UPPER(N'%' + N'{hoten}') " +
                             $"OR UPPER(CONCAT(HO, ' ', DEM, ' ', TEN)) LIKE UPPER(N'%' + N'{hoten}'))";
                int stt_check = (int)DatabaseFunc.Select_Value(cmd);
                if (stt_check == -2)
                {
                    MessageBox.Show("Đã xảy ra lỗi kết nối !");
                    return;
                }
                string stt = txt_STT.Text;
                if (!String.Equals(stt, stt_check.ToString()))
                {
                    MessageBox.Show("Tên học sinh và STT không trùng khớp !", "Thông báo");
                    return;
                }

                // Kiểm tra STT người dùng nhập có trong bảng hay không.
                // Nếu không tồn tại STT trong bảng tức là học sinh chưa được nhập điểm => Insert 
                // Ngược lại => Update
                bool valueExists = dtg_Bangdiem.Rows.Cast<DataGridViewRow>().Any(row => row.Cells["STT"].Value?.ToString() == stt);

                var tenmon = cbb_Monhoc.Text;
                var hocky = cbb_Hocky.Text;
                List<CustomParam> list = new List<CustomParam>();
                list.Add(new CustomParam()
                {
                    Key = "@TENLOP",
                    Value = tenlop
                });
                list.Add(new CustomParam()
                {
                    Key = "@TENMON",
                    Value = tenmon
                });
                list.Add(new CustomParam()
                {
                    Key = "@HOCKY",
                    Value = hocky
                });
                list.Add(new CustomParam()
                {
                    Key = "@STT",
                    Value = stt
                });
                list.Add(new CustomParam()
                {
                    Key = "@DIEM15",
                    Value = diem15
                });
                list.Add(new CustomParam()
                {
                    Key = "@DIEM1T",
                    Value = diem1T
                });
                list.Add(new CustomParam()
                {
                    Key = "@DIEMTB",
                    Value = diemTB
                });

                if (valueExists)
                {
                    int result = DatabaseFunc.Update("BANGDIEM_MONHOC", list);
                    if (result != 0)
                    {
                        frm_Load();
                        MessageBox.Show("Cập nhật điểm thành công !", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi !\nCập nhật điểm thất bại !", "Thông báo");
                    }
                }
                else
                {
                    int result = DatabaseFunc.Insert("BANGDIEM_MONHOC", list);
                    if (result != 0)
                    {
                        frm_Load();
                        MessageBox.Show("Nhập điểm thành công !", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi !\nNhập điểm thất bại !", "Thông báo");
                    }
                }
            }
        }

        private void dtg_Bangdiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_Hoten.Text = dtg_Bangdiem.Rows[e.RowIndex].Cells["HOTEN"].Value.ToString();
                txt_STT.Text = dtg_Bangdiem.Rows[e.RowIndex].Cells["STT"].Value.ToString();
                txt_Diem15.Text = dtg_Bangdiem.Rows[e.RowIndex].Cells["DIEM_15P"].Value.ToString();
                txt_Diem1T.Text = dtg_Bangdiem.Rows[e.RowIndex].Cells["DIEM_1T"].Value.ToString();
                txt_DiemTB.Text = dtg_Bangdiem.Rows[e.RowIndex].Cells["DIEM_TB"].Value.ToString();
            }
            else return;
        }

        private void cbb_Chonlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Timbangdiem_Click(sender, e);
        }

        private void cbb_Hocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Timbangdiem_Click(sender, e);
        }

        private void cbb_Monhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Timbangdiem_Click(sender, e);
        }

        private void btn_Timbangdiem_Click(object sender, EventArgs e)
        {
            var tenlop = cbb_Chonlop.Text;
            var mon = cbb_Monhoc.Text;
            var hocky = cbb_Hocky.Text;
            var hoten = txt_Hoten.Text;
            List<CustomParam> list = new List<CustomParam>();
            list.Add(new CustomParam()
            {
                Key = "@TENLOP",
                Value = tenlop,
            });
            list.Add(new CustomParam()
            {
                Key = "@TENMON",
                Value = mon,
            });
            list.Add(new CustomParam()
            {
                Key = "@HOCKY",
                Value = hocky,
            });
            dt = DatabaseFunc.Select("BANGDIEM_MONHOC", list);
            dtg_Bangdiem.DataSource = dt;
            dtg_Bangdiem.Columns["STT"].HeaderText = "STT";
            dtg_Bangdiem.Columns["HOTEN"].HeaderText = "Họ Tên";
            dtg_Bangdiem.Columns["DIEM_15P"].HeaderText = "Điểm 15p";
            dtg_Bangdiem.Columns["DIEM_1T"].HeaderText = "Điểm 1T";
            dtg_Bangdiem.Columns["DIEM_TB"].HeaderText = "Điểm TB";
            dtg_Bangdiem.Columns["TENMON"].Visible = false;
            dtg_Bangdiem.Columns["HOCKY"].Visible = false;
            dtg_Bangdiem.Columns["TENLOP"].Visible = false;
        }
    }
}
