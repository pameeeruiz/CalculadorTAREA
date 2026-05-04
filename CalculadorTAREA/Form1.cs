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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            Calcu frmCalcula = new Calcu(this);
            frmCalcula.MdiParent = this;
            frmCalcula.Show();

            cambiarestado(false);
        }

        public void cambiarestado(bool estado)
        {
            Calculadora.Enabled = estado;
        }

        private void Contador_Click(object sender, EventArgs e)
        {
            Calcu frmConverti = new Calcu(this);
            frmConverti.MdiParent = this;
            frmConverti.Show();

        }
    }
}
