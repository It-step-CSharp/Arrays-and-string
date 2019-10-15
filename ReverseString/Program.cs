using System;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                Console.WriteLine($"{input} = {Reverse(input)}");
            }
        }

        private static string Reverse(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += input[input.Length - 1 - i];
            }
            return result;
        }
    }
}
