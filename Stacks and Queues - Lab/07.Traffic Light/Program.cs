namespace _07.Traffic_Light
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            int carPass = int.Parse(Console.ReadLine());
            var car = Console.ReadLine();
            var queue = new Queue<string>();
            var carCount = 0;

            while (car!= "end")
            {
                if (car=="green")
                {
                    var carThatHaveToPass = Math.Min(queue.Count, carPass);
                    for (int i = 0; i < carThatHaveToPass; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        carCount++;
                    }
                }
                else
                {
                    queue.Enqueue(car);
                }
                car = Console.ReadLine();
            }

            Console.WriteLine($"{carCount} cars passed the crossroads.");
        }
    }
}
