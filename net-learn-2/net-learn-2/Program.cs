using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_learn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan angka x :");
            string x = Console.ReadLine();
            //int x = 18;
            switch(Convert.ToInt32(x))
            {
                case 8:
                    Console.WriteLine("nilai x adalah 8");
                    break;
                case 18:
                    Console.WriteLine("Nilai x adalah 18");
                    break;
                case 28:
                    Console.WriteLine("Nilai x adalah 28");
                    break;
                default:
                    Console.WriteLine("Nilai x tidak dikenali");
                    break;

            }

            Console.ReadLine();

        }
    }
}
