using System;
using System.IO;
using System.Collections.Generic;

namespace Ylia
{
    class Program
    {
        static void Main()
        {
            List<IFigure> figure = new List<IFigure>();
            figure.Add(new Circle());
            figure.Add(new Circle(2));
            figure.Add(new Circle("Третий"));
            figure.Add(new Rectangle()); 
            figure.Add(new Rectangle(7,3.5));
            figure.Add(new Rectangle("Третий"));
            foreach (var i in figure)
            {
                i.PrintEcran();
                i.PrintFile();
            }
        }
    }
}
