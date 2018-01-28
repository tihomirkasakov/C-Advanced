namespace _03.Maximum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int queries = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxValue = new Stack<int>();
            for (int i = 0; i < queries; i++)
            {
                int[] input = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int type = input[0];

                if (type==1)
                {
                    stack.Push(input[1]);
                    if (maxValue.Count == 0)
                    {
                        maxValue.Push(input[1]);
                    }
                    else if (input[1]>maxValue.Peek())
                    {
                        maxValue.Push(input[1]);
                    }
                }
                else if (type==2)
                {
                    if (stack.Pop()==maxValue.Peek())
                    {
                        maxValue.Pop();
                    }
                }
                else if (type==3)
                {
                    Console.WriteLine(maxValue.Peek());
                }
            }
        }
    }
}
