using System;

namespace _3or5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 999; i++)
            {
                if (i%3 ==0 || i%5 == 0)
                    sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
