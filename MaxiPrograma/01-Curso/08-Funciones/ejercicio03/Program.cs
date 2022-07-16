/* 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos. */
using System;

namespace ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,average, counter; 
            average = 0;
            counter = 0;

            num = int.Parse(Console.ReadLine());
            while(num != 0){
               if(primo(num)==1){
                   counter++;
                   average += num;
               }
               num = int.Parse(Console.ReadLine());
            }
            average = average / counter;
            Console.WriteLine("Average prime: " + average);
        }

        static int primo(int num){
            if(num<2)
                return 0;
            for(int i=2; i<num;i++){
                if(num%i==0)
                    return 0;
            }
            return 1;
        }
    }
}
