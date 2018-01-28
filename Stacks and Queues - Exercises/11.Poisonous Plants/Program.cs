namespace _11.Poisonous_Plants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            var numberOfPlants = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var comparePlants = new Stack<int>();
            var deathDays = new int[numberOfPlants];
            comparePlants.Push(0);

            for (int i = 1; i < plants.Length; i++)
            {
                var maxDays = 0;
                while (comparePlants.Count != 0 && plants[comparePlants.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, deathDays[comparePlants.Pop()]);
                }

                if (comparePlants.Count > 0)
                {
                    deathDays[i] = maxDays + 1;
                }

                comparePlants.Push(i);
            }

            Console.WriteLine(deathDays.Max());
        }
    }
}
