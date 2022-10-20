using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            char optiune;
            do
            {
                Console.Write("n=");
                n = uint.Parse(Console.ReadLine());
                bool prim = true;
                for (int d = 2; d * d <= n; d++)
                { //d<=sqrt(n)
                    if (n % d == 0)
                    {
                        prim = false;
                        break; //pentru eficienta
                    }
                }
                if (prim && n >= 2)
                {
                    Console.WriteLine($"{n} este numar prim");
                }
                else
                {
                    Console.WriteLine($"{n} nu este numar prim");
                }

                Console.Write("Vrei sa mai testezi un numar? (d/n):");
                optiune = char.Parse(Console.ReadLine());
            } while (optiune != 'n');
        }
    }
}