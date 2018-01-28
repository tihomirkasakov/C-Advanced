namespace _04.Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        static void Main()
        {
            var queue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToPush = queue[0];
            int elementsToPop = queue[1];
            int searchedElement = queue[2];

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            for (int i = elementsToPush-1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(searchedElement))
            {
                Console.WriteLine("true");
            }

            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }

            else if (!stack.Contains(searchedElement))
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
