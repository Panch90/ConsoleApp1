using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        struct People
        {
            public string name;
            public string surname;
            public string pobatkovi;
            public int vik;
            public double ves;

            public void PrintInf()
            {
                Console.WriteLine("  Имя - " + name);
                Console.WriteLine("  Фамилия - " + surname);
                Console.WriteLine("  Отчество - " + pobatkovi);
                Console.WriteLine("  Возраст - " + vik);
                Console.WriteLine("  Вес - " + ves);
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Queue<People> mas = new Queue<People>();
            People obj;
            StreamReader bufer = new StreamReader("C:\\Users\\USER ONE\\Desktop\\ConsoleApp1\\part2.txt");

            Console.WriteLine("  Сначала виведены до 40 лет потом после, смотрети файл, там очередь другая");
            while (!bufer.EndOfStream)
            {
                obj.name = Convert.ToString(bufer.ReadLine());
                obj.surname = Convert.ToString(bufer.ReadLine());
                obj.pobatkovi = Convert.ToString(bufer.ReadLine());
                obj.vik = Convert.ToInt32(bufer.ReadLine());
                obj.ves = Convert.ToDouble(bufer.ReadLine());
                mas.Enqueue(obj);
            }

            foreach (People w in mas)
            {
                if (w.vik < 40)
                    w.PrintInf();
            }
            foreach (People w in mas)
            {
                if (w.vik > 40)
                    w.PrintInf();
            }
        }
    }
}
