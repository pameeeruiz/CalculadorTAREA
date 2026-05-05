using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorTAREA
{
    public partial class Calcu : Form
    {
        Principal frmprinci = new Principal();


        double num1 = 0;
        string operacion = "";

        public Calcu(Principal frm)
        {
            InitializeComponent();
            frmprinci = frm;
        }

        private void Calcu_Load(object sender, EventArgs e)
        {

        }

        private void Calcu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmprinci.cambiarestado(true);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txbPantalla.Text += btn.Text;


        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (txbPantalla.Text == "") return;

            num1 = double.Parse(txbPantalla.Text);
            operacion = "-";
            txbPantalla.Text += " - ";

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txbPantalla.Text == "") return;

            num1 = double.Parse(txbPantalla.Text);
            operacion = "+";
            txbPantalla.Text += " + ";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbPantalla.Clear();
            num1 = 0;
            operacion = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string[] partes = txbPantalla.Text.Split(' ');

                double n1 = double.Parse(partes[0]);
                string op = partes[1];
                double n2 = double.Parse(partes[2]);

                double resultado = 0;

                switch (op)
                {
                    case "+": resultado = n1 + n2; break;
                    case "-": resultado = n1 - n2; break;
                    case "*": resultado = n1 * n2; break;
                    case "/":
                        if (n2 == 0)
                        {
                            MessageBox.Show("No se puede dividir entre 0");
                            return;
                        }
                        resultado = n1 / n2;
                        break;
                }

                txbPantalla.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Operación inválida");
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (txbPantalla.Text == "") return;

            if (txbPantalla.Text.Contains("+") || txbPantalla.Text.Contains("-") ||
                txbPantalla.Text.Contains("*") || txbPantalla.Text.Contains("/"))
                return;

            txbPantalla.Text += " * ";
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {

            if (txbPantalla.Text == "") return;

            if (txbPantalla.Text.Contains("+") || txbPantalla.Text.Contains("-") ||
                txbPantalla.Text.Contains("*") || txbPantalla.Text.Contains("/"))
                return;

            txbPantalla.Text += " / ";
        }
    }
}
