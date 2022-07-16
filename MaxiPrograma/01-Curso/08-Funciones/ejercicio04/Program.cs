/* 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con: */

/* a. 1 si el número es positivo. */
/* b. -1 si el número es negativo. */
/* c. 0 si el número es cero. */
using System;

namespace ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numValue, numReference;

            Console.WriteLine("Enter number: ");
            numValue = int.Parse(Console.ReadLine());
            numReference = 0;

            positivoNegativoCero(numValue, ref numReference);

            Console.WriteLine(numReference);
        }

        static void positivoNegativoCero(int numValue, ref int numReference)
        {
            if(numValue > 0)
                numReference = 1;
            if(numValue < 0)
                numReference = -1;
            if(numValue == 0)
                numReference = 0;
        }
    }
}
