using System;

namespace A___Long_Comparison
{
    class Program
    {

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < t; i++)
            {
                var firstInput = Array.ConvertAll(Console.ReadLine().Split(" "), s => double.Parse(s));
                var secondInput = Array.ConvertAll(Console.ReadLine().Split(" "), s => double.Parse(s));

                var answer = Math.Log10(firstInput[0] / secondInput[0]) + firstInput[1] - secondInput[1];

                if (answer == 0)
                {
                    Console.WriteLine('=');
                }
                else
                {
                    if (answer < 0) Console.WriteLine('<');
                    else Console.WriteLine('>');
                }
            }
        }
    }
}
