using System;

namespace ForConsole3
{
    class Program
    {
        static double power(double a,int N)
        {
            double sum = 1;
            for (int i=1; i <= N; i++)
            {
                sum *= a;
                
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть степінь");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0)
            {
                power(a, N);
                Console.WriteLine(power(a, N));
            }
            else
            {
                Console.WriteLine("Помилка N < 0");
            }    
        }
    }
}
