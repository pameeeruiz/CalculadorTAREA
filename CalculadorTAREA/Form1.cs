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

        /// <summary>
        /// Gutierrez Ruiz Evelyn Pamela
        /// 06/06/2026
        /// Esta clase se encarga de administra un formulario MDI, controla la apertura de ventanas como la calculadora y el convertidor
        /// habilita o deshabilita botones según el estado y permite salir de la aplicación.
        /// </summary>
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
            Convertidor frmConverti = new Convertidor(this);
            frmConverti.MdiParent = this;
            frmConverti.Show();

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
