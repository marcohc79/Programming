/* 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares. */
using System;

namespace ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,topEven=0, leastOdd=0, contOdd=0, contEven=0;

            for(int i=0; i<20; i++){
                Console.WriteLine("Enter number: ");
                num = int.Parse(Console.ReadLine());

                if(num%2 == 0){
                    if(contEven == 0){
                        topEven = num;
                        contEven++;
                    } 
                    else if(num > topEven)
                        topEven = num;
                }
                else if(num%2 != 0){
                    if(contOdd == 0){
                        leastOdd = num;
                        contOdd++;
                    }else if(num < leastOdd)
                        leastOdd = num;
                }
            }

            Console.WriteLine("Top even: " + topEven);
            Console.WriteLine("Least odd: " + leastOdd);
        }
    }
}
