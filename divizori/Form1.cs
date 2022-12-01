using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace divizori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, x, rad;
            n = int.Parse(textBox1.Text);
            rad = (int)Math.Sqrt(n);
            textBox2.Text += "1";
            textBox2.Text += "\r\n";

            for (x = 2; x <= rad; x++)
            {
                if (n % x == 0)
                {
                    textBox2.Text += x.ToString() + " " + (n / x).ToString();
                    textBox2.Text += "\r\n";
                }
            }
        }
    }
}
