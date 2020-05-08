using System;
using System.Collections.Generic;

namespace Consolka
{
    class Program
    {
        static void Main()
        {
            Stack<Vesillia> bigObj = new Stack<Vesillia>();
            Vesillia w = new Vesillia();
            
            Console.WriteLine("  Яку кiлькiсть весіль заповнити бажаєте? ");
            Console.Write("  га - ");
            int bufer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < bufer; i++)
            {
                w.GetInformation();
                bigObj.Push(w);
            }

            try
            {
                for (int i = 0; i < bufer; i++)
                {
                    Console.WriteLine(bigObj.Peek());
                    bigObj.Pop();
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(" Error! { 0}", ex.Message);
            }
        }
    }
}