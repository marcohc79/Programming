/* 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función. */
using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceProduct=0, quantitySold=0, result=0;
            requestData(ref priceProduct, ref quantitySold);
            result = producto(priceProduct, quantitySold);

            Console.WriteLine("Total to pay: " + result);
        }


        static void requestData(ref int priceProduct, ref int quantitySold)
        {
            Console.WriteLine("Price of product: ");
            priceProduct = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantity sold: ");
            quantitySold = int.Parse(Console.ReadLine());
        }

        static int producto(int num01, int num02)
        {
           return num01 * num02;
        }
    }
}
