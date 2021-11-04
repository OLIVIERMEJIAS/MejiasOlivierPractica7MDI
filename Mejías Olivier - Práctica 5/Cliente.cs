using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mejías_Olivier___Práctica_5
{
    class Cliente
    {
        static int ID = 0;
        string cedula;
        string nombre;
        string apellido1;
        string apellido2;
        int entradasCompradas;
        bool activo;
        Entrada[] misEntradas;

        public Cliente()
        {
            ID += 1; 
            cedula = "";
            nombre = "";
            apellido1 = "";
            apellido2 = "";
            entradasCompradas = 0;
            activo = true;
            misEntradas = new Entrada[3];
        }

        public Cliente(string ced,string nom,string ape1)
        {
            ID += 1;
            cedula = ced;
            nombre = nom;
            apellido1 = ape1;
            apellido2 = "";
            entradasCompradas = 0;
            activo = true;
            misEntradas = new Entrada[3];
        }

        public string cedulaConsultar()
        {
            return cedula;
        }
        public bool quedanEntradas(int entradCompradas,int entradasVender)
        {
            if (entradCompradas >= entradasVender)
                return false;
            else
                return true;
        }

        public void asignarEntradas(int Id, int entradCompradas, int entradasVender, string tipo)
        {
            if(quedanEntradas(entradCompradas,entradasVender) && tipo == "General")
            {
                
                    
            }
        }
    }
}
