using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графики_функций
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a1 = textBox_a.Text;
            string b1 = textBox_b.Text;
            string c1 = textBox_c.Text;
            double a = Convert.ToDouble(a1);
            double b = Convert.ToDouble(b1);
            double c = Convert.ToDouble(c1);
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

            if (radioButton1.Checked && checkBox1.Checked)
            {
                string x1 = textBox_x.Text;
                double x = Convert.ToDouble(x1);
                double y = x * a + b;
                this.chart1.Series[1].Points.AddXY(x, y);              
            }

            if (radioButton2.Checked && checkBox1.Checked)
            {
                string x1 = textBox_x.Text;
                double x = Convert.ToDouble(x1);
                double y = Math.Sin(x * b) * a + c;
                this.chart1.Series[1].Points.AddXY(x, y);
            }

            if (radioButton3.Checked && checkBox1.Checked)
            {
                string x1 = textBox_x.Text;
                double x = Convert.ToDouble(x1);
                double y = Math.Cos(x * b + c) * a;
                this.chart1.Series[1].Points.AddXY(x, y);
            }

            if (radioButton4.Checked && checkBox1.Checked)
            {
                string x1 = textBox_x.Text;
                double x = Convert.ToDouble(x1);
                double y = Math.Tan(x * b) + c;
                this.chart1.Series[1].Points.AddXY(x, y);
            }

            if (radioButton5.Checked && checkBox1.Checked)
            {
                string x1 = textBox_x.Text;
                double x = Convert.ToDouble(x1);
                double y = a * (1/Math.Tan(x * b + c));
                this.chart1.Series[1].Points.AddXY(x, y);
            }

            if (radioButton6.Checked && checkBox1.Checked)
            {
                string x1 = textBox_x.Text;
                double x = Convert.ToDouble(x1);
                double y = b * Math.Pow(x, a);
                this.chart1.Series[1].Points.AddXY(x, y);
            }

            if (radioButton7.Checked && checkBox1.Checked)
            {
                string x1 = textBox_x.Text;
                double x = Convert.ToDouble(x1);
                double m = x + b;
                double y = Math.Pow(a, m);
                this.chart1.Series[1].Points.AddXY(x, y);
            }

            if (radioButton8.Checked && checkBox1.Checked)
            {
                string x1 = textBox_x.Text;
                double x = Convert.ToDouble(x1);
                double k = ((Math.Sin(x) + a * x) / ((x - Math.Pow(x, 0.5)) + 1));
                double m = b / x;
                double y = Math.Pow(k, m);
                this.chart1.Series[1].Points.AddXY(x, y);
            }

            else if (radioButton1.Checked && checkBox1.Checked == false)
            {
                double x = -10;
                for (int i = -1; i <= 201; i++)
                {
                    double y = x*a + b;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += 0.1;
                }
            }

            else if (radioButton2.Checked && checkBox1.Checked == false)
            {
                double x = -10;
                for (int i = 0; i <= 201; i++)
                {
                    double y = Math.Sin(x * b) * a + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += 0.1;
                }
            }

            else if (radioButton3.Checked && checkBox1.Checked == false)
            {
                double x = -10;
                for (int i = 0; i <= 201; i++)
                {
                    double y = Math.Cos(x * b + c) * a;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += 0.1;
                }
            }

            else if (radioButton4.Checked && checkBox1.Checked == false)
            {
                double x = -10;
                for (int i = 0; i <= 201; i++)
                {
                    double y = Math.Tan(x * b) + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += 0.1;
                }
            }

            else if (radioButton5.Checked && checkBox1.Checked == false)
            {
                double x = -3 * Math.PI;
                for (int i = 0; i <= 31; i++)
                {
                    if (Math.Tan(x * b + c) == 0)
                    {
                        x += 0.1;
                    }
                    else
                    {
                        double y = a * (1 / Math.Tan(x * b + c));
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += Math.PI/4;
                    }
                  
                }
            }

            else if (radioButton6.Checked && checkBox1.Checked == false)
            {
                double x = -10;
                for (int i = 0; i <= 201; i++)
                {
                    double y = b * Math.Pow(x, a);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += 0.1;
                }
            }

            else if (radioButton7.Checked && checkBox1.Checked == false)
            {
                double x = -10;
                for (int i = 0; i <= 201; i++)
                {
                    double m = x + b;
                    double y = Math.Pow(a, m);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += 0.1;
                }
            }

            else if (radioButton8.Checked && checkBox1.Checked == false)
            {
                double x = -10;
                for (int i = 0; i <= 201; i++)
                {
                    double k = ((Math.Sin(x) + a * x) / ((x - Math.Pow(x, 0.5)) + 1));
                    double m = b / x;
                    double y = Math.Pow(k, m);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += 0.1;
                }
            }
           
        }
    }
}
