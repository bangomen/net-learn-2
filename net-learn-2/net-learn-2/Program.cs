using System;

namespace net_learn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Anggota club1 = new Anggota();
            club1.nama = "Omen";
            club1.umur = 25;
            club1.setSaldo(1000);


            string nama = club1.nama;
            int umur=club1.umur;
            int saldo=club1.getSaldo();


            Console.WriteLine("nama : {0}, Umur : {1}, Saldo : {2}",nama, umur, saldo);
            Console.WriteLine("Atau bisa juga di tambilkan seperti dibawah ini");
            Console.WriteLine("nama :" + nama);
            Console.WriteLine("Umur :" + umur);
            Console.WriteLine("Saldo :" + saldo);



            Console.ReadLine();
        }


    }
}
