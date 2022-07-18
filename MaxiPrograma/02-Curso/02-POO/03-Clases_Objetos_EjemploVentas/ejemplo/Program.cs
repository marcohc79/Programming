using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Primer lote con 10 registros de productos, cada producto tienen:
            //                - Código Artículo (3 dígitos NonSerializedAttribute correlativos)
            //                - Precio
            //                - Código de Marca (1 a 10)
            //            Segundo lote con las ventas de la semana. Cada ventana tiene:
            //                - Código Artículo
            //                - Cantidad
            //                - Código Cliente (1 a 100)
            //            Este lote corta con Código de Cliente cero.


            Articulo[] articulos = new Articulo[10];

            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto.");
                Console.WriteLine("Código: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10)");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
            }
            // Carga el vector completo con los 10

            Venta venta = new Venta();

            Console.WriteLine("Ingrese la venta: ");
            Console.Write("Código de Cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.Write("Condigo Artículo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //trabajamos...

                //pido cliente nuevamente
                Console.WriteLine("Ingrese la venta: ");
                Console.Write("Código de Cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
