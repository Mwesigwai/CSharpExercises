using System;

namespace Exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, here is a fizz buzz game in counting numbers");
            Console.WriteLine("Its going to add fizz to numbers divisible by 3");
            Console.WriteLine("fizz buzz for the numbers divisible by both 3 and 5");
            Console.WriteLine("And just a number for the numbers that are not divisible by any");

            for (int i = 1; i <= 100; i++)
            {
                //Console.WriteLine(i);
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " fizz buzz");
                }
                 else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}

