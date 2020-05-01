using System;
using System.Collections.Generic;
using System.Text;

namespace Shabolts
{
    abstract class Persona
    {
        public Persona(string sur, int buf1, int buf2, int buf3, string fak)
        {
            this._sername = sur;
            this._date[0] = buf1;
            this._date[1] = buf2;
            this._date[2] = buf3;
            this._fakultet = fak;
        }
        abstract public void ShowInformation();
        abstract public int GetAge();

        protected string _sername;
        protected int[] _date = new int[3];
        protected string _fakultet;
    }
}
