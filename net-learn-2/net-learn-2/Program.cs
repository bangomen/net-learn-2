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
            int x = 30;
            // x += 2;// x = x + 2 
            // x -= 2;// x = x - 2
            // x *= 2;// x = x * 2 
            // x /= 2;// x = x / 2 
            //  x %= 2;// x = x % 2 
            // x++; //X+1
            // x++;
            //x--;
           // int y = x++; // is false
            int y = ++x; // is true


            Console.WriteLine("Nilai x :{0} ", y);
        }
    }
}
