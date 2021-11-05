using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mejías_Olivier___Práctica_5
{
    class PalcoVIP:Entrada
    {
        static int cantidad = 0;
        int ID = 0;
        int bebidas;
        
        //constructor
        /// <summary>
        /// Construye una instancia tipo PalcoVIP, con valores de 
        /// entrada: evento, precio, bebidas, tipo
        /// </summary>
        /// <param name="eve"></param>
        /// <param name="prec"></param>
        /// <param name="cantiBeb"></param>
        /// <param name="tipo"></param>
        public PalcoVIP(string eve, double prec, int cantiBeb,string tipo) : base(eve, prec,tipo)
        {

            cantidad += 1;
            ID = cantidad;
            bebidas = cantiBeb;
            
        }

        //Implementar Métodos Abstractos
        /// <summary>
        /// Devuelve el atributo static cantidad, que se refiere a la cantidad 
        /// global de entrdas creadas de clase PalcoVIP
        /// </summary>
        /// <returns></returns>
        public override int cantidadEntradas()
        {
            return cantidad;
        }
        /// <summary>
        /// Devuelve un mensaje al adquirir una entrada de este tipo
        /// </summary>
        /// <returns></returns>
        public override string mensajeAlCliente()
        {
            return "Excelente, has comprado una entrada PalcoVIP!!! Felicitaciones";
        }

        /// <summary>
        /// Resta y actualiza el número de bedidas al que tiene 
        /// acceso un dueño de una entrada PalcoVIP
        /// </summary>
        /// <param name="beb"></param>
        public void restarBebidas(int beb)
        {
            bebidas -= beb;
        }
        /// <summary>
        /// Devuelve un bool si quedan bebidas que pueda consumir el dueño de una entrada PalcoVIP
        /// </summary>
        /// <returns></returns>
        public bool quedanBebidas()
        {
            if (bebidas > 0)
                return true;
            else
                return false;
        }
    }
}
