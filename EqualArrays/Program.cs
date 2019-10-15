using System;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split();
            var secondLine = Console.ReadLine().Split();

            bool hasDiff = false;

            int length = Math.Min(firstLine.Length, secondLine.Length);

            for (int i = 0; i < length; i++)
            {
                if (firstLine[i] != secondLine[i])
                {
                    Console.WriteLine($"Diff at index {i}");
                    hasDiff = true;
                    break;
                }
            }

            if (!hasDiff && firstLine.Length != secondLine.Length)
            {
                Console.WriteLine($"Diff at index {length}");
                return;
            }

            if (!hasDiff)
            {
                Console.WriteLine("Equal arrays");
            }
        }
    }
}
