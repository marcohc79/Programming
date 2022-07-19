//Agregale los siguientes atributos:
//    Modelo string.
//    Marca string.
//    NumeroTelefonico string.
//    CodigoOperador int(1, 2 o 3).
//    Agregale las propiedades correspondientes. Podés hacer el formato largo o el corto.
//    Modelo: solo lectura.Es decir, solo get.
//    Marca: solo lectura.
//    NumeroTelefonico: lectura y escritura.
//    CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
//    Agregar Constructor que reciba Modelo y Marca.
//    Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
//    Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
//    Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ejercicio
{
    internal class Telefono
    {
        private string numeroTelefonico;
        private int codigoOperador;
        public string Modelo { get; }
        public string Marca { get; }
        
        public Telefono(string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }

        // private string modelo;
        // private string marca;

        // public string Modelo
        // {
        //     get { return modelo; }
        // }
        //
        // public string Marca
        // {
        //     get { return marca; }
        // }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if(value >= 1 && value <=3)
                    codigoOperador = value;
                else
                    codigoOperador = -1;
            }
        }

        public string Llamar()
        {
            return "Realizando llamada...";
        }

        public string Llamar(string contacto)
        {
            return "Lamando a " + contacto;
        }
    }
}
