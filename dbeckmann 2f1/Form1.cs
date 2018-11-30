using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbeckmann_2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            // #1 if
            subtotal = decimal.Parse(input1ATextBox.Text);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            result1TextBox.Text = discountPercent.ToString("n2");
            //result1TextBox.Text = Ex2fCalculations.Calc01(input1ATextBox.Text);

            // #2 if block
            subtotal = decimal.Parse(input2ATextBox.Text);
            discountPercent = 0m;
            string status = "Standard rate: ";
            
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: ";
            }
            result2TextBox.Text = status + discountPercent.ToString("n2");

            // #3 if else
            subtotal = decimal.Parse(input3ATextBox.Text);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            result3TextBox.Text = discountPercent.ToString("n2");

            // #4 if else if
            subtotal = decimal.Parse(input4ATextBox.Text);
            discountPercent = 0m;
            if (subtotal >= 100 && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200 && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            result4TextBox.Text = discountPercent.ToString("n2");

            // #5 Better range test
            subtotal = decimal.Parse(input5ATextBox.Text);
            discountPercent = 0m;
            if (subtotal >= 300)
                discountPercent = 0.4m;
            else if (subtotal >= 200)
                discountPercent = 0.3m;
            else if (subtotal >= 100)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            result5TextBox.Text = discountPercent.ToString("n2");

            // #6 Nested if
            subtotal = decimal.Parse(input6ATextBox.Text);
            string customerType = input6BTextBox.Text;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else
                discountPercent = 0.4m;
            result6TextBox.Text = discountPercent.ToString("n2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void result5TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
