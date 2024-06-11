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
    public partial class Tra_cuu : Form
    {
        DataTable dt;

        public Tra_cuu()
        {
            InitializeComponent();
        }

        private void Tra_cuu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_ApplicationDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.my_ApplicationDataSet.LOP);
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            var tenhs = txt_Tenhs.Text;
            var tenlop = cbb_Chonlop.Text;
            List<CustomParam> list = new List<CustomParam>();
            list.Add(new CustomParam()
            {
                Key = "@TENHS",
                Value = tenhs,
            });
            list.Add(new CustomParam()
            {
                Key = "@TENLOP",
                Value = tenlop,
            });
            dt = DatabaseFunc.Select("TRACUU", list);
            if (dt == null)
            {
                MessageBox.Show("Đã xảy ra lỗi kết nối !", "Thông báo");
                return;
            }
            dtg_Tracuu.DataSource = dt;

            dtg_Tracuu.Columns["MAHS"].HeaderText = "Mã HS";
            dtg_Tracuu.Columns["HOTEN"].HeaderText = "Họ và Tên";
            dtg_Tracuu.Columns["TENLOP"].HeaderText = "Lớp";
            dtg_Tracuu.Columns["TB_HKI"].HeaderText = "TB Học Kỳ I";
            dtg_Tracuu.Columns["TB_HKI"].DefaultCellStyle.Format = "0.0";
            dtg_Tracuu.Columns["TB_HKII"].HeaderText = "TB Học Kỳ II";
            dtg_Tracuu.Columns["TB_HKII"].DefaultCellStyle.Format = "0.0";
            dtg_Tracuu.Columns["STT"].Visible = false;
        }

        private void txt_Tim_TextChanged(object sender, EventArgs e)
        {
            btn_Tim_Click(sender, e);
        }
    }
}
