using System;

namespace ForConsole4
{
    class Program
    {
        static double Sumofsquares(int a, int b)
        {
            double sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i * i;
            }
            return sum;

        }

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть b:");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a < b)
            { 
            Sumofsquares(a, b);
            Console.WriteLine(Sumofsquares(a, b));
            }
            else
            {
                Console.WriteLine("Помилка");
            }
        }
    }
}
