using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string wordToReplace = bannedWords[i];
                text = text.Replace(wordToReplace, new string('*', wordToReplace.Length));
            }
            Console.WriteLine(text);
        }
    }
}
