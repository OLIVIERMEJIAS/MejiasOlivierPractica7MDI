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
        int ID = 0;
        int cedula;
        string nombre;
        string apellido1;
        string apellido2;
        bool activo;
        int entradasCompradas;
        ArrayList misEntradas;

        public Cliente()
        {
            ID += 1; 
            cedula = 0;
            nombre = "";
            apellido1 = "";
            apellido2 = "";
            activo = true;
            entradasCompradas = 0;
            misEntradas = new ArrayList();
        }

        public Cliente(int ced,string nom,string ape1)
        {
            ID += 1;
            cedula = ced;
            nombre = nom;
            apellido1 = ape1;
            misEntradas = new ArrayList();
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
