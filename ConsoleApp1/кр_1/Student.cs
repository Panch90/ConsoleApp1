using System;
using System.Collections.Generic;
using System.Text;

namespace Shabolts
{
    class Student
    {
        private double seredniyBal;     // поля класа
        private string surname;
        private string group;
        private bool budjet;

        public Student(bool budjet)     // конструктор
        {
            this.budjet = budjet;
        }

        public void GetInformation()        // метод получения информации из консоли
        {
            Console.WriteLine("  Введите данные про студента: ");
            Console.Write("  Фамилия - ");
            surname = Convert.ToString(Console.ReadLine());
            Console.Write("  Группа - ");
            group = Convert.ToString(Console.ReadLine());
            Console.Write("  Средний бал - ");
            seredniyBal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }
        public void ShowInformation()   // метод вывода на консоли
        {
            Console.WriteLine("  Информацыя про студента ");
            Console.WriteLine("  Фамилия - " + surname);
            Console.WriteLine("  Группа - " + group);
            Console.WriteLine("  Средний бал - " + seredniyBal);
            if (budjet)
                Console.WriteLine("  Студент на бюджете");
            else
                Console.WriteLine("  Студент не на бюджете");
            Console.WriteLine();
        }


        public string Surname       // властивости полей
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public double SeredniyBal
        {
            get { return seredniyBal; }
            set { seredniyBal = value; }
        }

        public bool Budjet
        {
            get { return budjet; }
            set { budjet = value; }
        }
    }
}
