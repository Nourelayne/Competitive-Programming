using System;

namespace A._Not_Shading
{
    class Program
    {
        static int Resolve(int n, int m, int r, int c, char[,] board)
        {
            bool blackExists = false;

            if(board[r, c] == 'B')
                return 0;

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < m; k++)
                {
                    if (board[j, k] == 'B')
                    {
                        blackExists = true;
                        if (j == r || k == c)
                        {
                            return 1;
                        }
                    }
                }
            }

            if (blackExists)
                return 2;
            else
                return -1;
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            char[,] board;
            int[] input;
            int result;

            for(int i = 0; i < t; i++)
            {
                input = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));

                board = new char[input[0], input[1]];
                for(int j = 0; j < input[0]; j++)
                {
                    string cell = Console.ReadLine();
                    for (int k = 0; k < input[1]; k++)
                    {
                        board[j,k] = cell[k];
                    }
                }

                result  = Resolve(input[0], input[1], input[2] - 1, input[3] - 1, board);

                Console.WriteLine(result);
            }
        }
    }
}
