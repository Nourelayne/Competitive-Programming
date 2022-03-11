using System;

namespace _1633A___Div._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int rest;
            int lastDigit;
            int result;

            int t = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < t; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                rest = n % 7;
                lastDigit = n % 10;

                if (rest <= lastDigit)
                {
                    result = n - rest;
                    Console.WriteLine(result);
                }
                else
                {
                    result = n + (7 - rest);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
