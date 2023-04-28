using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to Money Maker! \n");

            //Requesting user input
            Console.WriteLine("What is the amount in cents you would like to convert to coins? No decimals please. ");
            string amount_as_string = Console.ReadLine();
            double amount_as_double = Convert.ToDouble(amount_as_string);
            Console.WriteLine();
            Console.WriteLine(amount_as_string + " cents is equal to... ");

            //Define coin values
            int quarter = 25;
            int dime = 10;
            int nickel = 5;
            double remainder;

            //Find max number of dimes
            double max_quarters = Math.Floor(amount_as_double / 25);
            remainder = amount_as_double % quarter;
            double max_dimes = Math.Floor(remainder / dime);
            remainder = remainder % dime;
            double max_nickel = Math.Floor(remainder / nickel);
            remainder = remainder % nickel;

            Console.WriteLine("Quarters: " + max_quarters);
            Console.WriteLine("Dimes: " + max_dimes);
            Console.WriteLine("Nickels: " + max_nickel);
            Console.WriteLine("Pennies: " + remainder + "\n");
            Console.WriteLine("Program has ended");

        }
    }
}
