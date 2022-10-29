using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Task3
    {
        public bool HaveThroughHole(int[,,] cube)
        {
            if (HaveHorizontalThroughHole(cube) || HaveVerticalThroughHole(cube)) { return true; }

            return false;
        }

        public bool HaveHorizontalThroughHole(int[,,] cube)
        {
            int currentHoletLength = 0;

            // by x

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        if (cube[i, j, k] == 0) { currentHoletLength++; }
                        else { break; }
                    }

                    if (currentHoletLength == cube.GetLength(2)) { return true; }
                    currentHoletLength = 0;
                }
            }

            // by y

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        if (cube[i, k, j] == 0) { currentHoletLength++; }
                        else { break; }
                    }

                    if (currentHoletLength == cube.GetLength(2)) { return true; }
                    currentHoletLength = 0;
                }
            }

            return false;
        }

        public bool HaveVerticalThroughHole(int[,,] cube)
        {
            int currentHoletLength = 0;

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        if (cube[k, j, i] == 0) { currentHoletLength++; }
                        else { break; }
                    }

                    if (currentHoletLength == cube.GetLength(0)) { return true; }
                    currentHoletLength = 0;
                }
            }

            return false;
        }

        public int[,,] CreatingCube(int n)
        {
            int[,,] cube = new int[n, n, n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        cube[i, j, k] = random.Next(0, 2);
                    }
                }
            }

            return cube;
        }

        public void Print(int[,,] cube)
        {
            Console.WriteLine("From top to bottom.");

            for (int i = cube.GetLength(0) - 1; i >= 0; i--)
            {
                Console.WriteLine($"Level {i + 1}");

                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        Console.Write(cube[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
