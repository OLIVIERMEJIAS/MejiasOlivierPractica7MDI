using System;
using System.Collections;
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
    public partial class frmSuperTickets : Form
    {

       
        frmEntradas crear;
        frmClientes cli;
        frmVenderEntradas venderEntrad;
        
        public frmSuperTickets()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCrearEntradas_Click(object sender, EventArgs e)
        {
            if (crear == null)
            {
                crear = new frmEntradas();//instanciar
                crear.MdiParent = this;
                //delegado
                crear.FormClosed += new FormClosedEventHandler(cerrarFormulario);
                crear.Show();
            }
            else
                crear.Activate();
        }

        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            crear = null;
        }

        private void cerrarFormularioClientes(object sender, FormClosedEventArgs e)
        {
            cli = null;
        }

        private void cerrarFormularioVenderEntradas(object sender, FormClosedEventArgs e)
        {
            venderEntrad = null;
        }
        private void administrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cli == null)
            {
                cli = new frmClientes();//instanciar
                cli.MdiParent = this;
                //delegado
                cli.FormClosed += new FormClosedEventHandler(cerrarFormularioClientes);
                cli.Show();
            }
            else
                cli.Activate();
        }

        private void mnuAsignarEntradas_Click(object sender, EventArgs e)
        {
            if (venderEntrad == null)
            {
                venderEntrad = new frmVenderEntradas();//instanciar
                venderEntrad.MdiParent = this;
                //delegado
                venderEntrad.FormClosed += new FormClosedEventHandler(cerrarFormularioVenderEntradas);
                venderEntrad.Show();
            }
            else
                venderEntrad.Activate();
        }
    }
}
