using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class frmSet : Form
    {
        public frmSet()
        {
            InitializeComponent();
        }

        private void btnPName_Click(object sender, EventArgs e)
        {
            Form1.name = txtPName.Text;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            Form1.hp = Convert.ToInt32(txtP.Text);
        }
    }
}
