using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01
{
    internal class Persona
    {
        
        //Atribuso o Miembreos
        private int edad;
        private float sueldo;
        private string nombre;


        public Persona(string nombre)
        {
            this.nombre = nombre;
        }




        //creo un metodo.
        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        // Metodos
        public string saludar()
        {
            return "Hola soy ..." + nombre;
        }

        public string saludar(string personaje)
        {
            return "Hola " + personaje+ " soy " + this.nombre;
        }
    }
}
