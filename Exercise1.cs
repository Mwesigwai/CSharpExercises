using System;

namespace Exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program tests a number if it is prime or not");
            Console.WriteLine("Enter one number to test");

            string userInput;
            int number;
            int factors = 0;
            bool isInt;
            string userChoice;
          
         do
         {  
           do
            {
                Console.WriteLine("Enter a number");
                userInput = Console.ReadLine();
                isInt = int.TryParse(userInput, out int result);

                if (isInt)
                {
                    number = result;
                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            factors = factors + 1;
                        }
                    }
                }

                if (!isInt)
                {
                    Console.WriteLine("Input must be a number, try again");
                }
            } while (!isInt);

            if (factors <= 2)
            {
                Console.WriteLine("Is a prime number");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
          
          //Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine("Do you want to restart?");
          Console.WriteLine("Enter yes to restart");
          userChoice = Console.ReadLine();
          }while(userChoice == "yes");
        }
    }
}

