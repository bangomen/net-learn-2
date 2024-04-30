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
            // int persegipanjang = luas(10, 5); //dengan kondisi ada value;
            // int persegipanjang = luas(); //dengan kondisi tidak ada value maka akan menggunakan value default;
            // int persegipanjang = luas(l:16,p:29);// dengan mengisi nilai pada parameter, maka inputan datanya tidak perlu di urutkan.
           /* Console.Write("Masukan Nilai Panjang(p) :");
            string p=Console.ReadLine();

            Console.Write("Masukan Nilai Lebar(l) :");
            string l=Console.ReadLine();
            int persegipanjang = luas(Convert.ToInt32(p), Convert.ToInt32(l));

            Console.WriteLine("Luas Persegi Panjang adalah :"+ persegipanjang);
           */

            int hitung = Pengurangan(y:5, x:10);
            Console.WriteLine(hitung);


            Console.ReadLine(); 
        }

        static int luas(int p=0, int l = 0)
        {
            return p * l;
        }

        static int Pengurangan(int x, int y)
        {
            return x - y;
        }

    }
}
