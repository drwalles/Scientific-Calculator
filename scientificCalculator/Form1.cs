using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sciencetificCalculator
{
    public partial class Form1 : Form
    {
        double results = 0;
        string operation = "";
        bool enter_value = false;
        char ioperation;
        float icelsius, ifahrenheit, ikelvin;
        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 307;//, 450
            textBox1.Width = 266;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 595;//, 450
            textBox1.Width = 555;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 307;//, 450
            textBox1.Width = 266;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 904;
            textBox1.Width = 555;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 904;
            textBox1.Width = 555;
        }

        private void multiplicationTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1219;
            textBox1.Width = 555;
        }

        private void Click_button(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "0";
            enter_value = false;
            Button num = (Button)sender;
            if(num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + num.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "0";
            textBox1.Clear();
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1);
            }
            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void Arithmetic_operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (operation)
            {
                case "+":
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (results % Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (results);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592653589976323";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Log(" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
           

        }

        private void button31_Click(object sender, EventArgs e)
        {
            double isqrt = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sqrt(" + (textBox1.Text) + ")");
            isqrt = Math.Sqrt(isqrt);
            textBox1.Text = System.Convert.ToString(isqrt);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double qsinh = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("aSin(" + (textBox1.Text) + ")");
            qsinh = Math.Sinh(qsinh);
            textBox1.Text = System.Convert.ToString(qsinh);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double qcosh = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("aCos(" + (textBox1.Text) + ")");
            qcosh = Math.Cosh(qcosh);
            textBox1.Text = System.Convert.ToString(qcosh);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double qtan = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("aTan(" + (textBox1.Text) + ")");
            qtan = Math.Tanh(qtan);
            textBox1.Text = System.Convert.ToString(qtan);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Sin(" + (textBox1.Text) + ")");
            sin = Math.Sin(sin);
            textBox1.Text = System.Convert.ToString(sin);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Cos(" + (textBox1.Text) + ")");
            cos = Math.Cos(cos);
            textBox1.Text = System.Convert.ToString(cos);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Tan(" + (textBox1.Text) + ")");
            tan = Math.Tan(tan);
            textBox1.Text = System.Convert.ToString(tan);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a,2);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Ln(" + (textBox1.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'C';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'F';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'K';
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox4.Text);
            for(int i = 1; i < 13; i++)
            {
                Multiply.Items.Add(i + " x " + a + " = " + a * i);
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            Multiply.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            switch (ioperation)
            {
                case 'C':
                    icelsius = float.Parse(textBox2.Text);
                    textBox3.Text = ((((9 * icelsius) / 5) + 32).ToString());
                    break;
                case 'F':
                    ifahrenheit = float.Parse(textBox2.Text);
                    textBox3.Text = ((((ifahrenheit-32) * 5) / 9).ToString());
                    break;
                case 'K':
                    ikelvin = float.Parse(textBox2.Text);
                    textBox3.Text = (((((9 * ikelvin) / 5) + 32)+273.15).ToString());
                    break;
            }
        }
    }
}
