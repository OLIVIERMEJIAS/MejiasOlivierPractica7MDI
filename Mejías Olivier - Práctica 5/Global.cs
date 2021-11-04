using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mejías_Olivier___Práctica_5
{
    internal class Global
    {
        private static ArrayList entradasPalco;
        private static ArrayList entradasGramilla;
        private static ArrayList entradasGeneral;
        private static ArrayList clientes;

        public Global()
        {
            if (entradasPalco == null && entradasGramilla == null
                && entradasGeneral == null
                && clientes == null)
            {
                entradasPalco = new ArrayList();
                entradasGramilla = new ArrayList();
                entradasGeneral = new ArrayList();
                clientes = new ArrayList();

            }
        }

        //CRUD entradas Palco
        public void palcoAgregar(PalcoVIP gen)
        {
            entradasGeneral.Add(gen);
        }

        public ArrayList palcoConsultar()
        {
            return entradasPalco;
        }

        public void palcoQuitar()
        {
            entradasPalco.Remove(0);
        }
        //CRUD entradas Generales
        public void generalAgregar(General gen)
        {
            entradasGeneral.Add(gen);
        }

        public ArrayList generalConsultar()
        {
            return entradasGeneral;
        }

        public void generalQuitar()
        {
            entradasGeneral.Remove(0);
        }
        //CRUD entradas Gramilla
        public void gramillaAgregar(Gramilla gram)
        {
            entradasGramilla.Add(gram);
        }

        public ArrayList gramillaConsultar()
        {
            return entradasGramilla;
        }

        public void gramillaQuitar()
        {
            entradasGramilla.Remove(0);
        }

        //CRUD Clientes
        public void clienteAgregar(Cliente cli)
        {
            clientes.Add(cli);
        }

        public ArrayList clienteConsultar()
        {
            return clientes;
        }

        public bool clienteQuitar(Cliente cli)
        {
            if (clientes.Contains(cli))
            {
                clientes.RemoveAt(clientes.IndexOf(cli));
                return true;
            }
            else
                return false;
        }
    }
}
