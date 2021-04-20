using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Converting farenheit to celcius
            Console.WriteLine("Enter a temperature in Fahrenheit to have it converted to Celcius.");
            double f = double.Parse(Console.ReadLine());
            double c = ((f - 32) * 5 / 9);
            Console.WriteLine($"{f} degrees Fahrenheit is equivalent to {c} degrees Celcius.");
            Console.WriteLine("Press the Enter key for a sales tax calculator.");
            Console.ReadLine();
            //Sales Tax calculator
            Console.WriteLine("This is a sales tax caculator. Enter the price of a product before tax.");
            double productPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the sales tax rate of this product in percent?");
            double taxRate = double.Parse(Console.ReadLine());
            taxRate *= .01;
            double finalCost = (productPrice + (productPrice * taxRate));                                  
            Console.WriteLine($"The total cost of the product plus the sales tax is {finalCost:c}.");
            Console.WriteLine("Press the Enter key for a tip calculator.");
            Console.ReadLine();
            //Tip calculator
            Console.WriteLine("This is a tip calculator. Enter the price of the total bill.");
            double bill = double.Parse(Console.ReadLine());
            Console.WriteLine("What percentage would you like to tip?");
            double tipRate = double.Parse(Console.ReadLine());
            tipRate *= .01;
            Console.WriteLine($"Your tip will be {bill * tipRate:c} at the given rate of {tipRate * 100} percent.");
            Console.WriteLine("Press the Enter Key for a tool to help you split the bill.");
            Console.ReadLine();
            //Bill Dividends
            Console.WriteLine("This tool will help you with splitting a bill between multiple people. Enter the total bill.");
            double bill2 = double.Parse(Console.ReadLine());
            Console.WriteLine("How many people are splitting this bill?");
            int split = Int16.Parse(Console.ReadLine());
            Console.WriteLine($"Each person will owe {bill2 / split:c}.");
            Console.WriteLine("Press the Enter key to exit.");
            Console.ReadLine();
        }
    }
}
