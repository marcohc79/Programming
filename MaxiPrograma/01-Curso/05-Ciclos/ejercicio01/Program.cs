using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
/* 1. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos. */
            Console.WriteLine("For");
            for(int i=1; i < 11; i++){
                Console.WriteLine(i);
            }

            Console.WriteLine("While");
            int a=1;
            while(a <= 10){
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
