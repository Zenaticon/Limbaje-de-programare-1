using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = rand.Next(11), y, contor=3;
            do
            {
                contor--;
                Console.Write("Incearca: ");
                y = int.Parse(Console.ReadLine());
                if (x == y)
                {
                    Console.WriteLine("Ai castigat!");
                }
                else if (x > y)
                {
                    Console.WriteLine("Mai mare");
                }
                else
                {
                    Console.WriteLine("Mai mic");
                }
            } while (x != y && contor>0);

            if(x!=y){
                Console.WriteLine("Ai pierdut!");
            }
        }
    }
}