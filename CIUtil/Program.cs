using System;

//Used for changing currency formating from $ to £
using System.Globalization;
using System.Threading;

//Namespace for Compound Functionality Library
using CIUtil;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            //NOTE: Changes currency formatting of ToString() from $ to £
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            Console.WriteLine(Decompound.Monthly(100000, 23, 33, 12, 500));

            Console.WriteLine("\nCompound Interest Calculator v1.0.0");

            decimal initialValue = Menu.GetInitialValue();

            decimal monthlyCont = Menu.GetMonthlyCont();

            decimal apr = Menu.GetAPR();

            int years = Menu.GetYears();

            string result = Compound.Monthly(initialValue,monthlyCont,apr,years);

            Console.WriteLine($"\nAfter {years} year(s)");
            Console.WriteLine($"Your initial investment of £{initialValue}");
            Console.WriteLine($"With monthly contributions of £{monthlyCont}");
            Console.WriteLine($"At {apr}% APR");
            Console.WriteLine($"Is now worth {result}");
        }

    }

    /*
     Menu Class: Generic-reuseable get methods for user inputs,
     then parsing them to the correct type.
     TODO: Add Try/Catch validation.
     */

    public static class Menu
    {

        public static decimal GetInitialValue()
        {
            Console.WriteLine("\nPlease input your starting amount below:");
            Console.Write("£");
            decimal initialValue = decimal.Parse(Console.ReadLine());
            return initialValue;
        }

        public static decimal GetMonthlyCont()
        {
            Console.WriteLine("\nPlease input your monthly contributions:");
            Console.Write("£");
            decimal monthlyCont = decimal.Parse(Console.ReadLine());
            return monthlyCont;
        }

        public static decimal GetAPR()
        {
            Console.WriteLine("\nPlease input the annual percentage rate (APR):");
            Console.Write("%");
            decimal apr = decimal.Parse(Console.ReadLine());
            return apr;
        }

        public static int GetYears()
        {
            Console.WriteLine("\nPlease input the number of years to calculate:");
            Console.Write("Years = ");
            int years = int.Parse(Console.ReadLine());
            return years;
        }

    }

}
