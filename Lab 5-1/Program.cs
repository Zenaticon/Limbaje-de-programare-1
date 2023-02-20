using System;

namespace ConsoleApplication1
{
    class Program
    {
        static int[]CitireConsola(){
            uint n;
            Console.Write("n="); n = uint.Parse(Console.ReadLine());
            int[] V = new int[n];
            Console.WriteLine("Introduceti elementul vectorului:");
            for(int i=0;i<n;i++){
                Console.Write($"V[{i}]= ");
                V[i] = int.Parse(Console.ReadLine());
            }
            return V;
        }

        static void Afisare(int[]V){
            Console.Write("Vectorul este: ");
            foreach(int el in V){
                Console.Write(el+" ");
            }
        }

        static int Suma(int[]V){
            int sum = 0;
            foreach(int el in V){
                sum += el;
            }
            return sum;
        }

        static int MaiMareDecatPrag(int[]V, int prag){
            int count = 0;
            foreach(int el in V){
                if(el > prag){
                    count++;
                }
            }
            return count;
        }

        static int CateNegative(int[]V){
            int count = 0;
            foreach(int el in V){
                if(el < 0){
                    count++;
                }
            }
            return count;
        }

        static void TransformaNegative(int[]V){
            int i=0;
            foreach(int el in V){
                if(el < 0){
                    V[i] = -V[i];
                }
                i++;
            }

            // SAU

            // for(int i=0;i<V.Length;i++){
            //     if(V[i] < 0)
            //         V[i] = -V[i];
            // }
        }

        static int ProdusScalar(int[] V1, int[] V2){
            int produs = 0;
            if(V1.Length!=V2.Length){
                Console.WriteLine("Eroare");
                return -1;
            }
            for(int i=0;i<V1.Length;i++){
                produs += (V1[i]*V2[i]);
            }
            return produs;
        }

        static void Main(string[] args){
            int[] V = CitireConsola();
            Afisare(V);
            Console.WriteLine($"\nSuma elementelor este: {Suma(V)}");
            Console.WriteLine($"Sunt {MaiMareDecatPrag(V, 5)} elemente mai mari decat 5");
            Console.WriteLine($"Sunt {CateNegative(V)} elemente negative");
            TransformaNegative(V);
            Afisare(V);
            Console.WriteLine("\n");
            int[] V2 = CitireConsola();
            Afisare(V2);
            Console.WriteLine("\n");
            Console.WriteLine($"V1*V2={ProdusScalar(V,V2)}");
        }
    }
}