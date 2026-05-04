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
    }
}
