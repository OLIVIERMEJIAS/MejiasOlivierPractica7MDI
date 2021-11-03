using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mejías_Olivier___Práctica_5
{
    abstract class Entrada
    {
        //atributos
        private string evento;
        private double precio;

        //Crear clase
        //Crear definir atributos
        //Modificadores de Acesso


        //TODO: Cambiar a clase Abstracta


        /// <summary>
        /// Este es el constructor de la clase Entrada. Parámetros ev = Nombre del evento, y 
        /// monto = Precio de la Entrada
        /// </summary>
        /// <param name="ev">Este es el nombre del evento</param>
        /// <param name="monto">Costo de la Entrada</param>
        /// <remarks>Hola esto es una marca</remarks>
        public Entrada(string ev, double monto)
        {
            evento = ev;
            precio = monto;
        }

        /// <summary>
        /// Actualizar el nombre del Evento.Recibe como entrada el nuevo nombre.
        /// </summary>
        /// <param name="nuevoNombreEvento"></param>
        public void actualizarEvento(string nuevoNombreEvento)
        {
            evento = nuevoNombreEvento;
        }

        public abstract int cantidadEntradas();

        public abstract string mensajeAlCliente();

    }
}
