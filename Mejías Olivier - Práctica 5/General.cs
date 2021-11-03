using System;
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

        public General(string eve, double prec):base(eve,prec)
        {
            cantidad += 1;
        }

        //Implementar Métodos Abstractos

        public override int cantidadEntradas()
        {
            return cantidad;
        }

        public override string mensajeAlCliente()
        {
            return "Excelente, has comprado una entrada General!!! Felicitaciones";
        }
    }
}
