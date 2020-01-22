using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Shape
    {
        protected double panjang, lebar;
        public Shape(double a = 0, double b = 0)
        {
            panjang = a;
            lebar = b;
        }
        public virtual double area()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }
    }
    class Persegi : Shape
    {
        public Persegi(double a = 0, double b = 0) : base(a, b)
        {

        }
        public override double area()
        {
            Console.WriteLine("Rectangle class area :");
            return (panjang * lebar);
        }
    }
    class Triangle : Shape
    {
        private double alas;
        private double tinggi;

        public Triangle(double a = 0, double b = 0): base(a, b)
        {
        }
        public override double area()
        {
            Console.WriteLine("TriaAngle class area : ");
            return (alas * tinggi / 2);
        }
    }
    class Caller
    {
        public void CallArea(Shape sh)
        {
            double a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Persegi r = new Persegi(10, 7);
            Triangle t = new Triangle(10, 5);

            c.CallArea(r);
            c.CallArea(t);
            Console.ReadKey();
        }

    }
}
