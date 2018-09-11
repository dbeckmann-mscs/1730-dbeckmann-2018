using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbeckmann_1d2
{
    public partial class frmCalculate : Form
    {
        public frmCalculate()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAntigua.Text = "0.00";
            txtRatesAntigua.Text = "0.37037";
            txtAmountBarbados.Text = "0.00";
            txtRatesBarbados.Text = "0.50";
            txtAmountBhutan.Text = "0.00";
            txtRatesBhutan.Text = "0.01390";
            txtAmountSwaziland.Text = "0.00";
            txtRatesSwaziland.Text = "0.06571";
        }

        private void AntiguaTextChanged(object sender, EventArgs e)
        {
            txtUSDAntigua.Text = (
                Convert.ToDecimal(txtAmountAntigua.Text)
                * Convert.ToDecimal(txtRatesAntigua.Text)).ToString("0.00");
        }


        private void BarbadosTextChanged(object sender, EventArgs e)
        {
            txtUSDBarbados.Text = (
                Convert.ToDecimal(txtAmountBarbados.Text)
                * Convert.ToDecimal(txtRatesBarbados.Text)).ToString("0.00");
        }

        private void BhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                Convert.ToDecimal(txtAmountBhutan.Text)
                * Convert.ToDecimal(txtRatesBhutan.Text)).ToString("0.00");
        }

        private void SwazilandTextChanged(object sender, EventArgs e)
        {
            txtUSDSwaziland.Text = (
                Convert.ToDecimal(txtAmountSwaziland.Text)
                * Convert.ToDecimal(txtRatesSwaziland.Text)).ToString("0.00");
        }

        private void txtUSDBarbados_TextChanged(object sender, EventArgs e)
        {

        }

        private void USDTextChange(object sender, EventArgs e)
        {
            
        }

        private void USDTextChanged(object sender, EventArgs e)
        {
            txtUSDTotal.Text = (
                99m
                ).ToString("0.00");
              
        }

        private void txtUSDTotal_TextChanged(object sender, EventArgs e)
        {
            txtUSDTotal.Text = (
                Convert.ToDecimal(txtUSDAntigua.Text)
                + Convert.ToDecimal(txtUSDBarbados.Text)
                + Convert.ToDecimal(txtUSDBhutan.Text)
                + Convert.ToDecimal(txtUSDSwaziland.Text)).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
