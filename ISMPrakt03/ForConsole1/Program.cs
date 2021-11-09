using System;

namespace ForConsole1
{
    class Program
    {
        static int FromAtoB(int a, int b)
        {
            int sum = 0;
            for(int i=a; i <=b; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
           

            Console.WriteLine("Введіть перше число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число:");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a < b)
            {
                FromAtoB(a, b);
                Console.WriteLine(FromAtoB(a, b));
            }
        }
    }
}
