using System;
using System.Collections.Generic;
using System.Text;

namespace Shabolts
{
    class Prepod : Persona
    {
        public Prepod(string sur, int buf1, int buf2, int buf3, string fak, string posada, int stajg) : base(sur, buf1, buf2, buf3, fak)
        {
            this._posada = posada;
            this._exp = stajg;
        }
        public override void ShowInformation()
        {
            Console.WriteLine("  Iнформацiя про викладача ");
            Console.WriteLine("  Прiзвище - " + _sername);
            Console.WriteLine("  Дата народження - " + _date[0] + "." + _date[1] + "." + _date[2]);
            Console.WriteLine("  Факультет - " + _fakultet);
            Console.WriteLine("  Посада - " + _posada);
            Console.WriteLine("  Стаж - " + _exp + " рочкiв");
        }
        public override int GetAge()
        {
            int age = 0;

            age = 2020 - _date[2];
            if (_date[1] > 3)
                age -= 1;

            return age;
        }

        private string _posada;
        private int _exp;

        public string Posada
        {
            get { return _posada; }

            set { _posada = value; }
        }

        public int Exp
        {
            get { return _exp; }
            set { _exp = value; }
        }

    }
}
