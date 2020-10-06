using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExAula5Imposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double inss, irpf, salfam, salbru, salliq;
        string nome, aliqinss, aliqirpf;
        int filhos;

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "           ," || maskedTextBox3.Text == "" || (radioButton1.Checked == false && radioButton2.Checked == false))
            {
                MessageBox.Show("Falta(m)-se algum(s) valor(es)");
            }
            else
            {
                nome = maskedTextBox1.Text;
                salbru = Convert.ToDouble(maskedTextBox2.Text);
                filhos = Convert.ToInt32(maskedTextBox3.Text);

                if (salbru <= 800.47)
                {
                    aliqinss = "7.65%";
                    inss = 0.0765 * salbru;
                }
                else if (800.47 < salbru && salbru <= 1050)
                {
                    aliqinss = "8.65%";
                    inss = 0.0865 * salbru;
                }
                else if (1050 < salbru && salbru <= 1400.77)
                {
                    aliqinss = "9.00%";
                    inss = 0.09 * salbru;
                }
                else if (1400.77 < salbru && salbru <= 2801.56)
                {
                    aliqinss = "11.00%";
                    inss = 0.11 * salbru;
                }
                else
                {
                    aliqinss = "308.17(Teto)";
                    inss = 308.17;
                }


                if (salbru <= 1257.12)
                {
                    aliqirpf = "0.00%";
                    irpf = 0 * salbru;
                }
                else if (1257.12 < salbru && salbru <= 2512.08)
                {
                    aliqirpf = "15.00%";
                    irpf = 0.15 * salbru;
                }
                else
                {
                    aliqirpf = "27.50%";
                    irpf = 0.275 * salbru;
                }


                if (salbru <= 435.52)
                {
                    salfam = 22.33 * filhos;
                }
                else if (435.52 < salbru && salbru <= 654.61)
                {
                    salfam = 15.74 * filhos;
                }
                else
                {
                    salfam = 0;
                }

                salliq = salbru - inss - irpf + salfam;

                maskedTextBox4.Text = aliqinss;
                maskedTextBox5.Text = aliqirpf;
                maskedTextBox6.Text = salfam.ToString();
                maskedTextBox7.Text = salliq.ToString();
                maskedTextBox8.Text = inss.ToString();
                maskedTextBox9.Text = irpf.ToString();

                string sr, civil;

                if(radioButton1.Checked == true)
                {
                    sr = "a \n Sra. ";
                }
                else
                {
                    sr = "o \n Sr. ";
                }
                if (radioButton3.Checked == true)
                {
                    if(radioButton2.Checked == true)
                    {
                        civil = "casado";
                    }
                    else
                    {
                        civil = "casada";
                    }
                }
                else
                {
                    if (radioButton2.Checked == true)
                    {
                        civil = "solteiro";
                    }
                    else
                    {
                        civil = "solteira";
                    }
                }
                
                 label10.Text = "Os descontos do salário d" + sr + maskedTextBox1.Text + "\n que é " + civil + " e que tem " + Convert.ToString(filhos) + " filhos são:";
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "           ,";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";
            maskedTextBox7.Text = "";
            maskedTextBox8.Text = "";
            maskedTextBox9.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            label10.Text = "";
        }


    }
}
