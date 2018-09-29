using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbeckmann_2a1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Subtotal = Convert.ToDecimal(txtSubtotal.Text);           
            decimal PercentDiscount = Convert.ToDecimal(txtDiscountpercent.Text) / 100;
            decimal DiscountAmount = (Subtotal * PercentDiscount);
            txtDiscountamount.Text = DiscountAmount.ToString("0.00");

            decimal Total = Subtotal + DiscountAmount;
            txtTotal.Text = Total.ToString("0.00");  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
