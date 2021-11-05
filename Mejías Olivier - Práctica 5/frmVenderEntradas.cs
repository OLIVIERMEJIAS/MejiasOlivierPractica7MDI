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
    public partial class frmVenderEntradas : Form
    {
        Global glob = new Global();
        static bool venderGen = false;
        static bool venderGram = false;
        static bool venderPal = false;
        static int entradComp;
        public frmVenderEntradas()
        {
            InitializeComponent();
        }
       //método que asignar entradas una vez que se haya validado una o más
       //cantidad de entradas a asignar de cada tipo, al asignar
       //una entrada esta entra en el array de entrdas de cada ckliente y
       //se borra del array global del tipo de entrda que se asigne(n)
        private void btnAsignar_Click(object sender, EventArgs e)
        {

            foreach (Cliente cli in glob.clienteConsultar())
            {
                if (txtCedulaAsignar.Text == cli.cedulaConsultar())
                {
                    if (venderGen)
                    {
                        for (int i = 0; i < int.Parse(txtNumGen.Text); i++)
                        {
                            cli.entradasConsultar().Add(glob.generalConsultar()[0]);
                            glob.generalQuitar();
                        }
                        cli.modificarEntradasDisponibles(int.Parse(txtNumGen.Text));
                        entradComp = cli.entradCompConsultar();
                        venderGen = false;
                    }

                    if (venderGram)
                    {
                        for (int i = 0; i < int.Parse(txtNumGram.Text); i++)
                        {
                            cli.entradasConsultar().Add(glob.gramillaConsultar()[0]);
                            glob.gramillaQuitar();
                        }
                        cli.modificarEntradasDisponibles(int.Parse(txtNumGram.Text));
                        entradComp = cli.entradCompConsultar();
                        venderGram = false;
                    }

                    if (venderPal)
                    {
                        for (int i = 0; i < int.Parse(txtNumPal.Text); i++)
                        {
                            cli.entradasConsultar().Add(glob.palcoConsultar()[0]);
                            glob.palcoQuitar();
                        }
                        cli.modificarEntradasDisponibles(int.Parse(txtNumPal.Text));
                        //entradComp = cli.entradCompConsultar();
                        venderPal = false;
                    }

                    txtMensajeAsignar.Text = "Felicidades Entrada(as) asignadas";

                }


            }
        }
        //método que valida que el número requerido de entradas sea viable
        //valida que las solicitas no excedan las existentes
        //valida que no sean cero o menos, o mayor a tres
        //valida que el cliente tenga para comprar igual a más entrdas
        public bool validarNumEntradas(int numEntradas,TextBox control)
        {
            if (numEntradas > glob.generalConsultar().Count)
            {
                txtMensajeAsignar.Text = $"No hay suficientes entradas de este tipo, se dispone de: {glob.generalConsultar().Count}";
                control.Enabled = false;
                return false;
            }
            else if (numEntradas <= 0 || numEntradas > 3)
            {
                txtMensajeAsignar.Text = "Su número de entradas es invalida, solo números de 1-3 máximo";
                return false;
            }
            else if (numEntradas > entradComp)
            {
                txtMensajeAsignar.Text = $"No hay suficientes entradas restantes para este cliente, solo tiene: {entradComp}";
                return false;
            }
            else
                txtMensajeAsignar.Text = "Valor de entrada(as) valido";
                return true;

        }
        //método que se desencadena al clickear el botón validar de tipo General
        //, si el valor solictado es viable habilita el botón de asignar general y
        //vuelve true una bandera para control al asignar las entradas
        private void btnValidarGen_Click(object sender, EventArgs e)
        {
            if(validarNumEntradas(int.Parse(txtNumGen.Text),txtNumGen))
            {
                btnAsignar.Enabled = true;
                venderGen = true;
            }
        }

        //método que se desencadena al clickear el botón validar de tipo Gramilla
        //, si el valor solictado es viable habilita el botón de asignar general y
        //vuelve true una bandera para control al asignar las entradas
        private void btnValidarGram_Click(object sender, EventArgs e)
        {
            if (validarNumEntradas(int.Parse(txtNumGram.Text), txtNumGram))
            {
                btnAsignar.Enabled = true;
                venderGram = true;
            }
        }

        //método que se desencadena al clickear el botón validar de tipo PalcoVIP
        //, si el valor solictado es viable habilita el botón de asignar general y
        //vuelve true una bandera para control al asignar las entradas
        private void btnValidarPal_Click(object sender, EventArgs e)
        {
            if (validarNumEntradas(int.Parse(txtNumPal.Text), txtNumPal))
            {
                btnAsignar.Enabled = true;
                venderPal = true;
            }
        }

        //método que valida que la cédula del cliente al que se
        //desean asignar entrdas, exista en registros
        private void btnValidarCedula_Click(object sender, EventArgs e)
        {
            foreach (Cliente cli in glob.clienteConsultar())
            {
                if (txtCedulaAsignar.Text == cli.cedulaConsultar())
                {
                    entradComp = cli.entradCompConsultar();
                    txtNumGen.Enabled = true;
                    txtNumGram.Enabled = true;
                    txtNumPal.Enabled = true;
                }
            }
        }
    }
}
