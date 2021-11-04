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
    public partial class frmClientes : Form
    {
        Global glob;
        VenderEntradas vendEntrad;
        public frmClientes()
        {
            InitializeComponent();
        }

        private bool validarCedula(string cedula)
        {
            foreach (Cliente cli in glob.clienteConsultar())
                if (cedula == cli.cedulaConsultar())
                    return true;
            return false;
        }
        private void btnListarCli_Click(object sender, EventArgs e)
        {
            glob = new Global();
            vendEntrad = new VenderEntradas();
            if(validarCedula(txtDatoCedulaCliente.Text))
            {

            }
            
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente(txtDatoCedulaCliente.Text,txtNombreAsignar.Text,txtPrimerApellido.Text);
            glob = new Global();
            glob.clienteAgregar(cli);
        }

        private void btnElimCli_Click(object sender, EventArgs e)
        {
            glob = new Global();
            vendEntrad = new VenderEntradas();
            if (validarCedula(txtDatoCedulaCliente.Text))
            {
                //glob.clienteQuitar
            }
        }
    }
}
