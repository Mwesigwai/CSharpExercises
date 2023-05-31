using System;

namespace Exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("This program will revert the order of the word you enter");
                Console.WriteLine("Enter a word and see how it is reverted");
                string word = Console.ReadLine();
                char[] wordAsChars = word.ToCharArray();
                //Console.WriteLine(wordAsChars[1]);
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    Console.Write(wordAsChars[i]);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Do you want to start again? ");
                Console.WriteLine("Type yes to restart");
                choice = Console.ReadLine();
            } while (choice == "yes");
        }
    }
}

