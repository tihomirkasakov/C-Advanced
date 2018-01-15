namespace _05.Hot_Potato
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            int toss = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(input.Split(' '));

            while (queue.Count > 1)
            {
                for (int i = 0; i < toss-1; i++)
                {
                    var relocate = queue.Dequeue();
                    queue.Enqueue(relocate);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
