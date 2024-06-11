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
    public partial class Danh_sach_khoi_lop : Form
    {
        DataTable dt;

        public Danh_sach_khoi_lop()
        {
            InitializeComponent();
        }


        private void Danh_sach_khoi_lop_Load(object sender, EventArgs e)
        {
            frm_Load();
        }

        private void frm_Load()
        {
            List<CustomParam> list = new List<CustomParam>();
            list.Add(new CustomParam()
            {
                Key = "@PARAM",
                Value = "%",
            });
            dt = DatabaseFunc.Select("LOP", list);
            dtg_Khoilop.DataSource = dt;

            dtg_Khoilop.Columns["TENLOP"].HeaderText = "Lớp";
            dtg_Khoilop.Columns["MAKHOI"].HeaderText = "Mã Khối";
            dtg_Khoilop.Columns["SISO"].HeaderText = "Sĩ Số";

            int sisotoida = (int)DatabaseFunc.Select_Value("SELECT GIATRI FROM QUYDINH WHERE MAQD = 'QD03'");
            if (sisotoida == -1 || sisotoida == -2)
            {
                return;
            }
            else 
                nud_Sisotoida.Value = sisotoida;
        }

        // Cài đặt nút Thêm bên cạnh thanh tìm kiếm
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them_khoi_lop f = new Them_khoi_lop(null);
            f.ShowDialog();
            if (f.IsDisposed)
            {
                frm_Load();
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
                Value = (String.IsNullOrEmpty(search_str) ? "%" : search_str),
            });
            dt = DatabaseFunc.Select("LOP", list);
            dtg_Khoilop.DataSource = dt;

            dtg_Khoilop.Columns["TENLOP"].HeaderText = "Lớp";
            dtg_Khoilop.Columns["MAKHOI"].HeaderText = "Mã Khối";
            dtg_Khoilop.Columns["SISO"].HeaderText = "Sĩ Số";
        }

        // Cài đặt nút Xóa bên cạnh thanh tìm kiếm
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var cell = dtg_Khoilop.SelectedCells[0];
            if (cell.RowIndex >= 0)
            {
                var lop = dtg_Khoilop.Rows[cell.RowIndex].Cells["TENLOP"].Value.ToString();
                if (String.IsNullOrEmpty(lop))
                {
                    MessageBox.Show("Học sinh này chưa được xếp lớp !", "Lỗi");
                    return;
                }
                else
                {
                    switch (MessageBox.Show(this, $"Bạn có chắc chắn muốn xóa lớp {lop} không ?", "Xác Nhận Xóa", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            var tenlop = dtg_Khoilop.Rows[cell.RowIndex].Cells["TENLOP"].Value.ToString();
                            List<CustomParam> list = new List<CustomParam>();
                            list.Add(new CustomParam()
                            {
                                Key = "@TENLOP",
                                Value = tenlop,
                            });
                            int result = DatabaseFunc.Delete("LOP", list);
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
            frm_Load();
        }

        private void dtg_Ds_Lop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var tenlop = dtg_Khoilop.Rows[e.RowIndex].Cells["TENLOP"].Value.ToString();
                var frm = new Them_khoi_lop(tenlop);
                frm.ShowDialog();
                frm.FormClosing += delegate { this.frm_Load(); };
            }
            else return;
        }

        private void btn_Thaydoi_Click(object sender, EventArgs e)
        {
            int sisotoida = (int)nud_Sisotoida.Value;
            List<CustomParam> list = new List<CustomParam>();
            list.Add(new CustomParam()
            {
                Key = "@MAQD",
                Value = "QD03",
            });
            list.Add(new CustomParam()
            {
                Key = "@GIATRI",
                Value = sisotoida,
            });
            int result = DatabaseFunc.Update("QUYDINH", list);
            if (result == 0)
            {
                MessageBox.Show("Đã xảy ra lỗi !", "Lỗi");
            }
            else
            {
                MessageBox.Show("Cập nhật sĩ số tối đa thành công !", "Thông báo");
            }
        }
    }
}
