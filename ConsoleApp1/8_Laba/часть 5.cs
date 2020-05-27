using System.Collections.Generic;
using System;

namespace Test
{
    class Program
    {
        delegate void UseOperation(int a, int b);
        delegate void GetGreeting();

        static void Add(int x, int y)
        {
            Console.Write("  Результат суммы - " + (x + y));
        }
        static void Subtract(int x, int y)
        {
            Console.Write("  Результат вычитания - " + (x - y));
        }
        static void Multiply(int x, int y)
        {
            Console.Write("  Результат умножения - " + (x * y));
        }
        static void IntegerDevide(int x, int y)
        {
            Console.Write("  Результат деления - " + (x / y));
        }
        static void Main(string[] args)
        {
            GetGreeting del = GoodMorning;
            UseOperation delegat = Add;
            if (DateTime.Now.Hour < 12)
                del = GoodMorning;
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                del = GoodDay;
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 22)
                del = GoodEvening;
            else if (DateTime.Now.Hour >= 22 || DateTime.Now.Hour < 11)
                del = GoodEvening;
            del();
            Console.WriteLine("  Введите числа для проведения операций");
            Console.Write("  a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("  b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Выберете операцыю (+,-,*,/) - ");
            string operacia = Convert.ToString(Console.ReadLine());
            if (operacia == "+")
                delegat = Add;
            else if (operacia == "-")
                delegat = Subtract;
            else if (operacia == "*")
                delegat = Multiply;
            else if (operacia == "/")
                delegat = IntegerDevide;
            delegat(a, b);
        }

        static void GoodMorning()
        {
            Console.WriteLine("Good morning!!!!!!!!!!!!!!!!!");
        }
        static void GoodDay()
        {
            Console.WriteLine("Good afternoon!!!!!!!!!!!!!!!!!!");
        }
        static void GoodEvening()
        {
            Console.WriteLine("Good evening!!!!!!!!!!!!!!!");
        }
        static void GoodNight()
        {
            Console.WriteLine("Good night!!!!!!!!!!!!!!!");
        }

        
    }
}