using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        // Sobre escribir un metodo
        public  override string ToString()
        {
            return "Animal: " + Nombre;
        }
    }
}
