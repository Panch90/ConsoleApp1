using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        class People 
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
        class PeopleComparer : IComparer<People>
        {
            public int Compare(People p1, People p2)
            {
                if (p1.vik > p2.vik)
                    return 1;
                else if (p1.vik < p2.vik)           
                    return -1;
                else
                    return 0;
            }
        }

        static void Main()
        {
            List<People> mas = new List<People>();
            People obj = new People();

            StreamReader bufer = new StreamReader("C:\\Users\\USER ONE\\Desktop\\ConsoleApp1\\part2.txt");
            while (!bufer.EndOfStream)
            {
                obj.name = Convert.ToString(bufer.ReadLine());
                obj.surname = Convert.ToString(bufer.ReadLine());
                obj.pobatkovi = Convert.ToString(bufer.ReadLine());
                obj.vik = Convert.ToInt32(bufer.ReadLine());
                obj.ves = Convert.ToDouble(bufer.ReadLine());
                mas.Add(obj);
            }
            bufer.Close();

            mas.Sort(new PeopleComparer());

            Console.WriteLine(mas[0].ToString());
            Console.WriteLine(mas[1].ToString());
            Console.WriteLine(mas[2].ToString());
           
            foreach (People w in mas)
            {
                w.PrintInf();
            }

        }
    }
}




