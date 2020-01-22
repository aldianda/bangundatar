using System;

public class Class1
{
    public double panjang;
    public double lebar;

    public double GetArea()
    {
        return panjang * lebar;
    }
    public void Display()
    {
        Console.WriteLine("Panjang: {0}", panjang);
        Console.WriteLine("Lebar: {0}", lebar);
        Console.WriteLine("Area {0}", GetArea());
    }
}
