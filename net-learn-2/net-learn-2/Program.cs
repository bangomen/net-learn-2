using System;

namespace net_learn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Anggot A1 = new Anggot();
            A1.Saldo = 30000;
            A1.Nama = "Omen";
            A1.Umur = 35;
            Console.WriteLine(A1.Saldo);
            Console.WriteLine(A1.Nama);
            Console.WriteLine(A1.Umur);
            Console.ReadLine();
           
        }


    }
}
