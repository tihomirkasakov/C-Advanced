namespace _07.Balanced_Parentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var openParentheses = new Stack<char>();
            var cases = new[] { '[', '{', '(' };

            for (int i = 0; i < input.Length; i++)
            {
                if (cases.Contains(input[i]))
                {
                    openParentheses.Push(input[i]);
                }
                else
                {
                    if (openParentheses.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    switch (input[i])
                    {
                        case ']':
                            if (openParentheses.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case '}':
                            if (openParentheses.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (openParentheses.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
