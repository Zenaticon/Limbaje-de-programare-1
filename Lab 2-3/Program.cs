using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char op;
            Console.WriteLine("Introduceti comanda: ");
            a = int.Parse(Console.ReadLine());
            op = char.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case '-':
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case '/':
                    if (b != 0)
                        Console.WriteLine($"{a} / {b} = {a / b}");
                    else
                        Console.WriteLine("Impartire la 0!");
                    break;
                case '\\':
                    if (b != 0)
                        Console.WriteLine($"{a} + {b} = {(double)a / b}");
                    else
                        Console.WriteLine("Impartire la 0!");
                    break;
                case '%':
                    Console.WriteLine($"{a} % {b} = {a % b}");
                    break;
                default:
                    Console.WriteLine("Operator invalid");
                    break;
            }
        }
    }
}