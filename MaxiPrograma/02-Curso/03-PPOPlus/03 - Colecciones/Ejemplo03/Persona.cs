using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03
{
    // Se convierte en una clase abstracta y por lo tanto no se puede crear una instancia. Pero si las clases hijas.
    abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
    }
}
