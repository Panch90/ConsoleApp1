using System;
using System.IO;

namespace Shabolts
{
    class Program
    {
        const int N = 3;
        static void Main(string[] args)
        {
            string[] bufer = new string[5];
            int[] date = new int[9];
            int[] justNeed = new int[2];
            using (StreamReader MyFile = new StreamReader("C:\\Users\\USER ONE\\Desktop\\Корзина\\Programming\\Shabolts\\Shabolts\\test.txt"))
            {
                for(int i =0; i<5; i++)
                {
                    bufer[i] = Convert.ToString(MyFile.ReadLine());
                  //  Console.WriteLine(bufer[i]);
                }

                for(int i =0; i<9; i++)
                {
                    date[i] = Convert.ToInt32(MyFile.ReadLine());
                  //  Console.WriteLine(date[i]);

                }

                for (int i =0; i<2; i++)
                {
                    justNeed[i] = Convert.ToInt32(MyFile.ReadLine());
                  //  Console.WriteLine(justNeed[i]);

                }


            }

            Persona[] mas = new Persona[N];

            mas[0] = new Abiturient(bufer[0], date[0], date[1], date[2], bufer[3]);
            mas[1] = new Student(bufer[1], date[3], date[4], date[5], bufer[3], justNeed[0]);
            mas[2] = new Prepod(bufer[2], date[6], date[7], date[8], bufer[3], bufer[4], justNeed[1]);

            mas[0].ShowInformation();
            Console.WriteLine("  Years - " + mas[0].GetAge());
            Console.WriteLine();

            mas[1].ShowInformation();
            Console.WriteLine("  Years - " + mas[1].GetAge());
            Console.WriteLine();

            mas[2].ShowInformation();
            Console.WriteLine("  Years - " + mas[2].GetAge());
            Console.WriteLine();

        }
    }
}