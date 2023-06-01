using System;

namespace Exercise
{
    class MainClass
    {
        public static int number;
        public static void Main(string[] args)
        {
            string usersChoice;
            do 
            { 
                int countingNumbers;

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
                    number = result;
                }
                else
                {
                    Console.WriteLine("Input was wrong");
                }
            } while (!userInput);

            for (countingNumbers = 1; countingNumbers <= 10; countingNumbers++)
            {
                Console.WriteLine(number + " * " + countingNumbers + " = " + (number * countingNumbers));
            }
                Console.WriteLine("Repeat? y for repeat");                                   
                usersChoice = Console.ReadLine();
        
        }while (usersChoice .Equals( "y" ) || usersChoice.Equals("Y")) ;

            //Console.WriteLine("The multiplication table for {0} is: ", number);
        }
    }
}


