using System;

namespace WhileConsole2
{
    class Program
    {
        static int find(int N)
        {
            int K = 1;
            int tmp = 3;
            if (N>1)
            { 
            while (tmp < N)
            {
                tmp *= 3;
                ++K;
            }
            }
            return K;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть N=");
            int N = Convert.ToInt32(Console.ReadLine());
            find(N);
            Console.WriteLine(find(N));
        }
    }
}
