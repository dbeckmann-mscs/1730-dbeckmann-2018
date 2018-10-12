using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dBeckmann_2d1
{
    public partial class FrmRational : Form
    {
        public FrmRational()
        {
            InitializeComponent();
        }

        private void Passbutton_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "Frank";
            textBox2input.Text = "";
            textBox3input.Text = "2.3";
            textBox4input.Text = "false";
            textBox5Ainput.Text = "2";
            textBox5Binput.Text = "2";
            textBox6input.Text = "xyz";
            textBox7input.Text = "1";
            textBox8Ainput.Text = "1";
            textBox8Binput.Text = "2";
            textBox9input.Text = "500";
            textBox10Ainput.Text = "2";
            textBox10Binput.Text = "3";
        }

        private void Failbutton_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "xyz";
            textBox2input.Text = "xwz";
            textBox3input.Text = "3.2";
            textBox4input.Text = "true";
            textBox5Ainput.Text = "21";
            textBox5Binput.Text = "2";
            textBox6input.Text = "Jones";
            textBox7input.Text = "0";
            textBox8Ainput.Text = "1";
            textBox8Binput.Text = "1";
            textBox9input.Text = "499";
            textBox10Ainput.Text = "4";
            textBox10Binput.Text = "3";
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            textBox1Aresults.Text = "Fail";
            textBox2Aresults.Text = "Fail";
            textBox3Aresults.Text = "Fail";
            textBox4Aresults.Text = "Fail";
            textBox5Aresults.Text = "Fail";
            textBox6Aresults.Text = "Fail";
            textBox7Aresults.Text = "Fail";
            textBox8Aresults.Text = "Fail";
            textBox9Aresults.Text = "Fail";
            textBox10Aresults.Text = "Fail";

            textBox1Bresults.Text = "Success";
            textBox2Bresults.Text = "Success";
            textBox3Bresults.Text = "Success";
            textBox4Bresults.Text = "Success";
            textBox5Bresults.Text = "Success";
            textBox6Bresults.Text = "Success";
            textBox7Bresults.Text = "Success";
            textBox8Bresults.Text = "Success";
            textBox9Bresults.Text = "Success";
            textBox10Bresults.Text = "Success";

            if (textBox1input.Text == "Frank")
                textBox1Aresults.Text = "Success";
            if (textBox1input.Text != "Frank")
                textBox1Bresults.Text = "Fail";

            if(textBox2input.Text == "")
                textBox2Aresults.Text = "Success";
            if (textBox2input.Text != "")
                textBox2Bresults.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3input.Text);
            if (val3 == 2.3m)
                textBox3Aresults.Text = "Success";
            if (val3 != 2.3m)
                textBox3Bresults.Text = "Fail";

            bool val4 = Convert.ToBoolean(textBox4input.Text);
                if (val4 == false)
                textBox4Aresults.Text = "Success";
            if (val4 != false)
                textBox4Bresults.Text = "Fail";

            Int64 val5a = Convert.ToInt64(textBox5Ainput.Text);
            Int64 val5b = Convert.ToInt64(textBox5Binput.Text);
                if (val5a == val5b)
                textBox5Aresults.Text = "Success";
            if (val5a != val5b)
                textBox5Bresults.Text = "Fail";

            if (textBox6input.Text != "Jones")
                textBox6Aresults.Text = "Success";
            if (textBox6input.Text == "Jones")
                textBox6Bresults.Text = "Fail"; 

            Int64 val7 = Convert.ToInt64(textBox7input.Text);
                if (val7 > 0)
                textBox7Aresults.Text = "Success";
            if (val7 <= 0)
                textBox7Bresults.Text = "Fail";

            Int64 val8a = Convert.ToInt64(textBox8Ainput.Text);
            Int64 val8b = Convert.ToInt64(textBox8Binput.Text);
            if (val8a < val8b)
                textBox8Aresults.Text = "Success";
            if (val8a >= val8b)
                textBox8Bresults.Text = "Fail";

            Int64 val9 = Convert.ToInt64(textBox9input.Text);
            if (val9 >= 500m)
                textBox9Aresults.Text = "Success";
            if (val9 < 500m)
                textBox9Bresults.Text = "Fail";

            Int64 val10a = Convert.ToInt64(textBox10Ainput.Text);
            Int64 val10b = Convert.ToInt64(textBox10Binput.Text);
            if (val10a <= val10b)
                textBox10Aresults.Text = "Success";
            if (val10a > val10b)
                textBox10Bresults.Text = "Fail";



        }
    }
}
