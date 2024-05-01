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
            int[] a= {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[,] b = { 
                { 1,3,5,7,9,11},
                { 2,4,6,8,10,12} 
            };
            /*  for(int x = 0; x < a.Length; x++)//Show data with for loop in array one dimension
              {
                  Console.WriteLine(a[x]);    
              }*/

            /* for (int i =0; i<b.GetLength(0); i++)//Show data with For loop in Array two dimension
             {
                 for(int i_arr = 0; i_arr < b.GetLength(1); i_arr++)
                 {
                     Console.Write(b[i,i_arr]);
                 }
                 Console.WriteLine();
             }*/

            int[,,] c = { { { 1, 3 }, { 5, 7 } },{{ 2,4},{ 6,8} } };
            // Console.WriteLine(c[1,0,1]);
            Console.WriteLine("=Rank=");
            Console.WriteLine(a.Rank);
            Console.WriteLine(b.Rank);
            Console.WriteLine(c.Rank);
            Console.WriteLine("=Lenght=");
            Console.WriteLine(a.Length);
            Console.WriteLine(b.Length);
            Console.WriteLine(b.GetLength(0));
            Console.WriteLine(c.Length);
            Console.WriteLine("=array a: Max/min/sum Value=");
            Console.WriteLine(a.Max());
            Console.WriteLine(a.Min());
            Console.WriteLine(a.Sum());









            //  Console.WriteLine(a[1]);//call value from array one dimension
            //  Console.WriteLine(b[1,5]);//call value from array two dimension
            Console.ReadLine();

        }


    }
}
