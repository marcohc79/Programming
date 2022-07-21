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
            /*// Vehiculo > Auto > AutoDeportivo > AutoUrbano
            //          > Camioneta
            //          > Moto
            Vehiculo vehiculo01 = new Vehiculo();
            Camioneta camioneta01 = new Camioneta();
            Camioneta camioneta02 = new Camioneta();
            Camioneta camioneta03 = new Camioneta();

            camioneta01.Color = "Amarillo";
            camioneta02.Color = "Rojo";
            camioneta03.Color = "Verde";


            // Vamos a crear una coleccion.
            List<Camioneta> listaCamionetas = new List<Camioneta>();
            // De esta forma agregamos una camioneta a nuestra lista.
            listaCamionetas.Add(camioneta01);
            listaCamionetas.Add(camioneta02);
            listaCamionetas.Add(camioneta03);

            // Eliminar elementos .Remove(caminiotena02)

            // Console.WriteLine("La cantidad de camionetases: " + listaCamionetas.Count);
            // Console.WriteLine("El color es: " + listaCamionetas[2].Color);

            // Recorrer colecciones
            foreach (Camioneta camioneta in listaCamionetas)
            {
                Console.WriteLine("Color: " + camioneta.Color);
            }*/


            // Ejemplo para Asociaciones (agregacion / composicion)
             Auto auto01 = new Auto();
             
             // Agregacion 
             auto01.Motor = new Motor();


        }
    }
}
