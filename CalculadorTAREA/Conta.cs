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
    public partial class Conta : Form
    {
        Principal principal;
        public Conta(Principal frm)
        {
            InitializeComponent();
            principal = frm;
        }
    }
}
