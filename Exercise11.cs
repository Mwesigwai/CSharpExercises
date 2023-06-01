using System;

namespace CS
{
    class Exercise11
    {
        public static void Main(string[] args)
        {
            bool tempIsCorrect;
            int temperature;
            do
            {
                Console.WriteLine("What is the temperature ");
                string tempString = Console.ReadLine();
                tempIsCorrect = int.TryParse(tempString, out int result);
                if (tempIsCorrect)
                {
                    temperature = result;
                }


                else
                {
                    Console.WriteLine("Wrong input");
                }
            } while (!tempIsCorrect); 

        }
    }
}

