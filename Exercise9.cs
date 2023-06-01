using System;

namespace Exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(  "Enter a word to test if is a palindrome or not");
            string word = Console.ReadLine();

            char[] wordChar = word.ToCharArray();
            Console.WriteLine(wordChar);
           
            {
                Console.WriteLine("Palindrome");
            }

            /*else
            {
                Console.WriteLine("Not palindrome");
            }*/
        }
    }
}

