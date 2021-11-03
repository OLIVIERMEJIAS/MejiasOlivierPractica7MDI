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

        public PalcoVIP(string eve, double prec, int cantiBeb) : base(eve, prec)
        {

            cantidad += 1;
            ID = cantidad;
            bebidas = cantiBeb;
            
        }

        //Implementar Métodos Abstractos

        public override int cantidadEntradas()
        {
            return cantidad;
        }

        public override string mensajeAlCliente()
        {
            return "Excelente, has comprado una entrada PalcoVIP!!! Felicitaciones";
        }

        public void restarBebidas(int beb)
        {
            bebidas -= beb;
        }

        public bool quedanBebidas()
        {
            if (bebidas > 0)
                return true;
            else
                return false;
        }
    }
}
