using System;

namespace ConsoleApplication1{
    class Program{
        static void Main(string[] args){
            uint a, b, c;
            Console.WriteLine("Introduceti 3 numere:");
            if(uint.TryParse(Console.ReadLine(), out a)&&
            uint.TryParse(Console.ReadLine(), out b)&&
            uint.TryParse(Console.ReadLine(), out c)&&
            a!=0 && b!=0 && c!= 0
            )
            {
                // Console.WriteLine("Input valid");
                if(a+b>=c && b+c>=a && c+a>=b){
                    Console.WriteLine("Numerele formeaza un triunghi");
                    if(a==b && b==c){
                        Console.WriteLine("echilateral");
                    }else{
                        if(a==b || a==c || b==c){
                            Console.WriteLine("isoscel");
                        }else{
                            if(a*a+b*b==c*c || a*a+c*c==b*b || b*b+c*c==a*a){
                                Console.WriteLine("dreptunghic");
                            }else{
                                Console.WriteLine("oarecare3");
                            }
                        }
                    }
                    uint p = a + b + c;
                    Console.WriteLine($"P = {p}");
                    double sp = p / 2.0;
                    double arie = Math.Sqrt(sp * (sp -a) * (sp -b) * (sp - c));
                    Console.WriteLine($"A = {arie:N}");
                }else{
                    Console.WriteLine("Numerele nu formeaza un triunghi");
                }
            }else{
                    Console.WriteLine("Input invalid");
            }
        }
    }
}