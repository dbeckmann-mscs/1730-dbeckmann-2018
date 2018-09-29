using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbeckmannvariableReview
{
    public partial class VariableReview : Form
    {
        public VariableReview()
        {
            InitializeComponent();
        }

        private void txtHotDogs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //txtHotDogsSubtotal.Text = (
            //          4.0m * Convert.ToDecimal(txtHotDogs.Text)
            //    ).ToString("0.00");

            int HotDogs = Convert.ToInt32(txtHotDogs.Text);
            decimal HotDogPrice = 4.0m;
            decimal HotDogSubtotal = HotDogs * HotDogPrice;
            txtHotDogsSubtotal.Text = HotDogSubtotal.ToString("0.00");

            int Hamburger = Convert.ToInt32(txtHamburgers.Text);
            decimal HamburgerPrice = 5.0m;
            decimal HamburgerSubtotal = Hamburger * HamburgerPrice;
            txtHamburderSubtotal.Text = HamburgerSubtotal.ToString("0.00");

            //txtHamburderSubtotal.Text = (
            //          5.0m * Convert.ToDecimal(txtHamburgers.Text)
            //          ).ToString("0.00");

            decimal PretaxTotal = HotDogSubtotal + HamburgerSubtotal;
            txtPretaxTotal.Text = PretaxTotal.ToString("0.00");

            //txtPretaxTotal.Text = (
            //    Convert.ToDecimal(txtHotDogsSubtotal.Text)
            //    + Convert.ToDecimal(txtHamburderSubtotal.Text)).ToString("0.00");

            decimal Tax = 6.875m * PretaxTotal / 100;
            txtTax.Text = Tax.ToString("0.00");

            //txtTax.Text = (
            //    Convert.ToDecimal(txtPretaxTotal.Text)
            //    * .06875m).ToString("0.00");

            decimal Total = PretaxTotal + Tax;
            txtTotal.Text = Total.ToString("0.00");

            //txtTotal.Text = (
            //    Convert.ToDecimal(txtPretaxTotal.Text)
            //    + Convert.ToDecimal(txtTax.Text)).ToString("0.00");

            btnClear.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburderSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
