using ConsoleApp1;
using System;
using System.IO;

class Program
{
    delegate double Delegate(double w);
    static void Main(string[] args)
    {
        Kulia buf = new Kulia();

        Delegate del = buf.Dlinna;
        Console.Write("  Длинна = " + del(17));

        del = buf.Plosha;
        Console.Write("  Площадь круга = " + del(18));

        del = buf.Amount;
        Console.Write("  Объем =  " + del(2));
    }
}
