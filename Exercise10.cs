using System;

namespace CS
{
    class Exercise10

    { 
        public static float tipAsPercentage;
        public static float billCharge;
        public static void Main(string[] args)
        {
            Console.WriteLine("This program requires the tip percentage you wish to leave" +
            	" and amount of bill you have to pay  ");
            Console.WriteLine("It calculates the amount of the tip and the total to total amount with the tip amount");
            CalculateTip();

        }

        public static void CalculateTip()
        {
            bool isCorrectTip;
            bool goodInput;
            do
            {
                Console.WriteLine("Enter tip percentage you wish to leave");
                string tipStr = Console.ReadLine();
                isCorrectTip = float.TryParse(tipStr, out float result);
                if (isCorrectTip)
                {
                    tipAsPercentage = result/100;
                    //Console.WriteLine(tipAsPercentage);
                }
            } while (!isCorrectTip);
            do
            {
                Console.WriteLine("Enter the bill charge");
                string bill = Console.ReadLine();
                goodInput = float.TryParse(bill, out float result);
                if (goodInput)
                {
                    billCharge = result;
                }

            } while (!goodInput);

            Console.WriteLine("Tip of the bill charge = {0}", tipAsPercentage * billCharge);
        }
    }
}


