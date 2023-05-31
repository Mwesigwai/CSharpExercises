using System;
using System.Linq;

namespace CS
{
    class MainClass
    {
        public static bool feedIsTrue;
        public static int result;
        public static void Main(string[] args)
        {
            //bool shouldContinue;
            int usersGuess;
            bool userIsTrue;
            Console.WriteLine("NUmber guesing program");

            do
            {
                Console.WriteLine("Enter numbers from 1 upto 10 to see if you win");
                string userINput = Console.ReadLine();
                userIsTrue = int.TryParse(userINput, out  result)&& result >= 1 && result <= 10; ;

                if (userIsTrue)
                {
                    usersGuess = result;
                    //TestLimit(result);
                    //shouldContinue = usersGuess >= 1 && usersGuess <= 10;
                   /* do
                    {
                        Console.WriteLine("Number must start from 1 to 10");
                        if (shouldContinue)
                        {

                        }
                    }
                    while (!shouldContinue);*/
                }
            } while (!userIsTrue);
        }

        /*public static void TestLimit(int feed)
        {
            feedIsTrue = feed >= 1 && feed <= 10;
            do
            {
                if (!feedIsTrue)
                {
                    Console.WriteLine("Number must start from 1 to 10");
                    if (feedIsTrue)
                    {

                    }
                }
            } while (!feedIsTrue);*/
        }
    }






