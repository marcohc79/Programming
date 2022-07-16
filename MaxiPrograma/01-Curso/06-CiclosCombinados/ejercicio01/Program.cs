/* 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos. */
using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, primeNumberCounter=0, counter=0;

            for(int i=0; i<10; i++){
                Console.WriteLine("Enter number: ");
                num = int.Parse(Console.ReadLine());

                for(int j=2; j<num; j++ ){
                    if(num%j == 0){
                        counter ++;
                        break;
                    }
                }
                if (counter == 0 && num > 1)
                    primeNumberCounter ++;
        }
            Console.WriteLine("Number of prime numbers: " + primeNumberCounter);
        
        }
    }
}

