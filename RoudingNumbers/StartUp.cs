using System;

namespace RoudingNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var numbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(numbers[i] = Math.Round(double.Parse(input[i])));
            }
        }
    }
}
