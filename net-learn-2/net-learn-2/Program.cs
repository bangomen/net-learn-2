using System;

namespace net_learn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Hari senin";
            char[] b = { 'h', 'e', 'l', 'l', 'o' };

            Console.WriteLine(a.Length);
            Console.WriteLine(a.IndexOf('i'));
            Console.WriteLine(a[3]);

            a = a.Insert(0, "ini adalah ");
            Console.WriteLine(a);

            a = a.Replace("senin","selasa");

            Console.WriteLine(a);

            if (a.Contains("rabu"))
            {
                Console.WriteLine("Ditemukan text=Hari ");
            }
            else
            {
                Console.WriteLine("Tidak Ditemukan text=Hari");

            }

            a=a.Remove(2);

            Console.WriteLine(a);
            

            Console.ReadLine();
        }


    }
}
