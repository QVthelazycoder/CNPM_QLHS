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
    public partial class Danh_sach_mon_hoc : Form
    {
        public Danh_sach_mon_hoc()
        {
            InitializeComponent();
        }

        private void Danh_sach_mon_hoc_Load(object sender, EventArgs e)
        {
            frm_Load(sender, e);
        }

        private void frm_Load(object sender, EventArgs e)
        {
            btn_Tim_Click(sender, e);
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
            // Nạp dữ liệu danh sách học sinh vào DataGridView từ SQL Server 
            dtg_Monhoc.DataSource = DatabaseFunc.Select("MONHOC", list);
            // Đặt tên cột cho DataGridView
            dtg_Monhoc.Columns["MAMON"].HeaderText = "Mã Môn";
            dtg_Monhoc.Columns["TENMON"].HeaderText = "Tên Môn";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var frm = new Them_mon_hoc(null);
            frm.Show();
            frm.FormClosing += delegate { this.frm_Load(sender, e); };
        }

        private void dtg_Monhoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamon = dtg_Monhoc.Rows[e.RowIndex].Cells["MAMON"].Value.ToString();
                var frm = new Them_mon_hoc(mamon);
                frm.ShowDialog();
                frm.FormClosing += delegate { this.frm_Load(sender, e); };
            }
            else return;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var cell = dtg_Monhoc.SelectedCells[0];
            if (cell.RowIndex >= 0)
            {
                switch (MessageBox.Show(this, "Bạn có chắc chắn muốn xóa môn học này không ?", "Xác Nhận Xóa", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        var tenmon = dtg_Monhoc.Rows[cell.RowIndex].Cells["TENMON"].Value.ToString();
                        List<CustomParam> list = new List<CustomParam>();
                        list.Add(new CustomParam()
                        {
                            Key = "@TENMON",
                            Value = tenmon
                        });
                        int result = DatabaseFunc.Delete("MONHOC", list);
                        if (result != 0)
                        {
                            MessageBox.Show("Xoá môn học thành công !", "Thông báo");
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi !\nXoá môn học thất bại !", "Thông báo");
                        this.frm_Load(sender, e);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại môn học !", "Lỗi");
            }
        }

        private void btn_Tailai_Click(object sender, EventArgs e)
        {
            this.frm_Load(sender, e);
        }

    }
}
