using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mejías_Olivier___Práctica_5
{
    class General:Entrada
    {
        static int cantidad = 0;
       
        //constructor
        /// <summary>
        /// Construe una instancia de tipo entrada General,
        /// revise un evento, precio y tipo de entrada
        /// </summary>
        /// <param name="eve"></param>
        /// <param name="prec"></param>
        /// <param name="tipo"></param>
        public General(string eve, double prec,string tipo):base(eve,prec,tipo)
        {
            cantidad += 1;
           
        }

        //Implementar Métodos Abstractos
        /// <summary>
        /// Devuelve la cantidad global de entradas creadas de tipo General
        /// </summary>
        /// <returns></returns>
        public override int cantidadEntradas()
        {
            return cantidad;
        }
        /// <summary>
        /// Devuelve un mensaje al asignar una entrada 
        /// </summary>
        /// <returns></returns>
        public override string mensajeAlCliente()
        {
            return "Excelente, has comprado una entrada General!!! Felicitaciones";
        }
    }
}
