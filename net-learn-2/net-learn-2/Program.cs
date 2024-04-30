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
            int x = 1;
          
            /*while (x < 60)
            {
                if(x < 10) {
                    Console.WriteLine("Nilai x = 0" + x);
                }
                else
                {
                    Console.WriteLine("Nilai x = " + x);
                }
                x++;
            }*/

           /* while (x < 50) { 
            Console.WriteLine("Nilai x = " + x);
                x += 2; //x=x+2
            }*/

            while (++x < 6)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
