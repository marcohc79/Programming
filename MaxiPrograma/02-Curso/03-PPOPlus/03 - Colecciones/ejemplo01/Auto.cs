using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01
{
    internal class Auto : Vehiculo
    {
        // Composicion --> Nace con el chasis
        public Auto()
        {
            Chasis = new Chasis();
        }
        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }



        // Composicion, este auto debe nacar con el Chasis.
        public Chasis Chasis { get; set; }


        // Agregacion, esto es que el auto puede nacer sin motor y posteriormente lo agrego.
        public Motor Motor { get; set; }
    }
}
