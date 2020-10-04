using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2Aula4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sexo;
        double valorfinal;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sexo = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sexo = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != " ," && maskedTextBox2.Text != "   ," && (sexo == 1 || sexo == 2))
            {
                double altura, peso;
                altura = Double.Parse(maskedTextBox1.Text);
                peso = Double.Parse(maskedTextBox2.Text);
                if (sexo == 1)
                {
                    valorfinal = (72.7 * altura) - 58;
                }
                else if (sexo == 2)
                {
                    valorfinal = (62.1 * altura) - 44.7;
                }
                if(peso > valorfinal)
                {
                    MessageBox.Show("Regime Obrigatório Já");
                }
                else if (peso < valorfinal)
                {
                    MessageBox.Show("Coma bastante doces e massas");
                } 
                else
                {
                    MessageBox.Show("Você esta com o peso ideal");
                }

            }
            else
            {
                MessageBox.Show("Falta algum valor");
            }

        }
    }
}
