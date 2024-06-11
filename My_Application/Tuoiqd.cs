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
    public partial class Tuoiqd : Form
    {
        public Tuoiqd()
        {
            InitializeComponent();
        }

        private void Tuoiqd_Load(object sender, EventArgs e)
        {
            frm_Load(sender, e);
        }

        private void frm_Load(object sender, EventArgs e)
        {
            int min = (int)DatabaseFunc.Select_Value("SELECT GIATRI FROM QUYDINH WHERE MAQD = 'QD01'");
            int max = (int)DatabaseFunc.Select_Value("SELECT GIATRI FROM QUYDINH WHERE MAQD = 'QD02'");
            if (min == -2 || max == -2)
            {
                MessageBox.Show("Đã xảy ra lỗi kết nối!", "Thông báo");
            }
            else
            {
                nud_Tuoitoithieu.Value = (min == -1 ? 0 : min);
                nud_Tuoitoida.Value = (max == -1 ? 0 : max);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            int old_min = (int)DatabaseFunc.Select_Value("SELECT GIATRI FROM QUYDINH WHERE MAQD = 'QD01'");
            int old_max = (int)DatabaseFunc.Select_Value("SELECT GIATRI FROM QUYDINH WHERE MAQD = 'QD02'");
            if (old_min == -2 || old_max == -2)
            {
                MessageBox.Show("Đã xảy ra lỗi kết nối !", "Lỗi");
                return;
            }

            int new_min = (int)nud_Tuoitoithieu.Value;
            int new_max = (int)nud_Tuoitoida.Value;
            if (new_min > new_max)
            {
                MessageBox.Show("Tuổi tối thiểu phải nhỏ hơn tuổi tối đa !", "Lỗi");
                frm_Load(sender, e);
                return;
            }
            else if (new_min != old_min || new_max != old_max)
            {
                List<CustomParam> tuoitoithieu = new List<CustomParam>();
                tuoitoithieu.Add(new CustomParam()
                {
                    Key = "@MAQD",
                    Value = "QD01",
                });
                tuoitoithieu.Add(new CustomParam()
                {
                    Key = "@GIATRI",
                    Value = new_min,
                });
                int result1 = DatabaseFunc.Update("QUYDINH", tuoitoithieu);

                List<CustomParam> tuoitoida = new List<CustomParam>();
                tuoitoida.Add(new CustomParam()
                {
                    Key = "@MAQD",
                    Value = "QD02",
                });
                tuoitoida.Add(new CustomParam()
                {
                    Key = "@GIATRI",
                    Value = new_max,
                });
                int result2 = DatabaseFunc.Update("QUYDINH", tuoitoida);

                if (result1 != 0 && result2 != 0)
                {
                    MessageBox.Show("Cập nhật thành công !", "Thông báo");
                    frm_Load(sender, e);
                    return;
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi !", "Thông báo");
                    return;
                }
            }
        }
    }
}
