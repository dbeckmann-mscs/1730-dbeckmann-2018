using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbeckmann_1f1
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            btnAntigua.BackgroundImage = picAntiguaDim.Image;
            btnBarbados.BackgroundImage = picBarbadosDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnSwaziland.BackgroundImage = picSwazilandDim.Image;
            txtRate.Text = "0.37037";
            lblCurrency.Text = btnAntigua.Text + ":" ;
            txtUS.Text = "0.00";
            txtTotal.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnAntigua_Click(object sender, EventArgs e)
        {
            btnAntigua.BackgroundImage = picAntigua.Image;
            btnBarbados.BackgroundImage = picBarbadosDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnSwaziland.BackgroundImage = picSwazilandDim.Image;
            txtRate.Text = "0.37037";
            lblCurrency.Text = btnAntigua.Text + ":";
            txtCurrency.Focus();
        }

        private void btnBarbados_Click(object sender, EventArgs e)
        {
            btnBarbados.BackgroundImage = picBarbados.Image;
            btnAntigua.BackgroundImage = picAntiguaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnSwaziland.BackgroundImage = picSwazilandDim.Image;
            txtRate.Text = "0.50";
            lblCurrency.Text = btnBarbados.Text + ":";
            txtCurrency.Focus();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAntigua.BackgroundImage = picAntiguaDim.Image;
            btnBarbados.BackgroundImage = picBarbadosDim.Image;
            btnSwaziland.BackgroundImage = picSwazilandDim.Image;
            txtRate.Text = "0.01390";
            lblCurrency.Text = btnBhutan.Text + ":";
            txtCurrency.Focus();
        }

        private void btnSwaziland_Click(object sender, EventArgs e)
        {
            btnSwaziland.BackgroundImage = picSwaziland.Image;
            btnAntigua.BackgroundImage = picAntiguaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;            
            btnBarbados.BackgroundImage = picBarbadosDim.Image;
            txtRate.Text = "0.06571";
            lblCurrency.Text = btnSwaziland.Text + ":";
            txtCurrency.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUS.Text = (
                Convert.ToDecimal(txtCurrency.Text) *
                Convert.ToDecimal(txtRate.Text)).ToString("0.00");            
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
            txtRate.SelectAll();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (
                Convert.ToDecimal(txtTotal.Text) + 
                Convert.ToDecimal(txtUS.Text)).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUS.Text;
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEquation_Click(object sender, EventArgs e)
        {

        }
        
        private void lblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAntigua.BackgroundImage = picAntiguaDim.Image;
            btnBarbados.BackgroundImage = picBarbadosDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnSwaziland.BackgroundImage = picSwazilandDim.Image;
            txtRate.Text = "0.37037";
            lblCurrency.Text = btnAntigua.Text + ":";
            txtCurrency.Text = "0.00";
            txtUS.Text = "0.00";
            txtTotal.Text = "0.00";
            lblEquation.Text = "";
            txtCurrency.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
