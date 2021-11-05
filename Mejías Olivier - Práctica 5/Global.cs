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
        /// <summary>
        /// Construye un objeto tipo Global
        /// </summary>
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
        /// <summary>
        /// Agrega una entrada tipo PalcoVIP al arreglo
        /// </summary>
        /// <param name="gen"></param>
        public void palcoAgregar(PalcoVIP gen)
        {
            entradasPalco.Add(gen);
        }
        /// <summary>
        /// Devuelve el arreglo de entradas tipo PalcoVIO
        /// </summary>
        public ArrayList palcoConsultar()
        {
            return entradasPalco;
        }
        /// <summary>
        /// Elimina una entrada tipo PalcoVIP
        /// </summary>
        public void palcoQuitar()
        {
            entradasPalco.Remove(0);
        }
        //CRUD entradas Generales
        /// <summary>
        /// Agrega una entrada tipo General al arreglo
        /// </summary>
        public void generalAgregar(General gen)
        {
            entradasGeneral.Add(gen);
        }
        /// <summary>
        /// Devuelve el arreglo de entradas tipo General
        /// </summary>
        public ArrayList generalConsultar()
        {
            return entradasGeneral;
        }
        /// <summary>
        /// Elimina una entrada tipo General del arreglo
        /// </summary>
        public void generalQuitar()
        {
            entradasGeneral.Remove(0);
        }
        //CRUD entradas Gramilla
        /// <summary>
        /// Agrega una entrada tipo Gramilla al arreglo
        /// </summary>
        public void gramillaAgregar(Gramilla gram)
        {
            entradasGramilla.Add(gram);
        }
        /// <summary>
        /// Devuelve el arreglo de entradas tipo Gramilla
        /// </summary>
        public ArrayList gramillaConsultar()
        {
            return entradasGramilla;
        }
        /// <summary>
        /// Elimina una entrada tipo Gramilla del arreglo
        /// </summary>
        public void gramillaQuitar()
        {
            entradasGramilla.Remove(0);
        }

        //CRUD Clientes
        /// <summary>
        /// Agrega un cliente tipo Cliente al arreglo
        /// </summary>
        public void clienteAgregar(Cliente cli)
        {
            clientes.Add(cli);
        }
        /// <summary>
        /// Devuelve un arreglo con clientes tipo Cliente
        /// </summary>
        public ArrayList clienteConsultar()
        {
            return clientes;
        }
        /// <summary>
        /// Elimina un cliente tipo Cliente del arreglo
        /// </summary>
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
