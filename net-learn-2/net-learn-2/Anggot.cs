using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_learn_2
{
    internal class Anggot
    {
        public string Nama { get; set; }
        public double Umur { get; set; }
      //  public int Umur = 23;//untu properties public di tulis dengan huruf kapital di awalnya.
                             // private int saldo = 1000; //untuk properties private di tulis dengan huruf kecil(menggunakan cara 1)

        public int Saldo { get; set; }  //Cara 2

        /*Cara satu 
        public int Saldo
        {
            get { return saldo; }
            // set { saldo = value; }
          

            set
            { 
            if (value > 5000) {// set data by logic
                saldo=value;
                }
            }
        }*/



    }


}
