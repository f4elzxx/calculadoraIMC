using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            // Obter o peso e a altura 
            double peso, altura, imc;
            peso = double.Parse(txtpeso.Text);
            altura = double.Parse(txtaltura.Text);

            imc = peso / (altura * altura);

            // Calcular IMC
            if (imc <= 18.5)
            {
                txtIMC.Text =  Math.Round(imc, 3).ToString();
                Lbsituacao.ForeColor= Color.Orange;
                Lbsituacao.Text = "Abaixo do Peso";
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                txtIMC.Text = Math.Round(imc, 3).ToString();
                Lbsituacao.ForeColor = Color.Green;
                Lbsituacao.Text = "Peso adequado";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                txtIMC.Text = Math.Round(imc, 3).ToString();
                Lbsituacao.ForeColor = Color.Red;
                Lbsituacao.Text = "Acima do Peso";
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                txtIMC.Text = Math.Round(imc, 3).ToString();
                LbIMC.ForeColor = Color.Purple;
                Lbsituacao.Text = "Obesidade Grau I";
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                txtIMC.Text = Math.Round(imc, 3).ToString();
                Lbsituacao.ForeColor = Color.MediumPurple;
                Lbsituacao.Text = "Obesidade Grau II";
            }
            else
            {
                txtIMC.Text = Math.Round(imc, 3).ToString();
                Lbsituacao.ForeColor = Color.DarkRed;
                Lbsituacao.Text = "Obesidade III";
            }

        }
    }
}
