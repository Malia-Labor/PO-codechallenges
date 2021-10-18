using System;

namespace PoCodeChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;
            try
            {
                rows = Int32.Parse(Console.ReadLine());
                cols = Int32.Parse(Console.ReadLine());
                int[,] result = PrintGrid(rows, cols);

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        Console.Write(result[r,c] + " ");
                    }
                    Console.Write("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static int[,] PrintGrid(int rows, int cols)
        {
            int counter = 1;
            int[,] printArray = new int[rows, cols];
            for (int c = 0; c < cols; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    printArray[r, c] = counter;
                    counter++;
                }
            }
            return printArray;
        }
    }
}
