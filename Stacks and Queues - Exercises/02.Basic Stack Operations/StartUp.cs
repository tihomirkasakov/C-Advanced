namespace _02.Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var firstLine = Console.ReadLine().Split(' ');
            int pushElements = int.Parse(firstLine[0]);
            int popElements = int.Parse(firstLine[1]);
            int checkElement = int.Parse(firstLine[2]);

            var secondLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < pushElements; i++)
            {
                stack.Push(secondLine[i]);
            }

            for (int i = 0; i < popElements; i++)
            {
                stack.Pop();
            }

            bool containsElement = false;
            if (stack.Contains(checkElement))
            {
                containsElement = true;
            }

            int minValue = int.MaxValue;
            if (!containsElement)
            {
                if (stack.Count == 0)
                {
                    minValue = 0;
                }
                while (stack.Count > 0)
                {
                    var checkValue = stack.Pop();
                    if (minValue > checkValue)
                    {
                        minValue = checkValue;
                    }
                }
                Console.WriteLine(minValue);
            }

            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
