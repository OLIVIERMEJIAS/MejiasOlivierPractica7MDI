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

        public Gramilla(string eve, double prec,string tipo) : base(eve, prec,tipo)
        {
            cantidad += 1;
            amenidades = "Gorra con luces";
        }

        //Implementar Métodos Abstractos

        public override int cantidadEntradas()
        {
            return cantidad;
        }

        public override string mensajeAlCliente()
        {
            return "Excelente, has comprado una entrada Gramilla!!! Felicitaciones";
        }

        public void asignarOtraAmenidad(string otraAmen) { 
        
            amenidades = otraAmen;
        }
    }
}
