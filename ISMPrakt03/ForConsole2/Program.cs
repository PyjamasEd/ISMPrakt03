using System;

namespace ForConsole2
{
    class Program
    {
        static double sumaN(double N)
        {
            double sum = 0;
            for(int i=1; i <=N;i++)
            {
                sum += 1.0 / i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть N:");
            double N = Convert.ToDouble(Console.ReadLine());
            if (N > 0)
            {
                sumaN(N);
                Console.WriteLine(sumaN(N));
            }
            else
            {
                Console.WriteLine("Помилка N < 0");
            }
        }
    }
}
