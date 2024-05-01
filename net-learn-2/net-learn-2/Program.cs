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
            /*
             int hitung = Pengurangan(y:5, x:10);
             Console.WriteLine(hitung);*/

            /*Passing by value : hitung(ref a); jika idak menggunakan ref maka nilai tidak dilakukan hitung, karena menggunakan void, jika ingin di 
            prosesuntuk perhitungan maka harus di tambahkan ref*/

            int a = 5;
            hitung(ref a);
            Console.WriteLine(a);

            int b = 7;
            getNilai(out a, out b);
            Console.WriteLine(a +" "+b);

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

        static void hitung(ref int x)
        {
            x = x * x;
            
        }

        static void getNilai(out int x,out int y)
        {
            x = 15;
            y = 12;
        }

    }
}
