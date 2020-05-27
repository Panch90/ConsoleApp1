using System;

namespace labka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Размер массива:");
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] aray = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    aray[i, j] = random.Next(-10, 10);
                }
            }
            Console.WriteLine("Полученый массив:");
            Action<int> action = Show;
            MethodAct(aray, action);
            Console.WriteLine("\nПоложительные элементы:");
            action = ShowPositive;
            MethodAct(aray, action);
            Func<int, int> func = Mult3;
            MethodFunc(aray, func);
            Console.WriteLine("\nРезультат умножения матрицы на 3:");
            action = Show;
            MethodAct(aray, action);
        }
        static void MethodAct(int[,] array, Action<int> act)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    act(array[i, j]);
                }
            }
        }
        static void MethodFunc(int[,] array, Func<int, int> func)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = func(array[i, j]);
                }
            }
        }
        static void Show(int num)
        {
            Console.Write($"{num} ");
        }
        static void ShowPositive(int num)
        {
            if (num >= 0)
                Console.Write($"{num} ");
        }
        static int Mult3(int num)
        {
            return 3 * num;
        }
        
    }
}