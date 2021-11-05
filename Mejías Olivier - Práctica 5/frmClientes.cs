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
        Global glob = new Global();
        public frmClientes()
        {
            InitializeComponent();
        }
        //método que lista un cliente, con base en la cédula y forma el registro en el ListView
        private void btnListarCli_Click(object sender, EventArgs e)
        {
            foreach (Cliente cli in glob.clienteConsultar())
                if (txtDatoCedulaCliente.Text == cli.cedulaConsultar())
                {
                    lvwEntradas.Items.Clear();
                    lvwClientes.Items.Clear();
                    ListViewItem lista;
                    ListViewItem entradas;
                    lista = new ListViewItem(cli.IDConsultar().ToString());
                    lista.SubItems.Add(cli.cedulaConsultar());
                    lista.SubItems.Add(cli.nombreConsultar());
                    lista.SubItems.Add(cli.ape1Consultar());
                    lista.SubItems.Add(cli.ape2Consultar());
                    lista.SubItems.Add(cli.entradCompConsultar().ToString());
                    lista.SubItems.Add(cli.activoConsultar().ToString());
                    lvwClientes.Items.Add(lista);
                    if (cli.entradasConsultar().Count != 0)
                    {
                        foreach (Entrada entrad in cli.entradasConsultar())
                        {
                            entradas = new ListViewItem(entrad.tipoConsultar());
                            entradas.SubItems.Add(entrad.eventoConsultar());
                            entradas.SubItems.Add(entrad.precioConsultar());
                            lvwEntradas.Items.Add(entradas);
                        }
                    }
                }
            
            
        }
        //método que agrega un cliente formando una instancia de tipo
        //Cliente y agregando al array de clientes
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente(txtDatoCedulaCliente.Text,txtNombreAsignar.Text,txtPrimerApellido.Text);
            glob.clienteAgregar(cli);
        }

        //método que elimina un objeto tipo CLiente del array de clientes
        private void btnElimCli_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwClientes.SelectedItems)
            {
                
                foreach (Cliente cli in glob.clienteConsultar())
                {
                    if (item.GetSubItemAt(item.Index, 1).Text == cli.cedulaConsultar())
                    {
                        glob.clienteQuitar(cli);
                    }
                }
                item.Remove();
            }

        }

     //método que lista todos los clientes guardados en el array global de
     //clientes, el cual forma ,los registros en un ListView.
        private void btnListarTodosCli_Click(object sender, EventArgs e)
        {
            lvwEntradas.Items.Clear();
            lvwClientes.Items.Clear();
            ListViewItem lista;
            foreach(Cliente cli in glob.clienteConsultar())
            {
                lista = new ListViewItem(cli.IDConsultar().ToString());
                lista.SubItems.Add(cli.cedulaConsultar());
                lista.SubItems.Add(cli.nombreConsultar());
                lista.SubItems.Add(cli.ape1Consultar());
                lista.SubItems.Add(cli.ape2Consultar());
                lista.SubItems.Add(cli.entradCompConsultar().ToString());
                lista.SubItems.Add(cli.activoConsultar().ToString());
                lvwClientes.Items.Add(lista);
            }
        }

        
    }
}
