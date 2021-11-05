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
        private string tipo;

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
        
        public Entrada(string ev, double monto,string tip)
        {
            evento = ev;
            precio = monto;
            tipo = tip;

        }

        /// <summary>
        /// Actualizar el nombre del Evento.Recibe como entrada el nuevo nombre.
        /// </summary>
        /// <param name="nuevoNombreEvento"></param>
        public void actualizarEvento(string nuevoNombreEvento)
        {
            evento = nuevoNombreEvento;
        }
        /// <summary>
        /// Devuelve el nombre del evento de una entrada de cualquier clase heredera
        /// </summary>
        /// <returns></returns>
        public string eventoConsultar()
        {
            return evento;
        }
        /// <summary>
        /// Devuelve el precio de una entrada de cualquier clase heredera
        /// </summary>
        /// <returns></returns>
        public string precioConsultar()
        {
            return precio.ToString();
        }
        /// <summary>
        /// Devuelve el tipo de una entrada de cualquier clase heredera
        /// </summary>
        /// <returns></returns>
        public string tipoConsultar()
        {
            return tipo;
        }
        //método abstracto para devolver cada cantidad global de
        //entradas de un tipo de clase específica que será omplementado en cada clase heredera
        public abstract int cantidadEntradas();
        //método abstracto para devolver un mensaje al asignar una entrada
        //será omplementado en cada clase heredera
        public abstract string mensajeAlCliente();

    }
}
