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
            int x = 10;
            do
            {
                Console.WriteLine(x);
                x++;
            }while (x < 0);
            //perbedaan dengan while loop adalah, do while akan tetap menampilkan result walaupun cuma 1 kali lopp walupun ketentuannya salah.

            Console.ReadLine();
        }
        
    }
}
