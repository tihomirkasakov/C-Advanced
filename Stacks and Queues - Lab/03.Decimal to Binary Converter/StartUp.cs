namespace _03.Decimal_to_Binary_Converter
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            if (input==0)
            {
                Console.WriteLine(input);
            }

            else if (input>0)
            {
                while (input>0)
                {
                    stack.Push(input%2);
                    input /= 2;
                }
            }

            while (stack.Count>0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
