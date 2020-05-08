using System;

namespace ConsoleApp6
{
    // визначення iнтерфейсу
    interface IDemo
    {
        void Show(); //оголошення методу
        double Dlina(); //оголошення методу
        int X { get; } //оголошення властивостi, доступного тiльки для читання
        int Y { get; } //оголошення властивостi, доступного тiльки для читання
        int this[int i] { get; set; } //оголошення iндексатора, доступного для читання-запису
    }
    // клас DemoPoint успад ковує iнтерфейс IDemo

    public interface IMeasurable
    {
        double Perimeter();
        double Area();
        void Show();
    }

    class Square : IMeasurable
    {
        private double _storona;
        public Square( double a)
        {
            _storona = a;
        }

        public double Area()
        {
            return Math.Pow(_storona, 2);
        }

        public double Perimeter()
        {
            return 4 * _storona;
        }

        public void Show()
        {
            Console.WriteLine("  Периметр - " + Perimeter());
            Console.WriteLine("  Площадь - " + Area());
            Console.WriteLine();
        }
    }
    class DemoPoint : IDemo
    {
        protected int x;
        protected int y;
        public DemoPoint(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public void Show() //реалiзацiя методу, оголошеного в iнтерфейсi
        {
            Console.WriteLine("точка на площинi: ({0}, {1})", X, Y);
        }
        public double Dlina() //реалiзацiя методу, оголошеного в iнтерфейсi
        {
            return Math.Sqrt(x * x + y * y);
        }
        public int X //реалiзацiя властивостi, оголошеної в iнтерфейсi
        {
            get
            {
                return x;
            }
        }
        public int Y //реалiзацiя властивостi, оголошеної в iнтерфейсi
        {
            get
            {
                return y;
            }
        }
        public int this[int i] //реалiзацiя iндексатора, оголошеного в iнтерфейсi
        {
            get
            {
                if (i == 0) return X;
                else if (i == 1) return Y;
                else throw new Exception("неприпустиме значення iндексу");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else throw new Exception("неприпустиме значення iндексу");
            }
        }
    }
    // клас DemoShape успадковує клас DemoPoint i iнтерфейс IDemo
    class DemoShape : DemoPoint, IDemo
    {
        protected int z;
        public DemoShape(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        // реалiзацiя методу, оголошеного в iнтерфейсi, з приховуванням однойменного методу з базового класу
        public new void Show()
        {
            Console.WriteLine("точка в пространстве: ({0}, {1}, {2})", X, Y,z);
        }
        // реалiзацiя методу, оголошеного в iнтерфейсi, з приховуванням однойменного методу з базового класу
        public new double Dlina()
        {
            return Math.Sqrt(X * X + Y * Y + z * z);
        }
        // реалiзацiя iндексатора, оголошеного в iнтерфейсi, з приховуванням  
        // однойменного iндексатора з базового класу
        public new int this[int i]
        {
            get
            {
                if (i == 0) return X;
                else if (i == 1) return Y;
                else if (i == 2) return z;
                else throw new Exception("неприпустиме значення iндексу");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else if (i == 2) z = value;
                else throw new Exception("неприпустиме значення iндексу");
            }
        }

    }
    class Program
    {
        static void Main()
        {
            // створення масиву iнтерфейсних посилань
            IDemo[] a = new IDemo[5];
            // заповнення масиву
            a[0] = new DemoPoint(0, 1);
            a[1] = new DemoPoint(-3, 0);
            a[2] = new DemoShape(3, 4, 0);
            a[3] = new DemoShape(0, 5, 6);

            IMeasurable[] opa = new IMeasurable[2];
            opa[0] = new Square(5);
            opa[1] = new Square(3.141);

            opa[0].Show();
            opa[1].Show();

            foreach (IDemo x in a)
            {
                x.Show();
                Console.WriteLine("Dlina={0:f2}", x.Dlina());
                Console.WriteLine("x=" + x.X);
                x[1] += x[0];
                Console.Write("новi координати - ");
                x.Show();
                Console.WriteLine();
            }
        }
    }
}