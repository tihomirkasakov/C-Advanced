namespace _09.Stack_Fibonacci
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Stack<long> stack = new Stack<long>();
            Queue<long> pastNumber = new Queue<long>();

            stack.Push(1);
            pastNumber.Enqueue(0);

            for (int i = 1; i < input; i++)
            {
                pastNumber.Enqueue(stack.Peek());
                stack.Push(pastNumber.Dequeue() + stack.Peek());
            }

            Console.WriteLine(stack.Peek());
        }
    }
}
