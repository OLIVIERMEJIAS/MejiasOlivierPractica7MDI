using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mejías_Olivier___Práctica_5
{
    public partial class VenderEntradas : Form
    {
        Global glob;
        public VenderEntradas()
        {
            InitializeComponent();
        }


        private void btnValidarEntradas_Click(object sender, EventArgs e)
        {
            if (validarCedula())
            {
                txtAsignarNumGenerales.Enabled = true;
                txtAsignarNumGramilla.Enabled = true;
                txtAsignarNumPalcoVip.Enabled = true;
            }
        }

        private bool validarCedula()
        {
            foreach (Cliente cli in glob.clienteConsultar())
                if (txtCedulaAsignar.Text == cli.cedulaConsultar())
                    return true;
            return false;
        }
    }
}
