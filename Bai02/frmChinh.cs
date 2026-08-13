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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void câu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCau1();
            form.ShowDialog();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCau2();
            form.ShowDialog();
        }
    }
}
