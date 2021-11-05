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
    public partial class frmEntradas : Form
    {
        public frmEntradas()
        {
            InitializeComponent();
        }
        //método que toma el nombre del evento, el número y el valor de
        //cada tipo de entrada y las crea,
        //insertando cada nuevo objeto en un array global de cda tipo de entrada
        private void btnCrearEntradas_Click(object sender, EventArgs e)
            {
                Global miGlobal = new Global();

                for (int i = 0; i < Convert.ToInt32(txtEntradGen.Text); i++)
                {
                    General miGeneral = new General(txtEntradGen.Text,
                    Convert.ToDouble(txtValorGen.Text),"General");
                     miGlobal.generalAgregar(miGeneral);
                
                }

                for (int i = 0; i < Convert.ToInt32(txtEntradGra.Text); i++)
                {
                    Gramilla miGramilla = new Gramilla(txtEntradGra.Text,
                        Convert.ToDouble(txtValorGra.Text), "Gramilla");
                    miGlobal.gramillaAgregar(miGramilla);

                }

                for (int i = 0; i < Convert.ToInt32(txtEntradPal.Text); i++)
                {
                    PalcoVIP miPalco = new PalcoVIP(txtEntradPal.Text,
                        Convert.ToDouble(txtValorPal.Text),5,"PalcoVIP");
                    miGlobal.palcoAgregar(miPalco);

                    
                }

               
        }
    }
}
