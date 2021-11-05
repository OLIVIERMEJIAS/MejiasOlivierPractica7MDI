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
        int entradasDisponibles;
        bool activo;
        ArrayList misEntradas;
        /// <summary>
        /// Construye una instancia cliente de tipo Cliente, con datos predeterminados
        /// </summary>
        public Cliente()
        {
            ID += 1; 
            cedula = "";
            nombre = "";
            apellido1 = "";
            apellido2 = "";
            entradasDisponibles = 3;
            activo = true;
            misEntradas = new ArrayList();

        }
        /// <summary>
        /// Construye una instancia cliente de tipo Cliente, con algunos valores
        /// inicializados de entrada del usuario
        /// </summary>
        /// <param name="ced"></param>
        /// <param name="nom"></param>
        /// <param name="ape1"></param>
        public Cliente(string ced,string nom,string ape1)
        {
            ID += 1;
            cedula = ced;
            nombre = nom;
            apellido1 = ape1;
            apellido2 = "";
            entradasDisponibles = 3;
            activo = true;
            misEntradas = new ArrayList();

        }
        /// <summary>
        /// Resta entradas compradas al inicial de 3 disponibles para compra
        /// </summary>
        /// <param name="menosEntradas"></param>
        public void modificarEntradasDisponibles(int menosEntradas)
        {
            entradasDisponibles -= menosEntradas;
        }
        /// <summary>
        /// Devuelve el atributo ID
        /// </summary>
        /// <returns></returns>
        public int IDConsultar()
        {
            return ID;
        }
        /// <summary>
        /// Devuelve el atributo cedula
        /// </summary>
        /// <returns></returns>
        public string cedulaConsultar()
        {
            return cedula;
        }
        /// <summary>
        /// Devuelve el atributo nombre
        /// </summary>
        /// <returns></returns>
        public string nombreConsultar()
        {
            return nombre;
        }
        /// <summary>
        /// Devuelve el atributo apellido1
        /// </summary>
        /// <returns></returns>
        public string ape1Consultar()
        {
            return apellido1;
        }
        /// <summary>
        /// Devuelve el atributo apellido2
        /// </summary>
        /// <returns></returns>
        public string ape2Consultar()
        {
            return apellido2;
        }
        public int entradCompConsultar()
        {
            return entradasDisponibles;
        }
        /// <summary>
        /// Devuelve el atributo activo
        /// </summary>
        /// <returns></returns>
        public bool activoConsultar()
        {
            return activo;
        }
        /// <summary>
        /// Borra una entrada del objeto cliente, de su atributo array de entradas
        /// </summary>
        /// <param name="entrada"></param>
        public void borrarEntrada(Entrada entrada)
        {
            misEntradas.RemoveAt(misEntradas.IndexOf(entrada));
        }
        /// <summary>
        /// Devuelve el array de entrada que tiene  cada objeto Cliente como atributo
        /// </summary>
        /// <returns></returns>
       public ArrayList entradasConsultar()
        {
            return misEntradas;
        }
    }
}
