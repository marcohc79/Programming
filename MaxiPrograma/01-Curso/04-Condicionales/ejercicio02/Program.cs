using System;

namespace ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            float liters, amount;
            float result = 0;

            Console.WriteLine("Liters: ");
            liters = int.Parse(Console.ReadLine());
            Console.WriteLine("Amount: ");
            amount = int.Parse(Console.ReadLine());

            /* Si vende menos de 100 litros, no hay descuento. */
            /* Si vende entre 101 y 300 litros, el descuento es del 10%. */
            /* Si vende entre 301 y 500 litros, el descuento es del 15%. */
            /* Finalmente, si la venta es de más de 500 litros, el descuento es del 25%. */

            if (liters > 500)
                result = amount*(1-0.25F);
            else if (liters > 300 && liters <= 500)
                result = amount * (1-0.15F);
            else if (liters > 100 && liters <=300)
                result = amount * (1-0.10F);
            else
                result = amount;

            Console.WriteLine("Total: "+result);
        }
    }
}
