using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_learn_2
{
    internal class Anggota
    {
        public string nama= "andy";
        public int umur = 35;
        private int saldo = 5000;

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
