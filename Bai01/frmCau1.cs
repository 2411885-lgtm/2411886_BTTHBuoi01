using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class frmCau1 : Form
    {
        public frmCau1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MaHang = "HH01";
            hh.TenHang = "Chuột";
            hh.DVT = "Cái";
            hh.SoLuong = 3;
            hh.DonGia = 100000;

            lblThongBao.Text = hh.HienThi();
        }
    }
}
