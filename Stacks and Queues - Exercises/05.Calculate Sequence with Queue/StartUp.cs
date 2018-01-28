namespace _05.Calculate_Sequence_with_Queue
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var input = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            queue.Enqueue(input);
            List<long> numbers = new List<long>();

            while (numbers.Count<50)
            {
                var number = queue.Dequeue();
                numbers.Add(number);
                var firstCalculation = number + 1;
                var secondCalculation = 2 * number + 1;
                var thirdCalculation = number + 2;

                queue.Enqueue(firstCalculation);
                queue.Enqueue(secondCalculation);
                queue.Enqueue(thirdCalculation);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(numbers[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
