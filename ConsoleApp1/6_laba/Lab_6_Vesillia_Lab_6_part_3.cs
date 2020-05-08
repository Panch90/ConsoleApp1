using System;
using System.Collections.Generic;
using System.Text;

namespace Consolka 
{
    class Vesillia
    {
        private string _adres;
        private string _nameOfNarechena;
        private string _nameOfNarechenyy;
        private int _amountZaproshenyh;
        public Vesillia()
        {
            _adres = "  Kiev, Kotigoroshka 10";
            _nameOfNarechena = "Vika";
            _nameOfNarechenyy = "Slavko";
            _amountZaproshenyh = 1000;
        }

        public Vesillia(string adres, string narechena, string narechenyy, int gosti)
        {
            _adres = adres;
            _nameOfNarechena = narechena;
            _nameOfNarechenyy = narechenyy;
            _amountZaproshenyh = gosti;
        }

        public void GetInformation()
        {
            Console.Write("  Де буде дiйство - ");
            _adres = Convert.ToString(Console.ReadLine());
            Console.Write("  Кого беруть замiж (iм'я) - ");
            _nameOfNarechena = Convert.ToString(Console.ReadLine());
            Console.Write("  Хто бере замiж (iм'я) - ");
            _nameOfNarechenyy = Convert.ToString(Console.ReadLine());
            Console.Write("  Скiлькох позвали на гулянку - ");
            _amountZaproshenyh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        public override string ToString()
        {
            return string.Format(" Vesillia\n Adres = {0}\n Iм'я нареченой = {1}\n Iм'я нареченого = {2}\n Кількість запрошених = {3}\n", _adres, _nameOfNarechena, _nameOfNarechenyy, _amountZaproshenyh);
        }
    }
}
