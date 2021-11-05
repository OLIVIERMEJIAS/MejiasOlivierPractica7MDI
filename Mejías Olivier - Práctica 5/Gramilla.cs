using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mejías_Olivier___Práctica_5
{
    class Gramilla:Entrada
    {
        static int cantidad = 0;

        string amenidades;

        //constructor
        /// <summary>
        /// Construye una instancia de tipo Gramilla, con valores de entrada: evento, precio y tipo de entrada
        /// </summary>
        /// <param name="eve"></param>
        /// <param name="prec"></param>
        /// <param name="tipo"></param>
        public Gramilla(string eve, double prec,string tipo) : base(eve, prec,tipo)
        {
            cantidad += 1;
            amenidades = "Gorra con luces";
        }

        //Implementar Métodos Abstractos
        /// <summary>
        /// Devuelve el atributo static cantidad, 
        /// que se refiere a la cantidad total de entradas creadas de clase Gramilla
        /// </summary>
        /// <returns></returns>
        public override int cantidadEntradas()
        {
            return cantidad;
        }
        /// <summary>
        /// Devuelve un mensaje al asignar una entrada de tipo Gramilla
        /// </summary>
        /// <returns></returns>
        public override string mensajeAlCliente()
        {
            return "Excelente, has comprado una entrada Gramilla!!! Felicitaciones";
        }
        /// <summary>
        /// Establece que amenidad se adquiere con una entrada de clase Gramilla
        /// </summary>
        /// <param name="otraAmen"></param>
        public void asignarOtraAmenidad(string otraAmen) { 
        
            amenidades = otraAmen;
        }
    }
}
