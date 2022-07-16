/* 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares. */
using System;

namespace ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int evenNumbers;

            loadNumbers(ref numbers);
            evenNumbers = evenNumberCounters(numbers);
            Console.WriteLine("Total of even numbers: " + evenNumbers);
        }

        static int evenNumberCounters(int[] numbers)
        {
            int counters = 0;
            for(int i=0;i<20;i++){
                if(par(numbers[i]) == 1){
                    counters++;
                }
            }
            return counters;
        }

        static void loadNumbers(ref int[] numbers)
        {
            for(int i=0; i<20;i++){
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        static int par(int num)
        {
            if(num%2 == 0)
                return 1;
            return 0;
        }
    }
}
