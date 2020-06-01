using System;
using System.IO;

namespace Ylia
{
    class Rectangle : IFigure
    {
        double _Dlina 
        { 
            set
            {
                if(value <= 0)
                {
                    value = 0;
                }
                else
                {
                    _dlina=value;
                }
            } 
            get
            {
                return _dlina;
            } 
        } 
        double _Shirina 
        {
            set
            {
                if(value <= 0)
                {
                    value = 0;
                }
                else
                {
                    _shirina=value;
                }
            } 
            get
            {
                return _shirina;
            } 
        } 
        string _Name
        {
            get
            {
                return _name;
            }
        }
        
        double _dlina;
        double _shirina;
        string _name;
        public Rectangle()
        {
            _Dlina = 4;
            _Shirina = 2;
            _name = "Первый";
        }
        public Rectangle(double dlina, double shirina)
        {
            _Dlina = dlina;
            _Shirina = shirina;
            _name="Второй";
        }
        public Rectangle(string name)
        {
            _name = name;
            _Dlina = 6;
            _Shirina = 3;
        }
        public double Perimeter()
        {
            double perimeter = 2*(_Dlina+_Shirina);
            return perimeter;
        }
        public double Ploshad()
        {
            double ploshad = _Dlina*_Shirina;
            return ploshad;
        } 
        public void PrintEcran()
        {
            Console.WriteLine("Прямоугольник "+_Name+" имеет такие значения:");
            Console.WriteLine("Длина = "+_Dlina+"\nШирина - "+_Shirina);
            Console.WriteLine("Периметр = "+Perimeter());
            Console.WriteLine("Площадь = "+Ploshad()+"\n");
        }
        public void PrintFile()
        {
            string file = "F:\\2 семестр 2 курс\\BP\\inText.txt";
            using (StreamWriter write = new StreamWriter(file, true, System.Text.Encoding.Default))
            {
                write.WriteLine("Прямоугольник "+_Name+" имеет такие значения:");
                write.WriteLine("Длина = "+_Dlina+"\nШирина - "+_Shirina);
                write.WriteLine("Периметр = "+Perimeter());
                write.WriteLine("Площадь = "+Ploshad()+"\n");
            }
        }
    }
}