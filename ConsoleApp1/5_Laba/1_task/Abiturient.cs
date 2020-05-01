using System;
using System.Collections.Generic;
using System.Text;

namespace Shabolts
{
    class Abiturient : Persona
    {
        public Abiturient (string sur, int buf1, int buf2, int buf3, string fak) : base(sur, buf1, buf2, buf3, fak)  { }
        public override void ShowInformation()
        {
            Console.WriteLine("  Iнформацiя про абiтурiєнта ");
            Console.WriteLine("  Прiзвище - " + _sername);
            Console.WriteLine("  Дата народження - " + _date[0] + "." + _date[1] + "." + _date[2]);
            Console.WriteLine("  Факультет - " + _fakultet);
        }
        public override int GetAge()
        {
            int age = 0;

            age = 2020 - _date[2];
            if (_date[1] > 3)
                age -= 1;

            return age;
        }


    }
}
