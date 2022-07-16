/* Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar: */

/* a. El mayor de los números pares. */
/* b. La cantidad de números impares. */
/* c. El menor de los números primos. */

using System;

namespace TPFinal_HuamaniCaballero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, mayorNumeroPar, cantidadImpares, menorNumeroPrimo;
            bool estadoPrimo;
            
            mayorNumeroPar = 0;
            cantidadImpares = 0;
            estadoPrimo = false;

            Console.WriteLine("Enter number (0=Salir): ");
            num = int.Parse(Console.ReadLine());

            menorNumeroPrimo = num;

            while(num != 0){
                contarNumerosImpares(ref cantidadImpares, num, ref mayorNumeroPar);
                buscarMenorNumeroPrimo(ref menorNumeroPrimo, num, ref estadoPrimo);
                

                Console.WriteLine("Enter number (0=Salir): ");
                num = int.Parse(Console.ReadLine());
            }


            if (mayorNumeroPar == 0)
                Console.WriteLine("No hay numeros pares.");
            else
                Console.WriteLine("El mayor número par: " + mayorNumeroPar);

            if (cantidadImpares == 0)
                Console.WriteLine("No hay numeros impares");
            else
                Console.WriteLine("Cantidad de números impares: " + cantidadImpares);

            if (estadoPrimo)
                Console.WriteLine("El menor número primo es: " + menorNumeroPrimo);
            else
                Console.WriteLine("No hay numero primos.");
        }
        
        static void contarNumerosImpares(ref int cantidadImpares, int num, ref int mayorNumeroPar)
        {
            if(num%2 != 0)
                cantidadImpares += 1;
            else
                buscarMayorNumeroPar(ref mayorNumeroPar, num);
        }

        static void buscarMayorNumeroPar(ref int mayorNumeroPar, int num)
        {
            if(num%2 == 0 && mayorNumeroPar < num)
                mayorNumeroPar = num; 
        }

        static void buscarMenorNumeroPrimo(ref int menorNumeroPrimo, int num, ref bool estadoPrimo)
        {
            bool siEsPrimo; 
            siEsPrimo = esPirmo(num);

            if(siEsPrimo)
                estadoPrimo = true;

            if(siEsPrimo && menorNumeroPrimo > num)
                menorNumeroPrimo = num;

        }

        static bool esPirmo(int num)
        {
            for(int i=2; i<num; i++){
                if(num%i == 0)
                    return false;
            }
            return true;
        }
    }
}
