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
    public partial class Diem_dat : Form
    {
        public Diem_dat()
        {
            InitializeComponent();
        }

        private void Diem_dat_Load(object sender, EventArgs e)
        {
            frm_Load(sender, e);
        }

        private void frm_Load(object sender, EventArgs e)
        {
            decimal datmon = DatabaseFunc.Select_Value("SELECT GIATRI FROM QUYDINH WHERE MAQD = 'QD08'");
            decimal dathocky = DatabaseFunc.Select_Value("SELECT GIATRI FROM QUYDINH WHERE MAQD = 'QD09'");
            if (datmon == -1 || datmon == -2 || dathocky == -1 || dathocky == -2)
            {
                MessageBox.Show("Đã xảy ra lỗi !", "Thông báo");
            }
            else
            {
                nud_Diemdatmon.Value = datmon;
                nud_Diemdathocky.Value = dathocky;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            decimal new_datmon = (decimal)nud_Diemdatmon.Value;
            decimal new_dathocky = (decimal)nud_Diemdathocky.Value;
            
            List<CustomParam> datmon = new List<CustomParam>();
            datmon.Add(new CustomParam()
            {
                Key = "@MAQD",
                Value = "QD08",
            });
            datmon.Add(new CustomParam()
            {
                Key = "@GIATRI",
                Value = new_datmon,
            });
            int result1 = DatabaseFunc.Update("QUYDINH", datmon);

            List<CustomParam> dathocky = new List<CustomParam>();
            dathocky.Add(new CustomParam()
            {
                Key = "@MAQD",
                Value = "QD09",
            });
            dathocky.Add(new CustomParam()
            {
                Key = "@GIATRI",
                Value = new_dathocky,
            });
            int result2 = DatabaseFunc.Update("QUYDINH", dathocky);

            if (result1 != 0 && result2 != 0)
            {
                MessageBox.Show("Cập nhật thành công !", "Thông báo");
                frm_Load(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi kết nối !", "Thông báo");
                return;
            }
        }
    }
}
