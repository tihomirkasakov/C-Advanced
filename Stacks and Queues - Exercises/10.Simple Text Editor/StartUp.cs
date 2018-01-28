namespace _10.Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StartUp
    {
        static void Main()
        {
            var numberOfCommands = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            var stack = new Stack<string>();
            stack.Push("");

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split();
                var command = int.Parse(commands[0]);
                switch (command)
                {
                    case 1:
                        stack.Push(sb.ToString());
                        sb.Append(commands[1]);
                        break;
                    case 2:
                        stack.Push(sb.ToString());
                        int length = int.Parse(commands[1]);
                        sb.Remove(sb.Length-length,length);
                        break;
                    case 3:
                        int index = int.Parse(commands[1]);
                        Console.WriteLine(sb[index-1]);
                        break;
                    case 4:
                        sb.Clear();
                        sb.Append(stack.Pop());
                        break;
                }
            }
        }
    }
}
