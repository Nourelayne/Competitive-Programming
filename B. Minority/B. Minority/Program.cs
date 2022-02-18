using System;

namespace B._Minority
{
    class Program
    {

        static int GetOccurrencesOfCharInString(string s, char c)
        {
            int numberOfOccurences = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    numberOfOccurences++;
                }
            }

            return numberOfOccurences;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int numberOfZeros = 0;

            int numberOfOnes = 0;

            for (var i = 0; i < t; i++)
            {
                string s = Console.ReadLine();

                numberOfZeros = GetOccurrencesOfCharInString(s, '0');

                numberOfOnes = GetOccurrencesOfCharInString(s, '1');

                if (numberOfZeros == numberOfOnes)
                {
                    Console.WriteLine(numberOfZeros - 1);
                }
                else
                {
                    Console.WriteLine(Math.Min(numberOfZeros, numberOfOnes));
                }
            }
        }
    }
}