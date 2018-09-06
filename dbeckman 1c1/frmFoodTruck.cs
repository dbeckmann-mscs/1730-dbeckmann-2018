﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbeckman_1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                      4.0m * Convert.ToDecimal (txtHotDogs.Text)
                ).ToString("0.00");
            txtHamburderSubtotal.Text = (
                      5.0m * Convert.ToDecimal(txtHamburgers.Text)
                      ).ToString("0.00");

            txtPretaxTotal.Text = (
                Convert.ToDecimal(txtHotDogsSubtotal.Text)
                + Convert.ToDecimal(txtHamburderSubtotal.Text)).ToString("0.00");

            btnClear.Focus();

            txtTax.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text)
                * .06875m).ToString("0.00");

            txtTotal.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text)
                + Convert.ToDecimal(txtTax.Text)).ToString("0.00");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

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
    }
}
