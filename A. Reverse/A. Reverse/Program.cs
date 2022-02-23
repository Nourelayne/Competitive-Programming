using System;

namespace A._Reverse
{
    class Program
    {
        static void RearrengeArray(int[] arr, int l, int r)
        {
            int c ;
            int length = r - l + 1;
            for (int j = l; j <= r - length/2; j++)
            {
                c = arr[j];
                arr[j] = arr[r - (j - l)];
                arr[r - (j - l)] = c;
            }
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t > 0)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                int[] permutation = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
                for(int i = 0; i < length; i++)
                {
                    if(permutation[i] != i + 1)
                    {
                        int index = Array.IndexOf(permutation, i + 1);
                        RearrengeArray(permutation, i, index);
                        break;
                    }
                }
                
                foreach(int i in permutation)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                t--;
            }
        }
    }
}
