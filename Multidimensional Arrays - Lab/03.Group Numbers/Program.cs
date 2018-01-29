namespace _03.Group_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            //3.Group Numbers
            //Read a set of numbers and group them by their remainder when dividing to 3 (0, 1 and 2).
            //One first line, you will get numbers separated with coma and whitespace.
            var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] size = new int[3];

            foreach (var item in input)
            {
                int reminder = Math.Abs(item % 3);
                size[reminder]++;
            }

            //initialize 
            int [][] initializeArray = new int[3][];
            for (int row = 0; row < size.Length; row++)
            {
                initializeArray[row] = new int[size[row]];
            }

            //input in array
            int[] index = new int[3];

            for (int i = 0; i < input.Length; i++)
            {
                var reminder = Math.Abs(input[i] % 3);
                initializeArray[reminder][index[reminder]] = input[i];
                index[reminder]++;
            }

            //print array with results
            for (int row = 0; row < initializeArray.Length; row++)
            {
                for (int col = 0; col < initializeArray[row].Length; col++)
                {
                    Console.Write(initializeArray[row][col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
