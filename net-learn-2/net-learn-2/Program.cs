using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace net_learn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Print("omen juara");
             Console.ReadLine();*/

            /*Call Function untuk perhitungan factorial
            int n = 15;
             Console.WriteLine("Nilai Factorial dari {0}! adalah {1}", n, Factorial(n));
            */
            int n = 50;
            Piramida(5);
            Piramida(30);
            Piramida(50);

            Console.ReadLine();
        }

        static void Print(int a) {//method yang digunakan untuk menghitung bilangan bulat
            Console.WriteLine("biliangan bulat : {0}", a);
        }

        static void Print(double a)//method yang digunakan untuk menghitung bilangan pecahan
        {
            Console.WriteLine("Bilangan Pecahan : {0}", a);

        }

        static void Print(string a)//method yang digunakan untuk mengelola data string
        {
            Console.WriteLine("Nilai adalah string :{0}",a);
        }

        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static void Piramida(int n)
        {
            for(int i=1; i <= n; i++)
            {
                for(int j=i; j<n; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <=2*i-1 ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }
}
