using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class frmCau2 : Form
    {
        public frmCau2()
        {
            InitializeComponent();
        }

        private void btXemKetqua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoNguyenDuong.Text.Trim(), out int n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương N!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNguyenDuong.Focus();
                return;
            }
            if (rdbTinhTong.Checked)
            {
                long tong = 0;
                for (int i = 1; i <= n; i++)
                {
                    tong += i;
                }
                lblKetQua.Text = tong.ToString();
            }
            else if (rdbTinhGiaiThua.Checked)
            {
                long giaiThua = 1;
                for (int i = 1; i <= n; i++)
                {
                    giaiThua *= i;
                }
                lblKetQua.Text = giaiThua.ToString();
            }
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }
    }
}
