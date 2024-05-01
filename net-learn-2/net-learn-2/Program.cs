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
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] b = { 1.5, 2.4, 3.2, };
            string[] c = {"dono","Kasino","Indro" };

            // c[1] = "Daniel";//Mengganti nilai pada array string

            //a[1] = a[1] + 1;//melakukan kalkulasi pada nilai int

            /* for (int i = 0; i < 7; i++) //menampilkan data array menggunakan FOR
             {
                 Console.WriteLine(a[i]);
             }*/


            /* for (int i = 0; i <= a.Length; i++) //menampilkan data array menggunakan FOR + Lenght Array sebagai loop
             {
                 Console.WriteLine("Nilai Dari array a adalah :" + a[i]);
             }*/
            int total_a = 0;
            foreach (int item in a)
            {
                Console.WriteLine(item);
                total_a += item;
            }
            Console.WriteLine("==");
            Console.WriteLine(total_a);
            Console.WriteLine();



            double total_b = 0;
            foreach (double item in b)
            {
                Console.WriteLine(item);
                total_b += item;    
            }
            Console.WriteLine("==");
            Console.WriteLine(total_b);
     

            Console.WriteLine();

            foreach (string item in c)
            {
                Console.WriteLine(item);
            }





            // Console.WriteLine(a[1]);
            Console.ReadLine(); ;

        }


    }
}
