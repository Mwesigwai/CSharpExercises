using System;
using System.Linq;

namespace CS
{
    class MainClass
    {
            public static void Main(string[] args)
            {
               int[] myNumbers = new int[10];
            myNumbers[0] = 54;
            myNumbers[1] = 43;
            myNumbers[2] = 53;
            myNumbers[3] = 22;
            myNumbers[4] = 32;
            myNumbers[5] = 90;
            myNumbers[6] = 76;
            myNumbers[7] = 49;
            myNumbers[8] = 89;
            myNumbers[9] = 67;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
            Console.WriteLine(myNumbers.Sum());
        }
    }

 }


