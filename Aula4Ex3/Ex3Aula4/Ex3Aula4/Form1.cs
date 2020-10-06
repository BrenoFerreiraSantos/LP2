using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3Aula4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Lado sem valor");
            }
            else
            {
                double lado1, lado2, lado3;
                lado1 = Double.Parse(textBox1.Text);
                lado2 = Double.Parse(textBox2.Text);
                lado3 = Double.Parse(textBox3.Text);
                if (lado1 < 0 || lado2 < 0 || lado3 < 0)
                {
                    MessageBox.Show("Lado Negativo");
                }
                else if (lado1 > (lado2 - lado3) && lado1 > (lado3 - lado2) && lado1 < lado2 + lado3 && lado2 > (lado1 - lado3) && lado2 > (lado3 - lado1) && lado2 < lado1 + lado3 && lado3 > (lado2 - lado1) && lado3 > (lado1 - lado2) && lado3 < lado2 + lado1)
                {
                    if (lado1 == lado2 && lado1 == lado3)
                    {
                        MessageBox.Show("Triangulo Equilatero");
                    }
                    else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                    {
                        MessageBox.Show("Triangulo Escaleno");
                    }
                    else
                    {
                        MessageBox.Show("Triangulo Isósceles");
                    }

                }
                else
                {
                    MessageBox.Show("Não é um triangulo");
                }
            }
        }
    }
}
