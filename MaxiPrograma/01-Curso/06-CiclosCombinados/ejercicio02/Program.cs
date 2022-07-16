/* 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar: */

/*         El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo. */
/*         Informar cuántos grupos están formados por todos números ordenados de mayor a menor. */
using System;

namespace ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, gruopNumber=0, orderGroup = 0;
            float numberCounter=0, numberCounterOdd = 0;
            float maxOdd = 0;

            for(int i=0; i < 5; i++){
                numberCounter=0; 
                numberCounterOdd = 0;
                float percentegeOdd;
                bool aux=true;
                int numOld;

                Console.WriteLine("Enter number (0: exit): ");
                num = int.Parse(Console.ReadLine());
                numOld = num;
                while(num != 0){
                    if (num%2!=0)
                        numberCounterOdd ++;
                    numberCounter++;
                    Console.WriteLine("Enter number (0: exit): ");
                    num = int.Parse(Console.ReadLine());

                    if (num <= numOld)
                        numOld = num;
                    else
                        aux=false;

                }
                percentegeOdd = (numberCounterOdd * 100) / numberCounter;
                if (percentegeOdd > maxOdd){
                    maxOdd = percentegeOdd;
                    gruopNumber = i + 1;
                }
                
                if(aux)
                    orderGroup++;
            }
            Console.WriteLine("Group: " + gruopNumber);
            Console.WriteLine("Percentage: " + maxOdd);
            Console.WriteLine("Number of order groups: " + orderGroup);
        }
    }
}
