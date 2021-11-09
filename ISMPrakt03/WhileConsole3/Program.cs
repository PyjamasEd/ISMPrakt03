using System;

namespace WhileConsole3
{
    class Program
    {
        static double percentDistance(double P)
        {
            double start = 10;
            while (start <= 200)
            {
                start += start * P / 100;
            }
            return start;
        }

        static double day(double P)
        {
            double start = 10;
            int day = 1;
            while (start <= 200)
            {
                start += start * P / 100;
                day++;
            }
            return day;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть відсоток від пробігу(P)=");
            double P = Convert.ToDouble(Console.ReadLine());
            day(P);
            percentDistance(P);
            Console.WriteLine($"Кількість днів: {day(P)}\nСумарний пробіг: {percentDistance(P)}");
        }
    }
}
