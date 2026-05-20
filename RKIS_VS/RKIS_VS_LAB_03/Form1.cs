using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RKIS_VS_LAB_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Place numbers in variables && press equal sign.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y, answ;

            bool textBox1IsFloat = double.TryParse(textBox1.Text, out x);

            if (textBox1IsFloat == false )
            {
                MessageBox.Show("Please enter a valid float in the first text box.");
                return;
            }

            bool textBox2IsFloat = double.TryParse(textBox2.Text, out y);
            if (textBox2IsFloat == false )
            {
                MessageBox.Show("Please enter a valid float in the second text box.");
                return;
            }

            answ = (3*x + 6*y)/2;
            string answToString = answ.ToString();
            label2.Text = answToString;
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
