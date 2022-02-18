using System;

namespace A___Distance
{
    class Program
    {

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < t; i++)
            {
                var Bcoordinates = Array.ConvertAll(Console.ReadLine().Split(" "), s => uint.Parse(s));

                if ((Bcoordinates[0] + Bcoordinates[1]) % 2 != 0)
                {
                    Console.WriteLine("-1 -1");
                }
                else
                {
                    if (Bcoordinates[0] > Bcoordinates[1])
                    {
                        Console.WriteLine("{0} {1}", Bcoordinates[0] - ((Bcoordinates[0] + Bcoordinates[1]) / 2), Bcoordinates[1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", Bcoordinates[0], Bcoordinates[1] - ((Bcoordinates[0] + Bcoordinates[1]) / 2));
                    }
                }
            }

        }
    }
}
