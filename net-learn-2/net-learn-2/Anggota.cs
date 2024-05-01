using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_learn_2
{
    internal class Anggota
    {
       
       // private string nama= "andy";
        public string nama= "andy";
        public int umur = 35;
        private int saldo = 5000;

        //Custructor : sebuah method namanya sama dengan class nya, constructor akan dijalankan pada saat class pertami kali di panggil.
       /* public Anggota(string kelamin) {
            //nama = nama;
            Console.WriteLine("Hallo Nama saya "+ kelamin);
        }*/

        public Anggota()
        {
            nama = nama;
            Console.WriteLine("Hallo Nama saya " + nama);
        }


        public int getSaldo()
        {
            return saldo;
        }

        public void setSaldo(int n)
        {
            saldo += n;
        }

    }
}
