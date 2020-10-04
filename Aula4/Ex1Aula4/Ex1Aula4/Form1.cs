using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1Aula4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int op;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            op = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            op = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;
            numero1 = Double.Parse(textBox1.Text);
            numero2 = Double.Parse(textBox2.Text);
            if (op == 1)
            {
                resultado = numero1 + numero2;
                textBox3.Text = resultado.ToString();
            }
            else if (op == 2)
            {
                resultado = numero1 - numero2;
                textBox3.Text = resultado.ToString();
            }
            else if (op == 3)
            {
                resultado = numero1 * numero2;
                textBox3.Text = resultado.ToString();
            }
            else if (op == 4 && numero2 != 0)
            {
                resultado = numero1 / numero2;
                textBox3.Text = resultado.ToString();
            }
            if (op <= 4 && op >= 1)
            {
                op = 0;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            op = 0;
        }
    }
}
