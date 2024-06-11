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
    public partial class Bao_cao_Mon : Form
    {
        private readonly int taikhoan;
        // dt_Bangdiem dùng để hiển thị bảng điểm của mỗi lớp trên DataGridView
        DataTable dt_Bangdiem;
        // dt_Baocao dùng để hiển thị dữ liệu báo cáo (sĩ số, số lượng đạt, tỉ lệ)
        DataTable dt_Baocao;
        public Bao_cao_Mon(int taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
        }

        private void Bao_cao_Mon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mONHOC_DataSet.MONHOC' table.You can move, or remove it, as needed.
            this.MONHOC_TableAdapter.Fill(this.MONHOC_DataSet.MONHOC);
            // TODO: This line of code loads data into the 'my_ApplicationDataSet.LOP' table. You can move, or remove it, as needed.
            this.LOP_TableAdapter.Fill(this.LOP_DataSet.LOP);
            frm_Load();
        }

        void frm_Load()
        {
            cbb_Hocky.SelectedIndex = 0;
            btn_Xembangdiem_Click(new object(), new EventArgs());
            switch (this.taikhoan)
            {
                // Ban Giám Hiệu chỉ được xem báo cáo môn học, không chỉnh sửa
                case 0:
                    txt_Siso.ReadOnly = true;
                    txt_Soluongdat.ReadOnly = true;
                    txt_Tile.ReadOnly = true;
                    btn_Luu.Enabled = false;
                    btn_Xembaocao.Visible = true;
                    break;
                // Giáo viên được chỉnh sửa báo cáo môn học
                case 1:
                    txt_Siso.ReadOnly = false;
                    txt_Soluongdat.ReadOnly = false;
                    txt_Tile.ReadOnly = false;
                    btn_Luu.Enabled = true;
                    btn_Xembaocao.Visible = false;
                    btn_Xembangdiem.Visible = false;
                    break;
                // Admin được toàn quyền chỉnh sửa và xem báo cáo
                default:
                    txt_Siso.ReadOnly = false;
                    txt_Soluongdat.ReadOnly = false;
                    txt_Tile.ReadOnly = false;
                    btn_Luu.Enabled = true;
                    btn_Xembaocao.Visible = true;
                    btn_Xembangdiem.Visible = true;
                    break;
            }
        }

        private void cbb_Chonlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtg_Bangdiem.DataSource == dt_Bangdiem)
            {
                btn_Xembangdiem_Click(sender, e);
            }
            else
                btn_Xembaocao_Click(sender, e);

            textbox_SetText();
        }

        private void cbb_Monhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtg_Bangdiem.DataSource == dt_Bangdiem)
            {
                btn_Xembangdiem_Click(sender, e);
            }
            else
                btn_Xembaocao_Click(sender, e);

            textbox_SetText();
        }

        private void cbb_Hocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtg_Bangdiem.DataSource == dt_Bangdiem)
            {
                btn_Xembangdiem_Click(sender, e);
            }
            else
                btn_Xembaocao_Click(sender, e);

            textbox_SetText();
        }

        private void textbox_SetText()
        {
            var tenmon = cbb_Monhoc.Text;
            string tenlop = cbb_Chonlop.Text;
            var hocky = cbb_Hocky.Text;

            List<CustomParam> list = new List<CustomParam>();
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
                Key = "@TENLOP",
                Value = "%"
            });
            dt_Baocao = DatabaseFunc.Select("BAOCAO_MONHOC", list);
            try
            {
                txt_Siso.Text = dt_Baocao.Rows[0]["SISO"].ToString();
                txt_Soluongdat.Text = dt_Baocao.Rows[0]["SL_DAT"].ToString();
                txt_Tile.Text = dt_Baocao.Rows[0]["TI_LE"].ToString();
            }
            catch (Exception)
            {
                txt_Siso.Text = null;
                txt_Soluongdat.Text = null;
                txt_Tile.Text = null;
            }
        }

        private void txt_Siso_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Siso.Text))
            {
                StatusLabel_Siso.Text = "Vui lòng nhập sĩ số lớp !";
                StatusLabel_Siso.Visible = true;
            }
            else
            {
                if (!int.TryParse(txt_Siso.Text.ToString(), out int result) || result <= 0)
                {
                    StatusLabel_Siso.Text = "Giá trị nhập không hợp lệ !\nSĩ số phải là số nguyên dương !";
                    StatusLabel_Siso.Visible = true;
                }
                else
                {
                    StatusLabel_Siso.Visible = false;
                    // Sau khi nhập sĩ số lớp, hệ thống sẽ tự động tính số học sinh có ĐTB môn >= điểm đạt môn theo quy định
                    var tenlop = cbb_Chonlop.Text;
                    var tenmon = cbb_Monhoc.Text;
                    var hocky = cbb_Hocky.Text;
                    int datmon = (int)DatabaseFunc.Select_Value("SELECT GIATRI FROM QUYDINH WHERE MAQD = 'QD08'");
                    string cmd = $"SELECT COUNT(*) FROM BANGDIEM_MONHOC " +
                        $"WHERE TENLOP = '{tenlop}' AND TENMON = N'{tenmon}' AND HOCKY = '{hocky}' AND DIEM_TB >= {datmon}" +
                        $"GROUP BY TENLOP, TENMON, HOCKY";
                    int sl_dat = (int)DatabaseFunc.Select_Value(cmd);
                    txt_Soluongdat.Text = ((sl_dat == -1) ? 0 : sl_dat).ToString();
                }
            }
        }

        private void txt_Siso_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_Siso.Text))
            {
                StatusLabel_Siso.Visible = false;
            }
            else if (txt_Siso.ReadOnly == true)
            {
                StatusLabel_Siso.Visible = false;
            }
            else
                StatusLabel_Siso.Visible = true;
        }

        private void txt_Soluongdat_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Soluongdat.Text))
            {
                StatusLabel_Soluongdat.Text = "Vui lòng nhập số lượng học sinh đạt !";
                StatusLabel_Soluongdat.Visible = true;
            }
            else
            {
                if (!int.TryParse(txt_Soluongdat.Text, out int result) || result <= 0)
                {
                    StatusLabel_Soluongdat.Text = "Giá trị nhập không hợp lệ !\nSố lượng học sinh đạt phải là số nguyên dương !";
                    StatusLabel_Soluongdat.Visible = true;
                }
                else if (int.TryParse(txt_Siso.Text, out int siso) && result > siso)
                {
                    StatusLabel_Soluongdat.Text = "Số lượng học sinh đạt môn không được lớn hơn sĩ số !";
                    StatusLabel_Soluongdat.Visible = true;
                }
                else
                {
                    StatusLabel_Soluongdat.Visible = false;
                    Calculate_Tile();
                }
            }
        }

        private void txt_Soluongdat_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_Siso.Text))
            {
                StatusLabel_Soluongdat.Visible = false;
            }
            else if (txt_Soluongdat.ReadOnly == true)
            {
                StatusLabel_Siso.Visible = false;
            }
            else
                StatusLabel_Soluongdat.Visible = true;
        }


        private void txt_Tile_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Tile.Text))
            {
                StatusLabel_Tile.Text = "Vui lòng nhập tỉ lệ !";
                StatusLabel_Tile.Visible = true;
            }
            else
            {
                if (!double.TryParse(txt_Tile.Text, out double result) || result < 0 || result > 100)
                {
                    StatusLabel_Tile.Text = "Giá trị nhập không hợp lệ !\nTỉ lệ đạt phải là số dương trong khoảng từ 0 đến 100 !";
                    StatusLabel_Tile.Visible = true;
                }
                else
                {
                    StatusLabel_Tile.Visible = false;
                }
            }

        }

        private void Calculate_Tile()
        {
            if (!String.IsNullOrEmpty(txt_Siso.Text) && !String.IsNullOrEmpty(txt_Soluongdat.Text)
                && StatusLabel_Siso.Visible == false && StatusLabel_Siso.Visible == false)
            {
                try
                {
                    int siso = int.Parse(txt_Siso.Text);
                    int sldat = int.Parse(txt_Soluongdat.Text);
                    float tile = (float)sldat / siso * 100;
                    txt_Tile.Text = tile.ToString("F1");
                }
                catch (DivideByZeroException)
                {
                    return;
                    throw;
                }
                catch (FormatException) 
                {
                    txt_Tile.Text = null;
                    return;
                }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txt_Siso.Text)) || (String.IsNullOrEmpty(txt_Soluongdat.Text)) ||
                (String.IsNullOrEmpty(txt_Tile.Text)))
            {
                MessageBox.Show("Bạn cần hoàn thiện các thông tin !", "Thông báo");
                return;
            }
            else if (!int.TryParse(txt_Siso.Text, out int siso) || !int.TryParse(txt_Soluongdat.Text, out int sldat) || 
                !double.TryParse(txt_Tile.Text, out double tile)) {
                MessageBox.Show("Giá trị nhập không hợp lệ !", "Lỗi");
                return;
            }
            else if (siso < sldat)
            {
                MessageBox.Show("Số lượng học sinh đạt không được lớn hơn sĩ số lớp !", "Lỗi");
                return;
            }
            else if (tile < 0 || tile > 100)
            {
                MessageBox.Show("Tỉ lệ đạt phải là số dương trong khoảng từ 0 đến 100 !", "Lỗi");
                return;
            }
            else
            {
                var tenmon = cbb_Monhoc.Text;
                var tenlop = cbb_Chonlop.Text;
                var hocky = cbb_Hocky.Text;
                
                List<CustomParam> list = new List<CustomParam>();
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
                    Key = "@TENLOP",
                    Value = tenlop
                });

                DataTable test = DatabaseFunc.Select("BAOCAO_MONHOC", list);
                
                list.Add(new CustomParam()
                {
                    Key = "@SISO",
                    Value = siso
                });
                list.Add(new CustomParam()
                {
                    Key = "@SL_DAT",
                    Value = sldat
                });
                list.Add(new CustomParam()
                {
                    Key = "@TI_LE",
                    Value = tile
                });

                if (test.Rows.Count == 0)
                {
                    int result = DatabaseFunc.Insert("BAOCAO_MONHOC", list);
                    if (result == 0)
                    {
                        MessageBox.Show("Đã xảy ra lỗi kết nối !", "Lỗi");
                    }
                    else
                    {
                        MessageBox.Show("Lưu báo cáo thành công !", "Thông báo");
                    }
                }
                else
                {
                    int result = DatabaseFunc.Update("BAOCAO_MONHOC", list);
                    if (result == 0)
                    {
                        MessageBox.Show("Đã xảy ra lỗi kết nối !", "Lỗi");
                    }
                    else
                    {
                        MessageBox.Show("Lưu báo cáo thành công !", "Thông báo");
                    }
                }
            }
        }

        private void btn_Xembangdiem_Click(object sender, EventArgs e)
        {
            var tenlop = cbb_Chonlop.Text;
            var tenmon = cbb_Monhoc.Text;
            var hocky = cbb_Hocky.Text;
            List<CustomParam> list = new List<CustomParam>();
            list.Add(new CustomParam()
            {
                Key = "@TENLOP",
                Value = tenlop,
            });
            list.Add(new CustomParam()
            {
                Key = "@TENMON",
                Value = tenmon,
            });
            list.Add(new CustomParam()
            {
                Key = "@HOCKY",
                Value = hocky,
            });
            dt_Bangdiem = DatabaseFunc.Select("BANGDIEM_MONHOC", list);
            dtg_Bangdiem.DataSource = dt_Bangdiem;
            dtg_Bangdiem.Columns["STT"].HeaderText = "STT";
            dtg_Bangdiem.Columns["HOTEN"].HeaderText = "Họ Tên";
            dtg_Bangdiem.Columns["DIEM_15P"].HeaderText = "Điểm 15p";
            dtg_Bangdiem.Columns["DIEM_1T"].HeaderText = "Điểm 1T";
            dtg_Bangdiem.Columns["DIEM_TB"].HeaderText = "Điểm TB";
            dtg_Bangdiem.Columns["TENMON"].Visible = false;
            dtg_Bangdiem.Columns["HOCKY"].Visible = false;
            dtg_Bangdiem.Columns["TENLOP"].Visible = false;
            dtg_Bangdiem.Columns["MAHS"].Visible = false;


            textbox_SetText();
        }

        private void btn_Xembaocao_Click(object sender, EventArgs e)
        {
            var lop = cbb_Chonlop.Text;
            var mon = cbb_Monhoc.Text;
            var hocky = cbb_Hocky.Text;
            List<CustomParam> list = new List<CustomParam>();
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
            list.Add(new CustomParam()
            {
                Key = "@TENLOP",
                Value = "%",
            });
            dt_Baocao = DatabaseFunc.Select("BAOCAO_MONHOC", list);
            dtg_Bangdiem.DataSource = dt_Baocao;

            dtg_Bangdiem.Columns["TENMON"].HeaderText = "Môn";
            dtg_Bangdiem.Columns["HOCKY"].HeaderText = "Học Kỳ";
            dtg_Bangdiem.Columns["TENLOP"].HeaderText = "Lớp";
            dtg_Bangdiem.Columns["SISO"].HeaderText = "Sĩ Số";
            dtg_Bangdiem.Columns["SL_DAT"].HeaderText = "Số Lượng Đạt";
            dtg_Bangdiem.Columns["TI_LE"].HeaderText = "Tỉ Lệ";
            dtg_Bangdiem.Columns["TENMON"].Visible = true;
            dtg_Bangdiem.Columns["HOCKY"].Visible = true;
            dtg_Bangdiem.Columns["TENLOP"].Visible = true;

            textbox_SetText();
        }
    }
}
