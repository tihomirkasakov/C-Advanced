namespace _01.Reverse_Numbers_with_a_Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>(input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)).ToArray();

            Console.WriteLine(string.Join(" ",stack));
        }
    }
}
