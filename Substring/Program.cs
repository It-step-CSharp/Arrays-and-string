using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string elementToRemove = Console.ReadLine();
            string str = Console.ReadLine();
            int index = 0;
            while (index >= 0)
            {
                index = str.ToLower().IndexOf(elementToRemove.ToLower());
                if (index >= 0)
                {
                    str = str.Remove(index, elementToRemove.Length);
                }
            }
            Console.WriteLine(str);
        }
    }
}
