using System;
using System.Collections.Generic;
using System.Linq;

namespace лр
{
    class Tovar
    {
        public string name { get; set; }
        public double price { get; set; }
        public double amount { get; set; }
        public double date { get; set; }


        public Tovar(string name, double price, double amount, double date)

        {
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.date = date;
        }

        public static int SortName(Tovar x, Tovar y)
        {
            int ret = x.name.CompareTo(y.name);
            if (ret != 0)
                return ret;
            return x.name.CompareTo(y.name);
        }

        public static int SortPrice(Tovar x, Tovar y)
        {
            int ret = x.price.CompareTo(y.price);
            if (ret != 0)
                return ret;
            return x.price.CompareTo(y.price);
        }

        public static int SortAmount(Tovar x, Tovar y)
        {
            int ret = x.amount.CompareTo(y.amount);
            if (ret != 0)
                return ret;
            return x.amount.CompareTo(y.amount);
        }
        public static int SortDate(Tovar x, Tovar y)
        {
            int ret = x.name.CompareTo(y.date);
            if (ret != 0)
                return ret;
            return x.date.CompareTo(y.date);
        }


    }


    class Program
    {
        static void Sort(List<Tovar> list, Func<Tovar, Tovar, int> comparer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (comparer(list[i], list[j]) > 0)
                    {
                        var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            List<Tovar> tovars = new List<Tovar>()
            {
                new Tovar("Cucumber", 33, 300, 25),
                new Tovar("Cheese", 120, 150, 10),
                new Tovar("Cherry", 90, 500, 50)

            };

            Sort(tovars, Tovar.SortName); 
            Console.WriteLine("Список товаров:\r\n"
            + string.Join("\r\n", tovars.Select(st => st.name)));
            Console.WriteLine();

            Sort(tovars, Tovar.SortPrice);
            Console.WriteLine("Список товаров по цене:\r\n"
            + string.Join("\r\n", tovars.Select(st => st.name + " " + st.price + "руб")));

            Console.WriteLine();

            Sort(tovars, Tovar.SortAmount); 
            Console.WriteLine("Список товаров по количеству:\r\n"
            + string.Join("\r\n", tovars.Select(st => st.name + " " + st.amount + "шт")));

            Console.WriteLine();

            Sort(tovars, Tovar.SortDate); 
            Console.WriteLine("Список товаров по дате:\r\n"
            + string.Join("\r\n", tovars.Select(st => st.name + " " + st.date + "дней")));
            Console.WriteLine();
        }
    }
}