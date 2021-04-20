using System;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            string mex = "Mexico";
            string jam = "Jamaica";
            Console.WriteLine("Welcome to the Vacation Budget Planner XL!\r\nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Would you like to travel to {mex} or {jam}?");           
            Console.ReadLine();
            Console.WriteLine("How many days will you be spending in sunny Jamaica?");
            int days = Int16.Parse(Console.ReadLine());
            Console.WriteLine("How much spending money do you have for your trip?");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine($"Well, {name}, it looks like you will be spending {days} days in Jamaica with {money:c} to spend.\r\nThat means you can spend up to {money/days:c} per day while you are there.");
            Console.ReadLine();
        }
    }
}
