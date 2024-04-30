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
            /*
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
            */

            /*
            Console.Write("Masukan Nilai :");
            string nilai = Console.ReadLine();

            if (Convert.ToInt32(nilai) >= 50)
            {
                Console.WriteLine("Anda Berhasil");
                if (Convert.ToInt32(nilai) >= 90)
                {
                    Console.WriteLine("Nilai Anda Perfect");
                }
                else
                {
                    Console.WriteLine("Nilai anda tidak Perfect, namun sudah sangat baik.");
                }
            }
            else
            {
                Console.WriteLine("Anda Gagal");
            }*/

            /*
            Console.WriteLine("Masukan Umur Anda :");
            string umur = Console.ReadLine();

            if (Convert.ToInt32(umur) > 14)
            {
                if(Convert.ToInt32(umur) >= 18)
                {
                    Console.WriteLine("Anda Sudah Dewasa");
                }
                else
                {
                    Console.WriteLine("Anda Masih Remaja");
                }
            }
            else
            {
                if(Convert.ToInt32(umur) > 5)
                {
                    Console.WriteLine("Kamu masih Anak anak");
                }
                else
                {
                    Console.WriteLine("Kamu Masih Balita");
                }

            }
            */

            Console.Write("Masukan Nilai kamu :");
            string nilai = Console.ReadLine();

            if (Convert.ToInt32(nilai) > 50)
            {
                Console.WriteLine("Kamu lulus dengan nilai C");
            }else if(Convert.ToInt32(nilai) > 70)
            {
                Console.WriteLine("Kamu lulus dengan Nilai B");
            }
            else if(Convert.ToInt32(nilai) > 80)
            {
                Console.WriteLine("Kamu lulus dengan nilai A");
            }
            else
            {
                Console.WriteLine("Kamu Gagal, gak apa ya... belajar lagi.");
            }



            Console.ReadLine();
        }
    }
}
