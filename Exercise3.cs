using System;

namespace Exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program will revert the order of the word you enter");
            Console.WriteLine("Enter a word and see how it is reverted");
            string word = Console.ReadLine();
            char[] wordAsChars = word.ToCharArray();
            //Console.WriteLine(wordAsChars[1]);

        }
    }
}

