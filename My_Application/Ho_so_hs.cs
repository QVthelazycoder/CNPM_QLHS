using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Application;

namespace My_Application
{
    public partial class Ho_so_hs : Form
    {
        DataTable dt;
        string con = DatabaseFunc.GetStringCon();

        public Ho_so_hs()
        {
            InitializeComponent();
            Ho_so_hs_Load(new object(), new EventArgs());
        }

        private void Ho_so_hs_Load(object sender, EventArgs e)
        {
            frm_Load();
        }


        protected void frm_Load()
        {
            List<CustomParam> list = new List<CustomParam>();
            list.Add(new CustomParam()
            {
                Key = "@PARAM",
                Value = "%",
            });
            // Nạp dữ liệu danh sách học sinh vào DataGridView từ SQL Server 
            dtg_Hosohs.DataSource = DatabaseFunc.Select("HOCSINH", list);
            // Đặt tên cột cho DataGridView
            dtg_Hosohs.Columns["MAHS"].HeaderText = "Mã HS";
            dtg_Hosohs.Columns["HOTEN"].HeaderText = "Họ và Tên";
            dtg_Hosohs.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dtg_Hosohs.Columns["GIOITINH"].HeaderText = "Giới Tính";
            dtg_Hosohs.Columns["EMAIL"].HeaderText = "Email";
            dtg_Hosohs.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dtg_Hosohs.Columns["TENLOP"].Visible = false;
            dtg_Hosohs.Columns["STT"].Visible = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var f = new Them_ho_so(null);
            f.Show();
            if (f.IsDisposed)
            {
                frm_Load();
            }
        }

        private void dtg_Hosohs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mahs = dtg_Hosohs.Rows[e.RowIndex].Cells["MAHS"].Value.ToString();
                var frm = new Them_ho_so(mahs);
                frm.ShowDialog();
                frm.FormClosing += delegate { this.frm_Load(); };
            }
            else return;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var cell = dtg_Hosohs.SelectedCells[0];
            if (cell.RowIndex >= 0)
            {
                switch (MessageBox.Show(this, "Bạn có chắc chắn muốn xóa học sinh này không ?", "Xác Nhận Xóa", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        var mahs = dtg_Hosohs.Rows[cell.RowIndex].Cells["MAHS"].Value.ToString();
                        List<CustomParam> list = new List<CustomParam>();
                        list.Add(new CustomParam()
                        {
                            Key = "@MAHS",
                            Value = mahs
                        });
                        int result = DatabaseFunc.Delete("HOCSINH", list);
                        if (result != 0)
                        {
                            MessageBox.Show("Xoá học sinh thành công !", "Thông báo");
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi kết nối !\nXoá học sinh thất bại !", "Thông báo");
                        this.frm_Load();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại học sinh !", "Lỗi");
            }
        }

        private void btn_Tailai_Click(object sender, EventArgs e)
        {
            this.frm_Load();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            var search_str = (String.IsNullOrEmpty(txt_Tim.Text) ? "%" : txt_Tim.Text);
            List<CustomParam> list = new List<CustomParam>();
            list.Add(new CustomParam()
            {
                Key = "@PARAM",
                Value = search_str,
            });
            dt = DatabaseFunc.Select("HOCSINH", list);
            dtg_Hosohs.DataSource = dt;

            dtg_Hosohs.Columns["MAHS"].HeaderText = "Mã HS";
            dtg_Hosohs.Columns["HOTEN"].HeaderText = "Họ và Tên";
            dtg_Hosohs.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dtg_Hosohs.Columns["GIOITINH"].HeaderText = "Giới Tính";
            dtg_Hosohs.Columns["EMAIL"].HeaderText = "Email";
            dtg_Hosohs.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dtg_Hosohs.Columns["TENLOP"].Visible = false;
            dtg_Hosohs.Columns["STT"].Visible = false;
        }
    }
}
