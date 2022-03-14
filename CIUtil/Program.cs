using System;

//Used for changing currency formating from $ to £
using System.Globalization;
using System.Threading;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            //NOTE: Changes currency formatting of ToString() from $ to £
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            Menu.Homepage();

        }

    }

    /*
     Menu Class: Generic-reuseable methods for user interface.
     TODO: Add Try/Catch validation.
     */

    public static class Menu
    {
        public static void Homepage()
        {
            Console.WriteLine("\nCompound Interest Calculator v1.3.0");

            Console.WriteLine("\nWelcome! Please select a function from the menu below:\n");
            Console.WriteLine("1. Compound Interest (Monthly).");
            Console.WriteLine("2. Compound Interest (Yearly).");
            Console.WriteLine("3. Decompounding (Monthly).");
            Console.WriteLine("4. Decompounding (Yearly).");
            Console.Write("\nNumber:");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Results.CompoundMonthly();
                    break;
                case 2:
                    Results.CompoundYearly();
                    break;
                case 3:
                    Results.DecompoundMonthly();
                    break;
                case 4:
                    Results.DecompoundYearly();
                    break;
                default:
                    Console.WriteLine("Please try again, input a valid option.");
                    Homepage();
                    break;
            }

        }
    }

}
