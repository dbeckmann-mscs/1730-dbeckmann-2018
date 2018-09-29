using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbeckmann_2b1
{
    public partial class Form2b1 : Form
    {
        public Form2b1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            decimal AmountAntiqua = Convert.ToDecimal(txtAmountAntigua.Text);
            decimal RateAntiqua = Convert.ToDecimal(txtRatesAntigua.Text);
            decimal USDAntiqua = AmountAntiqua * RateAntiqua;
            txtUSDAntigua.Text = USDAntiqua.ToString("0.00");

            decimal AmountBarbados = Convert.ToDecimal(txtAmountBarbados.Text);
            decimal RateBarbados = Convert.ToDecimal(txtRatesBarbados.Text) ;
            decimal USDBarbados = AmountBarbados * RateBarbados;
            txtUSDBarbados.Text = USDBarbados.ToString("0.00");

            decimal AmountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal RateBhutan = Convert.ToDecimal(txtRatesBhutan.Text);
            decimal USDBhutan = AmountBhutan * RateBhutan;
            txtUSDBhutan.Text = USDBhutan.ToString("0.00");

            decimal AmountSwaziland = Convert.ToDecimal(txtAmountSwaziland.Text);
            decimal RateSwaziland = Convert.ToDecimal(txtRatesSwaziland.Text);
            decimal USDSwaziland = AmountSwaziland * RateSwaziland;
            txtUSDSwaziland.Text = USDSwaziland.ToString("0.00");

            decimal USDTotal = USDAntiqua + USDBarbados + USDBhutan + USDSwaziland;
            txtUSDTotal.Text = USDTotal.ToString("0.00");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

