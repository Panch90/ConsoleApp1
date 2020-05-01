using System;
using System.Collections.Generic;
using System.Text;

namespace Shabolts
{
    class Student : Persona
    {
        public Student(string sur, int buf1, int buf2, int buf3, string fak, int kurs) : base(sur, buf1, buf2, buf3, fak) 
        { this._kurs = kurs; }
        public override void ShowInformation()
        {
            Console.WriteLine("  Iнформацiя про студента ");
            Console.WriteLine("  Прiзвище - " + _sername);
            Console.WriteLine("  Дата народження - " + _date[0] + "." + _date[1] + "." + _date[2]);
            Console.WriteLine("  Факультет - " + _fakultet);
            Console.WriteLine("  Курс - " + _kurs);
        }
        public override int GetAge()
        {
            int age = 0;

            age = 2020 - _date[2];
            if (_date[1] > 3)
                age -= 1;

            return age;
        }

        private int _kurs;

        public int Kurs
        {
            get { return _kurs; }
            set { _kurs = value; }
        }
    }
}
