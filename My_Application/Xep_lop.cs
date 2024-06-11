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
    public partial class Xep_lop : Form
    {
        DataTable dt;

        public Xep_lop()
        {
            InitializeComponent();
        }

        private void Xep_lop_Load(object sender, EventArgs e)
        {
            frm_Load(sender, e);
        }

        private void frm_Load(object sender, EventArgs e)
        {
            List<CustomParam> list = new List<CustomParam>();
            list.Add(new CustomParam()
            {
                Key = "@PARAM",
                Value = "%",
            });
            dt = DatabaseFunc.Select("HOCSINH", list);
            dtg_DsLop.DataSource = dt;

            dtg_DsLop.Columns["TENLOP"].HeaderText = "Lớp";
            dtg_DsLop.Columns["STT"].HeaderText = "STT";
            dtg_DsLop.Columns["HOTEN"].HeaderText = "Họ và Tên";
            dtg_DsLop.Columns["GIOITINH"].HeaderText = "Giới Tính";
            dtg_DsLop.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dtg_DsLop.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dtg_DsLop.Columns["MAHS"].Visible = false;
            dtg_DsLop.Columns["EMAIL"].Visible = false;
        }

        // Cài đặt nút Thêm bên cạnh thanh tìm kiếm
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them_ds_lop f = new Them_ds_lop();
            f.ShowDialog();
            if (f.IsDisposed)
            {
                frm_Load(sender, e);
            }
        }

        // Cài đặt nút Tìm bên cạnh thanh tìm kiếm
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            var search_str = txt_Tim.Text;
            List<CustomParam> list = new List<CustomParam>();
            list.Add(new CustomParam()
            {
                Key = "@PARAM",
                Value = search_str,
            });
            dt = DatabaseFunc.Select("HOCSINH", list);
            dtg_DsLop.DataSource = dt;

            dtg_DsLop.Columns["TENLOP"].HeaderText = "Lớp";
            dtg_DsLop.Columns["MAHS"].HeaderText = "Mã HS";
            dtg_DsLop.Columns["HOTEN"].HeaderText = "Họ và Tên";
            dtg_DsLop.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dtg_DsLop.Columns["GIOITINH"].HeaderText = "Giới Tính";
            dtg_DsLop.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dtg_DsLop.Columns["EMAIL"].Visible = false;
        }

        // Cài đặt nút Xóa bên cạnh thanh tìm kiếm
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var cell = dtg_DsLop.SelectedCells[0];
            if (cell.RowIndex >= 0)
            {
                var lop = dtg_DsLop.Rows[cell.RowIndex].Cells["TENLOP"].Value.ToString();
                if (String.IsNullOrEmpty(lop))
                {
                    MessageBox.Show("Học sinh này chưa được xếp lớp !", "Lỗi");
                    return;
                }
                else
                {
                    switch (MessageBox.Show(this, $"Bạn có chắc chắn muốn xóa học sinh này khỏi lớp {lop} không ?", "Xác Nhận Xóa", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            var mahs = dtg_DsLop.Rows[cell.RowIndex].Cells["MAHS"].Value.ToString();
                            var stt = dtg_DsLop.Rows[cell.RowIndex].Cells["STT"].Value.ToString();
                            var tenlop = dtg_DsLop.Rows[cell.RowIndex].Cells["TENLOP"].Value.ToString();
                            List<CustomParam> list = new List<CustomParam>();
                            list.Add(new CustomParam()
                            {
                                Key = "@MAHS",
                                Value = mahs,
                            });
                            list.Add(new CustomParam()
                            {
                                Key = "@TENLOP",
                                Value = tenlop,
                            });
                            int result = DatabaseFunc.Delete("XEPLOP", list);
                            if (result == 0)
                            {
                                MessageBox.Show("Đã xảy ra lỗi !", "Lỗi");
                            }
                            else
                            {
                                MessageBox.Show("Xóa thành công !", "Thông báo");
                            }
                            btn_Tim_Click(new object(), new EventArgs());
                            break;
                        default:
                            break;
                    }
                }
            }
            else return;
        }

        // Cài đặt nút Tải lại bên cạnh thanh tìm kiếm
        private void btn_Tailai_Click(object sender, EventArgs e)
        {
            frm_Load(sender, e);
        }
    }
}
