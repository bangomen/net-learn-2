using System;

namespace net_learn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil toyota= new Mobil();
            Mobil Dayhatsu = new Mobil();

            toyota.Klakson();
            toyota.warna = "Hijau";
            toyota.kecepatan = 200;

            Dayhatsu.warna = "Putih";
            Dayhatsu.kecepatan = 180;

            //Dayhatsu.Klakson();

            Console.WriteLine("Warna Mobil Toyota adalah: "+ toyota.warna);
            Console.WriteLine("Warna Mobil Dayhatsu adalah: "+ Dayhatsu.warna);
            Console.WriteLine("Kecepatan Toyota adalah: " + toyota.kecepatan);
            Console.WriteLine("Kecepatan Dayhatsu adalah: " + Dayhatsu.kecepatan);


            Console.ReadLine();
        }


    }
}
