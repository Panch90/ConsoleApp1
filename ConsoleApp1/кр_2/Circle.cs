using System;
using System.IO;

namespace Ylia
{
    class Circle : IFigure
    {
        double _Radius 
        { 
            set
            {
                if(value <= 0)
                {
                    value = 0;
                }
                else
                {
                    _radius = value;
                }
            }
            get
            {
                return _radius;
            }
        }  
        string _Name
        {
            get
            {
                return _name;
            }
        }
        double _radius;
        string _name;
        public Circle()
        {
            _radius = 1;
            _name = "Первый";
        }
        public Circle(double R)
        {
            _Radius = R;
            _name = "Второй";
        }
        public Circle(string name)
        {
            _name = name;
            _Radius = 2;
        }
        public double Perimeter()
        {
            double perimetr =2*Math.PI*_Radius; 
            return perimetr;
        }
        public double Ploshad()
        {
            double ploshad = Math.PI*Math.Pow(_Radius,2);
            return ploshad;
        } 
        public void PrintEcran()
        {
            Console.WriteLine("Круг "+_Name+" имеет такие значения:");
            Console.WriteLine("Радиус = "+_Radius);
            Console.WriteLine("Длина окружности = "+Perimeter());
            Console.WriteLine("Площадь = "+Ploshad()+"\n");
        }
        public void PrintFile()
        {
            string file = "F:\\2 семестр 2 курс\\BP\\inText.txt";
            using (StreamWriter write = new StreamWriter(file, true, System.Text.Encoding.Default))
            {
                write.WriteLine("Круг "+_Name+" имеет такие значения:");
                write.WriteLine("Радиус = "+_Radius);
                write.WriteLine("Периметр = "+Perimeter());
                write.WriteLine("Площадь = "+Ploshad()+"\n");
            }
        }
    }
}
