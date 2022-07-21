using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal01 = new Animal();
            AnimalDomestico animalDomestico01 = new AnimalDomestico();
            Gato gato01 = new Gato();
            Tigre tigre01 = new Tigre();
            Pez pez01 = new Pez();
            Perro perro01 = new Perro();

            List<Animal> animales = new List<Animal>();

            animales.Add(gato01);
            animales.Add(tigre01);
            animales.Add(pez01);
            animales.Add(perro01);
            animales.Add(perro01);
            animales.Add(new Aguila());
            animales.Add(new Canario());

            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Aguila());
            listaVoladores.Add(new Canario());
             

            /*foreach (Animal itemsAnimal in animales)
            {
                Console.WriteLine(itemsAnimal.comunicarse());
            }*/




            Console.WriteLine(gato01.comunicarse());

            animalDomestico01.Nombre = "Pepe el grillo";

            Console.WriteLine(animalDomestico01.ToString());
            Console.WriteLine(animalDomestico01.comunicarse());
        }
    }
}
