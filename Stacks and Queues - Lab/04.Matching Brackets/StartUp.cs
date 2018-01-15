namespace _04.Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    stack.Push(i);
                }

                else if (input[i] == ')')
                {
                    int startIndex = stack.Pop();
                    string context = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(context);
                }
            }
        }
    }
}
