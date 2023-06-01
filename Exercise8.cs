using System;

namespace CS
{
    class Exercise8

    {
        public static string usersChoice;
        public static int temperature;
        public static void Main(string[] args)
        {
            Console.WriteLine("This program converts temprature from degrees celsius to degrees fahrenheit and vise-vasa");
            Console.WriteLine("Enter c to convert from degrees fahrenheit to celsius");
            Console.WriteLine("Or f to convert from degrees celsius to degrees fahranheit");


            do
            { 
            Console.WriteLine("Waiting for your option c or f?");
            usersChoice = Console.ReadLine();
           
                if (usersChoice == "f" || usersChoice == "F")
                {
                    //Console.WriteLine("gggggg");
                    ChangeToFahrenheit();
                    break;
                }

                if (usersChoice == "c" || usersChoice .Equals("C"))
                {
                    //Console.WriteLine("Ch");
                    ChangeToCelsius();
                    break;
                }

                else
                {
                    Console.WriteLine("Enter a valid option");
                }
            } while (usersChoice != "f" || usersChoice != "F" || usersChoice != "c" || usersChoice != "C");
        }

        public static void ChangeToFahrenheit()
        {
            PromptUser("degrees celsius");
             float fahrenheit =  (float)9 / 5 * temperature;
           float result = fahrenheit + 32;
            Console.WriteLine("The temperature is " + result + " degrees fahrenheit");   
        }




        public static void ChangeToCelsius()
        {
            PromptUser("degrees fahrenheit");
            Console.WriteLine("The temperature is " + (temperature - 32) * 5/9 + 
            " degrees celsius" );

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
                    temperature = result;
                }
                else
                {
                    Console.WriteLine("Temp must be in numbers and in correct range");
                    tempString = Console.ReadLine();

                }
            } while (!isTrueTemp);
        }
    }
}





