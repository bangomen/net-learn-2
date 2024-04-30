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
            Console.Write("Masukan Angka 1:");
            string x = Console.ReadLine();

            Console.Write("Masukan Angka 2:");
            string y = Console.ReadLine();

            Console.Write("Hasil Penjumlahan adalah = {0}", x + y);
            Console.WriteLine("");

            Console.Write("Masukan Angka 1 lagi :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Angka 2 lagi :");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hasil Penjumlahan dengan Converter Int = {0}",a+b);
            Console.WriteLine("");
            Console.Write("Hasil Pengurangan dengan Converter Int = {0}", a - b);
            Console.WriteLine("");
            Console.Write("Hasil Perkalian dengan Converter Int = {0}",Convert.ToDouble(a) * Convert.ToDouble(b));
            Console.WriteLine("");
            Console.Write("Hasil Pembagian dengan Converter Int = {0}", Convert.ToDouble(a) / Convert.ToDouble(b));
            Console.WriteLine("");
            Console.Write("Hasil Modulus(Sisa Pembagian) dengan Converter Int = {0}", a % b);




            Console.ReadLine();
        }
    }
}
