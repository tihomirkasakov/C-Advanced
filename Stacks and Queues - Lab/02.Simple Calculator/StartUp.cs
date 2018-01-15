namespace _02.Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<string>(input.Split(' ').Reverse());

            while (stack.Count>1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var operand = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());

                if (operand=="+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }
                else
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
            }

            Console.WriteLine(stack.Peek());
        }
    }
}
