using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Task1
    {
        public Task1()
        {
        }

        public int[,] VerticalSnake(int Row, int Column)
        {
            int[,] res = new int[Row, Column];

            int k = 1;

            for (int i = 0; i < Column; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < Row; j++)
                    {
                        res[j, i] = k++;
                    }
                }
                else
                {
                    for (int j = Row - 1; j >= 0; j--)
                    {
                        res[j, i] = k++;
                    }
                }
            }

            return res;
        }

        public int[,] DiagonalSnake(int n)
        {
            int[,] res = new int[n, n];

            int k = 1;

            for (int i = 0; i < n*2; i++)
            {
                if (i < n)
                {
                    if (i % 2 == 0)
                    {
                        int l = 0;
                        for (int j = i; j >= 0; j--)
                        {
                            res[j, l++] = k++;
                        }
                    }
                    else
                    {
                        int l = i;
                        for (int j = 0; j <= i; j++)
                        {
                            res[j, l--] = k++;
                        }
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        int l = n - 1;
                        for (int j = i - n + 1; j < n; j++)
                        {
                            res[l--, j] = k++;
                        }
                    }
                    else
                    {
                        int l = n - 1;
                        for (int j = i - n + 1; j < n; j++)
                        {
                            res[j, l--] = k++;
                        }
                    }
                }
            }

            return res;
        }

/*        public void ReverseMatrix(int[,] matrix)
        {
            Task1 newMat = new Task1();

            newMat.Print(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, matrix.GetLength(1) - j - 1];
                    matrix[i, matrix.GetLength(1) - j - 1] = temp;
                }
            }
            Console.WriteLine();
            newMat.Print(matrix);
        }*/

        public void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
