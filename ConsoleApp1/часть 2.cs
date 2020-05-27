using System;
using System.IO;

namespace lab_bp
{
    class Program
    {
        static void Main()
        {
            StreamReader read = new StreamReader("C:\\Users\\OneDrive\\Laba8.txt");
            string text = Convert.ToString(read.ReadToEnd());
            Console.WriteLine("Строка до изменений");
            Action<string> action = Show;
            ReadFile(text, action);
            Console.WriteLine("Строка после изменений");
            Func<string, string> func = ChangeZnak;
            string res = ReadFile(text, func);
            ReadFile(res, action);
        }


        
        static string ChangeZnak(string stroka)
        {
            stroka = stroka.Replace(')', ' ');
            stroka = stroka.Replace('(', ' ');

            stroka = stroka.Replace(',', ' ');
            stroka = stroka.Replace('.', ' ');

            stroka = stroka.Replace('*', ' ');

            return stroka;
        }
        static void ReadFile(string stroka, Action<string> action)
        { action(stroka); }
        static string ReadFile(string stroka, Func<string, string> func)
        { return func(stroka); }
        static void Show(string stroka)
        { Console.WriteLine(stroka); }
    }
}