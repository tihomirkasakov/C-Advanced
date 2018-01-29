namespace _1._Sum_Matrix_Elements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var matrixSize = Console.ReadLine().Split(new char[] {' ',',' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int [matrixSize[0], matrixSize[1]];
            var sum = 0;

            for (int rows = 0; rows < matrixSize[0]; rows++)
            {
                var values = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int columns = 0; columns < matrixSize[1]; columns++)
                {
                    matrix[rows, columns] = values[columns];
                }
            }

            var matrixRows = matrix.GetLength(0);
            var matrixColumns = matrix.GetLength(1);


            for (int rows = 0; rows < matrixRows; rows++)
            {
                for (int columns = 0; columns < matrixColumns; columns++)
                {
                    sum += matrix[rows, columns];
                }
            }

            Console.WriteLine(matrixRows);
            Console.WriteLine(matrixColumns);
            Console.WriteLine(sum);
        }
    }
}
