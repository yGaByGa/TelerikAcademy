using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023.MaxSumOf3x3
{
    class MaxSum3x3
    {
        static void Main()
        {
            int n, m;

            //Enter the size of the matrix [n, m] on single line
            string[] inputNandM = Console.ReadLine().Split();
            n = Convert.ToInt32(inputNandM[0]);
            m = Convert.ToInt32(inputNandM[1]);

            //enter the size n and m on two lines
            //Console.Write("n = ");
            //string Nvalue = Console.ReadLine();
            //int n = int.Parse(Nvalue);

            //Console.Write("m = ");
            //string Mvalue = Console.ReadLine();
            //int m = int.Parse(Mvalue);

            //int[,] matrix = new int[n, m];

            //input the all line of matrix and save it
            var matrix = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var spl = line.Split(' ');
                if (spl.Length != m) throw new FormatException();
                for (var j = 0; j < m; j++)
                    matrix[i, j] = int.Parse(spl[j]);
            }

            //if need to make random matrix
            //matrix = RandomMatrix(matrix, n, m);
            //Console.WriteLine();

            //print patrix for check
            //PrintTheMatrix(matrix, n, m);
            //Console.WriteLine();
            BestSum(matrix);
        }

        static void BestSum(int[,] matrix)
        {
            //calculete best sum on Matrix with size 3x3
            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            Console.WriteLine(bestSum);
        }

        static void PrintTheMatrix(int[,] matrix, int n, int m)
        {
            //print matrix for check
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static int[,] RandomMatrix(int[,] matrix, int n, int m)
        {
            //put rnd numbers in matrix for check
            Random number = new Random();

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = number.Next(40);
                }
            }
            return matrix;
        }
    }
}
