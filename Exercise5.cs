using System;

namespace Exercise
{
    class MyClass
    {
        public static int firstNumber;
        public static int secondNumber;
        public static string operatorSign;
        public static int result;
        public static float resultForDivision;

        public static void Main(string[] args)
        {

            Console.WriteLine("This is a simple basic calculator simulator");
            Console.WriteLine("Enter two numbers and select an operator sign" +
            	" +,-,/,or *");
            string userChoice;
            do
            {
                PromptNumbers();
                PromptSigns();

                switch (operatorSign)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        Console.WriteLine("The answer is " + result);
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        Console.WriteLine("The answer is " + result);
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        Console.WriteLine("The answer is " + result);
                        break;
                    case "/":
                        resultForDivision = (float)firstNumber / (float)secondNumber;
                        Console.WriteLine("The answer is " + resultForDivision);
                        break;
                }
                Console.WriteLine("Type yes to restart");
                userChoice = Console.ReadLine();
            } while (userChoice == "yes");
        }
        public static void PromptSigns()
        {
            while (true)
            {
                Console.WriteLine("Enter an operation sign");
                operatorSign = Console.ReadLine();
                if (operatorSign == "*" || operatorSign == "+" || operatorSign == "-" || operatorSign == "/")
                {
                    break;
                }
                else 
                Console.WriteLine("Wrong sign");
            }
        }

        public static void PromptNumbers()
        {
            bool isTrueInt;
            do
            {
                Console.WriteLine("Enter first number");
                isTrueInt = int.TryParse(Console.ReadLine(), out int result);

                if (isTrueInt)
                    firstNumber = result;
                else
                    Console.WriteLine("Input must be a number");
            } while (!isTrueInt);

            do
            {
                Console.WriteLine("Enter second number");
                isTrueInt = int.TryParse(Console.ReadLine(), out int result);

                if (isTrueInt)
                    secondNumber = result;
                else
                    Console.WriteLine("Input must be a number");
            } while (!isTrueInt);


        }
    }
}
