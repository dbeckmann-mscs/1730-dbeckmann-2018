using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbeckmann_1e1
{
    public partial class frmAverage : Form
    {
        public frmAverage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAverage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTest1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTest2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = ((
                Convert.ToDecimal(txtTest1.Text) +
                Convert.ToDecimal(txtTest2.Text) +
                Convert.ToDecimal(txtTest3.Text))/3).ToString("0");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "0";
            txtTest2.Text = "0";
            txtTest3.Text = "0";
            txtAverage.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
