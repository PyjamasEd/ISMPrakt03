using System;

namespace DoWhileConsole1
{
    class Program
    {
        static int sumDoWhile()
        {
            int a = 0;
            int read = 0;
            Console.WriteLine("Введіть любе число, введіть 0 для виходу");
            do
            {
                read = Convert.ToInt32(Console.ReadLine());
                a += read;
            } while (read != 0);

            return a;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(sumDoWhile());
        }
    }
}
