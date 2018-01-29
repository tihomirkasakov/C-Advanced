namespace _02._Square_With_Maximum_Sum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            //2.Square With Maximum Sum
            //Write a program that read a matrix from console. Then find biggest sum of 2x2 submatrix and print it to console.
            //On first line you will get matrix sizes in format rows, columns.
            //One next rows lines you will get elements for each column separated with coma.
            //Print biggest top - left square, which you find and sum of its elements.

            var size = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] maxSumArray = new int[size[0], size[1]];

            // input
            for (int row = 0; row < maxSumArray.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int columns = 0; columns < maxSumArray.GetLength(1); columns++)
                {
                    maxSumArray[row, columns] = input[columns];
                }
            }

            // calculation
            int[,] maxElements = new int[2, 2];
            int maxSum = int.MinValue;
            for (int row = 0; row < maxSumArray.GetLength(0)-1; row++)
            {
                for (int col = 0; col < maxSumArray.GetLength(1)-1; col++)
                {
                    int currentSum = maxSumArray[row, col] + maxSumArray[row + 1, col] + maxSumArray[row, col + 1] + maxSumArray[row + 1, col + 1];
                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;
                        maxElements[0, 0] = maxSumArray[row, col];
                        maxElements[1, 0] = maxSumArray[row + 1, col];
                        maxElements[0, 1] = maxSumArray[row, col + 1];
                        maxElements[1, 1] = maxSumArray[row + 1, col + 1];
                    }
                }
            }

            //print result
            for (int i = 0; i < maxElements.GetLength(0); i++)
            {
                for (int j = 0; j < maxElements.GetLength(1); j++)
                {
                    Console.Write(maxElements[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
