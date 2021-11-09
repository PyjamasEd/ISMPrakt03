using System;

namespace WhileConsole1
{
    class Program
    {
        static double suma(double N)
        {
            int a = 1;
            double sum = 0;
            while (N > 0)
            {
                sum += Math.Pow(a, N);
                a++;
                N--;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть N=");
            double N = Convert.ToDouble(Console.ReadLine());
            suma(N);
            Console.WriteLine(suma(N));
        }
    }
}
