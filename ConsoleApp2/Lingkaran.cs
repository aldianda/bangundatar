using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Lingkaran
    {
        public double ruji;
        public const double phi = 22 / 7;

        public double GetLuas()
        {
            return phi * ruji * ruji;
        }
        public double GetKeliling()
        {
            return phi* ruji * 2;
        }
        public void Display()
        {
            Console.WriteLine("Panjang: {0}", ruji);
            Console.WriteLine("Luas {0}", GetLuas());
            Console.WriteLine("Keliling {0}", GetKeliling());
        }
    }
}
