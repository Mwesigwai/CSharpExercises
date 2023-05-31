using System;

namespace CS
{
    class Exercise7
    {
        public static int result;
        public static void Main(string[] args)
        {

            int usersGuess;
            bool userIsTrue;
            Console.WriteLine("NUmber guesing program");

            Random myNumbers = new Random();
            int randomNumbers = myNumbers.Next(1, 10);

            do
            {
                Console.WriteLine("Enter numbers from 1 upto 10 to see if you win");
                string userINput = Console.ReadLine();
                userIsTrue = int.TryParse(userINput, out result) && result >= 1 && result <= 10; ;

                if (userIsTrue)
                {
                    usersGuess = result;

                    for (int i = 0; i < 2; i++)
                    {
                        if (usersGuess != randomNumbers)
                        {
                            Console.WriteLine("try again");
                            userINput = Console.ReadLine();
                            //userIsTrue = int.TryParse(userINput, out result) && result >= 1 && result <= 10; ;
                        }
                    }

                    if (result == randomNumbers)
                        Console.WriteLine("You won!!!!!!!!!!!!!!!");
                    else
                        Console.WriteLine("You lose");

                    //TestLimit(result);
                    //shouldContinue = usersGuess >= 1 && usersGuess <= 10;
                    /* do
                     {
                         Console.WriteLine("Number must start from 1 to 10");
                         if (shouldContinue)
                         {

                         }
                     }
                     while (!shouldContinue)*/

                }
            } while (!userIsTrue);

        }
    }
}






