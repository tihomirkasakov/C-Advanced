namespace _01.Reverse_Strings
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> reverse = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reverse.Push(input[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(reverse.Pop());
            }
            Console.WriteLine();
        }
    }
}
