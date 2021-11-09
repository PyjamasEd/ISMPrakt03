using System;

namespace ForConsole5
{
    class Program
    {
        static int factorial(int N)
        {
            int summa2 = 0;
            int suma = 1;
            for (int b = 1; b <= N; b++)
            {
                for (int i = 1; i <= b; i++)
                {
                    suma *= i;
                }
                summa2 += suma;
                suma = 1;
            }
            return summa2;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть число:");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0)
            {
                Console.WriteLine(factorial(N));
            }
        }
    }
}
