using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: Edad, Sueldo, Nombre
            Persona persona01 = new Persona("Marco");
            persona01.setEdad(31);
            Console.WriteLine("La edad de la persona es: " + persona01.getEdad());
            Console.WriteLine(persona01.saludar());








            // VEMOS COMO CREAR METODOS
            //Botella botella01 = new Botella("Plastico", "Rojo");
            //botella01.Capacidad = 200;

            //int algo = botella01.Capacidad;
            //Console.WriteLine(algo);
            //Console.WriteLine("La cantidad actual es: " + botella01.CantidadActual);
            //botella01.recargar();
            //Console.WriteLine("La cantidad actual es: " + botella01.CantidadActual);





            //Mi perro
            //Perro miPerro = new Perro();
            //miPerro.Color = "Rojo";
            //miPerro.Nombre = "Oso";
            //miPerro.Origen = "Marte";

            //Console.WriteLine("Mi perro se llama "+ miPerro.Nombre + " con origen de " + miPerro.Origen);
        }
    }
}
