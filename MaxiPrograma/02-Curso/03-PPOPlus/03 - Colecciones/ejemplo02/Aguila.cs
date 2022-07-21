using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02
{
    internal class Aguila : AnimalSalvaje, Flyable
    {
        public string volar()
        {
            return "Volar como un aguila...";
        }
    }
}
