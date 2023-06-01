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
                    if (temperature <= 0)
                    {
                        Console.WriteLine(" opss!! Freezing weather");
                    }

                    else if(temperature > 0 && temperature <= 10)
                    {
                        Console.WriteLine("Very cold weather");
                    }

                    else if (temperature >= 10 && temperature <= 20)
                    {
                        Console.WriteLine("Normal temperature");
                    }

                    else if (temperature >= 20 && temperature <= 30)
                    {
                        Console.WriteLine("It is hot");
                    }

                    else if (temperature >= 40)
                    {
                        Console.WriteLine("It's very hot");
                    }

                }
