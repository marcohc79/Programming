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


        //creo un metodo.
        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }
    }
}
