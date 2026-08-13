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
    public partial class frmCau1 : Form
    {
        public frmCau1()
        {
            InitializeComponent();
        }

        private void frmCau1_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = "NV885";
            nv.HoTen = "Nguyễn Văn A";
            nv.NgaySinh = new DateTime(1995, 5, 20);
            nv.HeSoLuong = 3;
            nv.HeSoPhuCap = 1;

            lblThongBao.Text = nv.HienThi();
        }
    }
}
