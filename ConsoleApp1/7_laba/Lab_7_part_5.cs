using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        const int N = 1840;
        static void Main()
        {
            int bufer;
            List<int> mas = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                mas.Add(rand.Next(400, 700));
            }

            mas.Sort();

            mas[8] = 8;

            Console.WriteLine("  Елементы масива:");
            foreach (int w in mas)
            {
                Console.Write(w + " ");
            }
            Console.WriteLine();


            bufer = rand.Next(0, 1011);
            for (int i = 0; i < N; i++)
            {
                if (mas[i] == bufer)
                    Console.WriteLine("  Найдено совпадение, индекс елемента - " + i);
            }

            Console.WriteLine("  Загаданый индекс - " + bufer);
            bufer = rand.Next(0, N);
            mas.Remove(bufer);

            mas.Clear();
            Console.Write("  Елементы масива:");
            foreach (int w in mas)
            {
                Console.Write(w + " ");
            }
            Console.WriteLine("  Нету искомого");
        }
    }
}




