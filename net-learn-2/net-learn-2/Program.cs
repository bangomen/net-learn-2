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

            /*rumus for loop
              for (inisiasi,kondisi,Increment) {
              statement
              }
            */

            Console.Write("Masukan Nilai Total : ");
            string total = Console.ReadLine();

            if (Convert.ToInt32(total) > 1000)
            {
                Console.WriteLine("Tidak dapat melakukan loop dengan angka : {0}", total);
            }
            else
            {
                int jumlah = 1;
                for (int x = 1; x < Convert.ToInt32(total); x++)
                {
                    Console.WriteLine("Nilai x = " + x);
                    jumlah *= x;
                }
                Console.WriteLine("Total Penjumlahan angka x = ", + jumlah);
            }

            Console.ReadLine();






        }

    }
}
