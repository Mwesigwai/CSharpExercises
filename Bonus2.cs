using System;

namespace Exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool userInput;
            Console.WriteLine("This program prints a multiplication table of the number you enter upto ten numbers");
            Console.WriteLine("Enter a number");
            do
            {
                Console.WriteLine("Make sure it is a real number");
                string numString = Console.ReadLine();
                userInput = int.TryParse(numString, out int result);

                if (userInput)
                {
                    int number = result;
                }
                else
                {
                    Console.WriteLine("Input was wrong");
                }
            } while (!userInput);

        }
    }
}

