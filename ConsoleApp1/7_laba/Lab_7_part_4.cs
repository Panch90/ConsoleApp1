using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main()
        {
            StreamReader bufer = new StreamReader("C:\\Users\\USER ONE\\Desktop\\\ConsoleApp1\\part3_from.txt");
            Stack<double> mas = new Stack<double>();

            while (!bufer.EndOfStream)
            {
                mas.Push(Convert.ToDouble(bufer.ReadLine()));
            }
            foreach (double w in mas)
            {
                Console.WriteLine(w);
            }


            StreamWriter bufer1 = new StreamWriter("C:\\Users\\USER ONE\\Desktop\\ConsoleApp1\\part3_to.txt", false);
            foreach( double w in mas)
            {
                bufer1.WriteLine(w);
            }

            bufer.Close();
            bufer1.Close();
        }
    }
}
