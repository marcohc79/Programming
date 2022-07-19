using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01
{
    internal class Botella
    {
        //Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;


        // Creo un constructor
        public Botella(string material, string color)
        {
            this.material = material;
            this.color = color;
            capacidad = 100;
            cantidadActual = 0;
        }

        // Sobre cargo el constructor
        public Botella() {}
        
        
        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}
        
        // Metodo
        public  float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = 100 - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }
    }


}
