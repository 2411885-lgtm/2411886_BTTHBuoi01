using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class frmCau1 : Form
    {
        public frmCau1()
        {
            InitializeComponent();
        }

        private void frmCau1_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSanPham = "SP03";
            sp.TenSanPham = "Sữa tươi";
            sp.LoaiSanPham = "Thực phẩm";
            sp.NgaySanXuat = new DateTime(2026, 5, 20);

            lblThongBao.Text = sp.HienThi();
        }
    }
}
