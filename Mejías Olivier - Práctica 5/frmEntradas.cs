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

        private void btnCrearEntradas_Click(object sender, EventArgs e)
            {
                for (int i = 0; i < Convert.ToInt32(txtEntradGra.Text); i++)
                {
                    General miGeneral = new General(txtEntradGen.Text,
                        Convert.ToDouble(txtValorGen.Text));

                
                }

                for (int i = 0; i < Convert.ToInt32(txtEntradGra.Text); i++)
                {
                    Gramilla miGramilla = new Gramilla(txtEntradGra.Text,
                        Convert.ToDouble(txtValorGra.Text));

                    
                }

                for (int i = 0; i < Convert.ToInt32(txtEntradGra.Text); i++)
                {
                    PalcoVIP miPalco = new PalcoVIP(txtEntradGra.Text,
                        Convert.ToDouble(txtValorGra.Text),5);

                    
                }

               
        }
    }
}
