using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class frmCau2 : Form
    {
        public frmCau2()
        {
            InitializeComponent();
        }
        private void rdbCong_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rdbTru_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rdbNhan_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rdbChia_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void txtSoThuNhat_TextChanged(object sender, EventArgs e)
        {

        }
        private void btXemKetqua_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSoThuNhat.Text, out double so1) || !double.TryParse(txtSoThuHai.Text, out double so2))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác số vào 2 ô!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rdbCong.Checked)
                lblKetQua.Text = $"Kết quả là: {so1 + so2}";
            else if (rdbTru.Checked)
                lblKetQua.Text = $"Kết quả là: {so1 - so2}";
            else if (rdbNhan.Checked)
                lblKetQua.Text = $"Kết quả là: {so1 * so2}";
            else if (rdbChia.Checked)
            {
                if (so2 == 0)
                    lblKetQua.Text = "Kết quả là: Không thể chia cho 0!";
                else
                    lblKetQua.Text = $"{so1 / so2}";
            }
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }
    }
}
