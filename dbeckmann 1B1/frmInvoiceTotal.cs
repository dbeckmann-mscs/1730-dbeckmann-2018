using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbeckmann_1B1
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
             txtDiscountamount.Text = 
                (Convert.ToDecimal(txtSubtotal.Text) 
                * Convert.ToDecimal(txtDiscountpercent.Text) / 100).ToString("0.00");
            txtTotal.Text = 
                (Convert.ToDecimal(txtSubtotal.Text)
                - Convert.ToDecimal(txtDiscountamount.Text)).ToString("0.00");

           

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
