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
    public partial class Convertidor : Form
    {
        /// <summary>
        /// Gutierrez Ruiz Evelyn Pamela
        /// 06/05/2026
        /// transformar valores entre distintas unidades (metros, centímetros, kilogramos y gramos)
        /// validando la entrada del usuario y mostrando el resultado según la opción seleccionada en un ComboBox.
        /// </summary>

        Principal frmprinci = new Principal();
        public Convertidor(Principal frm)
        {
            InitializeComponent();
            frmprinci = frm;
        }

        private void Convertidor_Load(object sender, EventArgs e)
        {
            comboOpciones.Items.Add("Metros a centimetros");
            comboOpciones.Items.Add("Centimetros a metros");
            comboOpciones.Items.Add("Kilogramos a gramos");
            comboOpciones.Items.Add("Gramos a kilogramos");
        }

        private void Convertidor_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmprinci.cambiarestado(true);
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double valor;
            if (!double.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Ingresa un numero valido");
                return;
            }
            if (comboOpciones.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una opcion de conversion");
                return;
            }

            double resultado = 0;
            switch (comboOpciones.SelectedIndex)
            {
                case 0: resultado= valor * 100; break;
                case 1: resultado= valor / 100; break;
                case 2: resultado= valor * 1000; break;
                case 3: resultado= valor / 1000; break;
            }

            lblResultado.Text = "Resultado: " + resultado;


        }
    }
}
