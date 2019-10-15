using System;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var numbers = new int[input.Length];

            var evenSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }

            Console.WriteLine(evenSum);
        }
    }
}
