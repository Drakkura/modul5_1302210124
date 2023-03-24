using modul5_1302210124;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210124
{
    internal class Penjumlahan_1302210124<T>
    {
        private T sum;
        public void JumlahTigaAngka_1302210124(T a1, T a2, T a3)
        {
            this.sum = sum;
            sum = (dynamic)a1 + (dynamic)a2 + (dynamic)a3;
            Console.WriteLine("Jumlah dari tiga angka " + sum);

        }
    }

    class program
    {
        static void Main(string[] args)
        {
            double a1 = 13;
            double a2 = 02;
            double a3 = 21;
            Penjumlahan_1302210124<double> summ = new Penjumlahan_1302210124<double>();
            summ.JumlahTigaAngka_1302210124(a1, a2, a3);

        }
    }
}
