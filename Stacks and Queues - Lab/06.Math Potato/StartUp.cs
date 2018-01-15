namespace _06.Math_Potato
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var toss = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(input.Split(' '));

            var cycles = 1;

            while (queue.Count>1)
            {
                for (int i = 0; i < toss-1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                if (!PrimeTool.IsPrime(cycles))
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }

                else
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                cycles++;
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }

        public static class PrimeTool
        {
            public static bool IsPrime(int candidate)
            {
                // Test whether the parameter is a prime number.
                if ((candidate & 1) == 0)
                {
                    if (candidate == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                // Note:
                // ... This version was changed to test the square.
                // ... Original version tested against the square root.
                // ... Also we exclude 1 at the end.
                for (int i = 3; (i * i) <= candidate; i += 2)
                {
                    if ((candidate % i) == 0)
                    {
                        return false;
                    }
                }
                return candidate != 1;
            }
        }
    }
}
