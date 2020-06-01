using System;
using System.IO;

namespace Shabolts
{


    class Program
    {
        
        static void Main(string[] args)     // это вход в програму, (функция Main)
        {
            int namberOfStud;
            string nameOfGroup;
            Console.Write("  Введите количество студентов (не менее 3) - ");
            namberOfStud = Convert.ToInt32(Console.ReadLine());
            if (namberOfStud < 3)
            {
                while (namberOfStud < 3)
                {
                    Console.WriteLine("  Введите количество не меньше 3");
                    Console.Write("  -> ");
                    namberOfStud = Convert.ToInt32(Console.ReadLine());
                }
            }
            Student[] masiv = new Student[namberOfStud];    // создаем масив студентов

            for (int i = 0; i < namberOfStud; i++)
            {
                if (i % 2 == 0)
                    masiv[i] = new Student(true);
                else
                    masiv[i] = new Student(false);

                masiv[i].GetInformation();
            }

            
            Console.WriteLine("  Введiть назву групи, студентiв якої хотiли б знайти: ");       // поиск людей по группе
            nameOfGroup = Convert.ToString(Console.ReadLine());
            bool buf = false;
            for (int i = 0; i < namberOfStud; i++)
            {
                if (masiv[i].Group == nameOfGroup)
                    buf = true;
                else
                    buf = false;

                if ((buf == true) && (i == namberOfStud))
                {
                    Find_Student(nameOfGroup, masiv, namberOfStud);
                }
                else
                {
                    Console.Write("  Введите  существующую  группу - ");
                    nameOfGroup = Convert.ToString(Console.ReadLine());
                }
            }

            Console.WriteLine("  Отсортированые студенты: ");   // вывод отсортированых стедентов согласно заданию
            Sort(masiv, namberOfStud);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("  Выыод инфы про студентов");    // показываю что метод вывода работает
            for (int i = 0; i < namberOfStud; i++)
            {
                masiv[i].ShowInformation();
            }



        }

        public static void Find_Student(string bufer, Student[] obj, int amount)    // метод для поиска студентов по группе
        {
            for (int i = 0; i < amount; i++)
            {
                if (obj[i].Group == bufer)
                    obj[i].ShowInformation();
            }
        }

        public static void Sort(Student[] obj, int amount)// неожиданно, но это сортировка 
        {
            double[] mas = new double[amount];
            for (int i = 0; i < amount; i++)
            {
                mas[i] = obj[i].SeredniyBal;
            }

            Array.Sort(mas);
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    if (obj[j].SeredniyBal == mas[i])
                        obj[j].ShowInformation();
                }
            }
        }

    }
}