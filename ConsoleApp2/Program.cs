using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    class Program
    {
        class BagunDatar
        {
            
            static void Main(string[] args)
            {
                Console.WriteLine("1. Persegi Panjang");
                Console.Write("Number : ");
                int input = Convert.ToInt16(Console.ReadLine());
                if (input == 1)
                {
                   
                }
                else if (input == 2)
                {
                    Lingkaran l = new Lingkaran();
                    Console.Write("Masukan Ruji - Ruji Linkaran : ");
                    l.ruji = Convert.ToDouble(Console.ReadLine());
                    l.Display();
                    Console.ReadLine();
                }
                else if (input == 3)
                {
                    Console.Write("Masukan Tinggi Segitiga : ");
                    double tinggi = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukan Alas Segitiga : ");
                    double alas = Convert.ToDouble(Console.ReadLine());
                    Triangle t = new Triangle(alas, tinggi);
                    double a = t.area();
                    Console.WriteLine("Area: {0}", a);
                    Console.ReadKey();
                }
                else if (input == 4)
                {

                }
            }
        }
    }
}
