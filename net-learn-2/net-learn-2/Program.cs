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

            Console.Write("Inputkan umur anda :");
            string umur = Console.ReadLine();

            Console.Write("is Married ? :");
            string is_married = Console.ReadLine();
            
            Console.Write("Masukan Nilai Uang :");
            string uang = Console.ReadLine();

            /*
            //Operatore AND (&&)
            if (Convert.ToInt32(umur) > 25 && Convert.ToDouble(uang) > 1000 && Convert.ToBoolean(is_married))
            {
                Console.WriteLine("Success");
            }
            else
            {
               Console.WriteLine("Gagal");
            }
            */

            //Operator OR (||)+ Combination

            if( (Convert.ToInt32(umur) > 25 || Convert.ToInt32(uang) > 1000) && !Convert.ToBoolean(is_married))
            {
                Console.WriteLine("Benar");
            }
            else
            {
                Console.WriteLine("Salah"); 
            }

            Console.ReadLine();


        }

    }
}
