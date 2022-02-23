using System;

namespace A._ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int n;
            string s;
           

            while (t > 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
                s = Console.ReadLine();

                if (n > 2)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    if (n == 1 || s == "10" || s == "01")
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                t--;
            }
        }
    }
}
