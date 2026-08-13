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
    public partial class frmCau1 : Form
    {
        public frmCau1()
        {
            InitializeComponent();
        }

        private void lblThongBao_Click(object sender, EventArgs e)
        {

        }

        private void frmCau1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi();
            tb.MaThietBi = "MTB02";
            tb.TenThietBi = "Máy in";
            tb.NuocSanXuat = "Anh";
            tb.DonGia = 2000000;
            tb.SoLuong = 2;

            lblThongBao.Text = tb.HienThi();
        }
    }
}
