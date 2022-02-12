using System;

namespace A._ABC
{
    class Program
    {
        static bool IsPalindrome(string s)
        {
            int length = s.Length;
          
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - i - 1])
                    return false;
            }
            return true;
        }

        static bool ContainsAPalindrome(string s)
        {
            if(s.Length <= 1)
            {
                return false;
            }
            if (!IsPalindrome(s))
            {
                return ContainsAPalindrome(s.Remove(s.Length - 1));
            }
            return true;
        }

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

            int n;
            string s;
            bool palindromeExist;
            int numberOfZeros;
            int numberOfOnes;

            while (t > 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
                s = Console.ReadLine();
                palindromeExist = ContainsAPalindrome(s);
                numberOfZeros = GetOccurrencesOfCharInString(s, '0');
                numberOfOnes = GetOccurrencesOfCharInString(s, '1');
                
                if (palindromeExist)
                {
                    if((n % 2 == 0 && (numberOfOnes % 2 != 0 || numberOfZeros % 2 != 0)) || (n % 2 != 0 && (numberOfOnes >= n / 2 || numberOfZeros >= n / 2)))
                    {
                        Console.WriteLine("YES"); 
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("YES");
                }

                t--;
            }
        }
    }
}
