using System;

namespace CS
{
    class Exercise8

    {
        public static string usersChoice;
        public static void Main(string[] args)
        {
            Console.WriteLine("This program converts temprature from degrees celcius to degrees fahranheit and vise-vasa");
            Console.WriteLine("Enter c to convert from degrees fahranheit to celcius");
            Console.WriteLine("Or f to covert from degrees celcius to degrees fahranheit");


            do
            { 
            Console.WriteLine("Waiting for your option c or f?");
            usersChoice = Console.ReadLine();
           
                if (usersChoice == "f" || usersChoice == "F")
                {
                    Console.WriteLine("gggggg");
                    //ChangeToFahranheit();
                    break;
                }

                if (usersChoice == "c" || usersChoice .Equals("C"))
                {
                    Console.WriteLine("Ch");
                    //ChangeToCelcius();
                    break;
                }

                else
                {
                    Console.WriteLine("Enter a valid option");
                }
            } while (usersChoice != "f" || usersChoice != "F" || usersChoice != "c" || usersChoice != "C");
        }

        public static void ChangeToFahranheit()
        {

        }

        public static void PromptUser(string tempScale)
        {
            bool isTrueTemp;
            Console.WriteLine("Enter temperature in " + tempScale);
            string tempString = Console.ReadLine();
            do
            {
                isTrueTemp = int.TryParse(tempString, out int result);
                if (isTrueTemp)
                {
                    int temperature = result;
                }
                else
                {
                    Console.WriteLine("Temp must be in numbers and in correct range");
                }
            } while (!isTrueTemp);
        }
    }
}


