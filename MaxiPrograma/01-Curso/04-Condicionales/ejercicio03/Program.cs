using System;

namespace ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int processor, ram, hdd;
            float total=0;

            Console.WriteLine("1) i5");
            Console.WriteLine("2) i7");
            Console.WriteLine("3) i9");
            processor = int.Parse(Console.ReadLine());

            switch(processor)
            {
                case 1:
                    Console.WriteLine("1) 8GB");
                    Console.WriteLine("2) 16GB");
                    Console.WriteLine("3) 32GB");
                    ram = int.Parse(Console.ReadLine());
                    switch (ram)
                    {
                        case 1:
                            total = 800F;
                            break;
                        case 2:
                            total = 900F;
                            break;
                        case 3:
                            total = 1000F;
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1) 8GB");
                    Console.WriteLine("2) 16GB");
                    Console.WriteLine("3) 32GB");
                    ram = int.Parse(Console.ReadLine());
                    switch (ram)
                    {
                        case 1:
                            total = 900F;
                            break;
                        case 2:
                            total = 1000F;
                            break;
                        case 3:
                            total = 1400F;
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("1) 8GB");
                    Console.WriteLine("2) 16GB");
                    Console.WriteLine("3) 32GB");
                    ram = int.Parse(Console.ReadLine());
                    switch (ram)
                    {
                        case 1:
                            total = 1200F;
                            break;
                        case 2:
                            total = 1400F;
                            break;
                        case 3:
                            total = 2000F;
                            break;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Do you want to extend the disk to 1TB? ");
            Console.WriteLine("1 -> Yes");
            Console.WriteLine("0 -> No");
            hdd = int.Parse(Console.ReadLine());

            if (hdd == 1)
                total += 300F;

            Console.WriteLine("Total: " + total);
        }
    }
}
