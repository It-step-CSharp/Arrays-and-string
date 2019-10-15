using System;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            for (int i = 0; i < arr.Length; i++)
            {
                string currentElement = arr[i];
                for (int j = 0; j < currentElement.Length; j++)
                {
                    Console.Write(currentElement);
                }
            }
            Console.WriteLine();
        }
    }
}
