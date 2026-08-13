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
    public partial class frmCau2 : Form
    {
        public frmCau2()
        {
            InitializeComponent();
        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = cbbTenHang.SelectedIndex;
            switch(stt)
            {
                case 0:
                    cbbTenHang.Text = "100000";
                    break;
                case 1:
                    cbbTenHang.Text = "2000000";
                    break;
                case 2:
                    cbbTenHang.Text = "150000";
                    break;
            }    
        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            double thanhTien = donGia * soLuong;

            if (rdbChuyenKhoan.Checked)
                thanhTien = donGia * soLuong * 0.95;

            lblSoTien.Text = thanhTien.ToString();
        }

        private void lblSoTien_Click(object sender, EventArgs e)
        {

        }
    }
}
