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
           
            Console.WriteLine("Input data x :");
            string x = Console.ReadLine();
            Console.WriteLine("Input data y :");
            string y = Console.ReadLine();

            if (Convert.ToInt32(x) > Convert.ToInt32(y))
            {
                Console.WriteLine("x :{0} Lebih besar dari y : {1}", x,y);
            }
            else
            {
                Console.WriteLine("Y :{1} Lebih besar dari x :{0}",x,y);
            }

            Console.ReadLine();
        }
    }
}
