namespace _08.Recursive_Fibonacci
{
    using System;

    public class RecursiveFibonacci
    {
        private static long[] memoization;
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            memoization = new long[n];
            Console.WriteLine(GetFibonacci(n));
        }

        public static long GetFibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            if (memoization[n - 1] != 0)
            {
                return memoization[n - 1];
            }

            return memoization[n - 1] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }

}
