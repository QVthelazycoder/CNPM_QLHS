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
    public partial class Them_ds_lop : Form
    {
        DataTable dt;
        public Them_ds_lop()
        {
            InitializeComponent();
        }

        private void Them_ds_lop_Load(object sender, EventArgs e)
        {
            frm_Load();
        }

        private void frm_Load()
        {
            // TODO: This line of code loads data into the 'my_ApplicationDataSet.LOP' table. You can move, or remove it, as needed.
            this.LOP_TableAdapter.Fill(this.LOP_DataSet.LOP);

            List<CustomParam> list = new List<CustomParam>();
            list.Add(new CustomParam()
            {
                Key = "@PARAM",
                Value = "%",
            });
            dt = DatabaseFunc.Select("HOCSINH", list);
            dtg_Hosohs.DataSource = dt;

            dtg_Hosohs.Columns["TENLOP"].HeaderText = "Lớp";
            dtg_Hosohs.Columns["MAHS"].HeaderText = "Mã HS";
            dtg_Hosohs.Columns["HOTEN"].HeaderText = "Họ và Tên";
            dtg_Hosohs.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dtg_Hosohs.Columns["GIOITINH"].HeaderText = "Giới Tính";
            dtg_Hosohs.Columns["EMAIL"].HeaderText = "Email";
            dtg_Hosohs.Columns["DIACHI"].HeaderText = "Địa Chỉ";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            if (dtg_Hosohs.Rows.Count == 0 || String.IsNullOrEmpty(txt_Mahs.Text))
            {
                MessageBox.Show("Mã học sinh không tồn tại !", "Lỗi");
                return;
            }
            else if (String.IsNullOrEmpty(cbb_Chonlop.Text))
            {
                MessageBox.Show("Lớp không tồn tại !", "Lỗi");
                return;
            }
            else if (nud_STT.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập STT cho học sinh !", "Lỗi");
                return;
            }
            else
            {
                var tenlop = cbb_Chonlop.Text;
                // Kiểm tra lớp đã đầy hay chưa
                int sisotoida = (int)DatabaseFunc.Select_Value("SELECT GIATRI FROM QUYDINH WHERE MAQD = 'QD03'");
                int sisolop = (int)DatabaseFunc.Select_Value($"SELECT SISO FROM LOP WHERE TENLOP = '{tenlop}'");
                if (sisolop >= sisotoida)
                {
                    MessageBox.Show("Lớp đã đầy !", "Lỗi");
                    return;
                }
                var mahs = txt_Mahs.Text;
                var stt = nud_STT.Value.ToString();
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
                list.Add(new CustomParam()
                {
                    Key = "@STT",
                    Value = stt,
                });

                int result = DatabaseFunc.Update("XEPLOP", list);
                if (result != 0)
                {
                    MessageBox.Show("Xếp lớp thành công", "Thông Báo");
                    frm_Load();
                }
                else
                {
                    MessageBox.Show("Xếp lớp thất bại !\nHọc sinh đã bị trùng STT với học sinh khác", "Lỗi");
                    frm_Load();
                }
            }
        }

        private void txt_Tim_TextChanged(object sender, EventArgs e)
        {
            var search_str = txt_Tim.Text;
            List<CustomParam> list = new List<CustomParam>();
            list.Add(new CustomParam()
            {
                Key = "@PARAM",
                Value = search_str,
            });
            dt = DatabaseFunc.Select("HOCSINH", list);
            dtg_Hosohs.DataSource = dt;

            dtg_Hosohs.Columns["TENLOP"].HeaderText = "Lớp";
            dtg_Hosohs.Columns["STT"].HeaderText = "STT";
            dtg_Hosohs.Columns["MAHS"].HeaderText = "Mã HS";
            dtg_Hosohs.Columns["HOTEN"].HeaderText = "Họ và Tên";
            dtg_Hosohs.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dtg_Hosohs.Columns["GIOITINH"].HeaderText = "Giới Tính";
            dtg_Hosohs.Columns["EMAIL"].HeaderText = "Email";
            dtg_Hosohs.Columns["DIACHI"].HeaderText = "Địa Chỉ";
        }

        private void dtg_Hosohs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mahs = dtg_Hosohs.Rows[e.RowIndex].Cells["MAHS"].Value.ToString();
                var value = dtg_Hosohs.Rows[e.RowIndex].Cells["TENLOP"].Value.ToString();
                var lop = (String.IsNullOrEmpty(value)) ? null : value.ToString();
                var stt = dtg_Hosohs.Rows[e.RowIndex].Cells["STT"].Value;
                txt_Mahs.Text = mahs;
                cbb_Chonlop.Text = lop;
                nud_STT.Value = (String.IsNullOrEmpty(stt.ToString())) ? 0 : (int)stt;
            }
            else return;
        }

        private void Them_ds_lop_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
