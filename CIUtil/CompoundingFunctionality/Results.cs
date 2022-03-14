using System;

//Namespace for Compound Functionality Library
using CIUtil;

namespace Program
{

    /*

    Results Class: Collection of methods for displaying functionality.
        - ToString("C") is to format the output to currency.

     */

    public static class Results
    {

        public static void CompoundMonthly()
        {

            Console.WriteLine("--- Compound Interest (Monthly) ---");

            double start = UserInput.GetInitialValue();

            int years = UserInput.GetYears();

            double apr = UserInput.GetAPR();

            double monthlyCont = UserInput.GetMonthlyCont();

            Console.WriteLine($"\nAfter {years} year(s)");
            Console.WriteLine($"Your initial investment of £{start}");
            Console.WriteLine($"With monthly contributions of £{monthlyCont}");
            Console.WriteLine($"At {apr}% APR");
            Console.WriteLine($"Is now worth:\n");

            Console.WriteLine($"Year 0: {start.ToString("C")}");

            Compound.Monthly(start, years, apr, monthlyCont);

            Menu.Homepage();

        }

        public static void CompoundYearly()
        {

            Console.WriteLine("--- Compound Interest (Yearly) ---");

            double start = UserInput.GetInitialValue();

            int years = UserInput.GetYears();

            double apr = UserInput.GetAPR();

            double yearlyCont = UserInput.GetYearlyCont();

            Console.WriteLine($"\nAfter {years} year(s)");
            Console.WriteLine($"Your initial investment of £{start}");
            Console.WriteLine($"With yearly contributions of £{yearlyCont}");
            Console.WriteLine($"At {apr}% APR");
            Console.WriteLine($"Is now worth:\n");

            Console.WriteLine($"Year 0: {start.ToString("C")}");

            Compound.Yearly(start, years, apr, yearlyCont);

            Menu.Homepage();

        }

        public static void DecompoundMonthly()
        {

            Console.WriteLine("--- Decompound Interest (Monthly) ---");

            double goal = UserInput.GetTargetValue();

            int age = UserInput.GetAge();

            int retirementAge = UserInput.GetRetirementAge();

            double apr = UserInput.GetAPR();

            int years = retirementAge - age;
            int months = (retirementAge - age) * 12;
            double percentage = apr / 12;

            Console.WriteLine($"\nYou are currently {age} years old,");
            Console.WriteLine($"To retire at your desired age of {retirementAge}, in {years} years,");

            double result = Decompound.Monthly(goal, age, retirementAge, apr);

            Console.WriteLine($"At {apr}% APR, you must invest {result.ToString("C")} per month:\n");

            double total = 0;
            int currentYear = 1;

            for (int i = 0; i <= months; i++)
            {

                total += result;
                total = (total / 100) * (percentage + 100);

                if (i % 12 == 0 && i >= 12)
                {
                    Console.WriteLine($"Year {currentYear}: {total.ToString("C")}");
                    currentYear++;
                }

            }

            Menu.Homepage();

        }

        public static void DecompoundYearly()
        {

            Console.WriteLine("--- Decompound Interest (Yearly) ---");

            double goal = UserInput.GetTargetValue();

            int age = UserInput.GetAge();

            int retirementAge = UserInput.GetRetirementAge();

            double apr = UserInput.GetAPR();

            int years = retirementAge - age;

            Console.WriteLine($"\nYou are currently {age} years old,");
            Console.WriteLine($"To retire at your desired age of {retirementAge}, in {years} years,");

            double result = Decompound.Yearly(goal, age, retirementAge, apr);

            Console.WriteLine($"At {apr}% APR, you must invest {result.ToString("C")} per year:\n");

            double total = 0;
            int currentYear = 1;

            for (int i = 0; i < years; i++)
            {

                total += result;
                total = (total / 100) * (apr + 100);

                Console.WriteLine($"Year {currentYear}: {total.ToString("C")}");
                currentYear++;

            }

            Menu.Homepage();

        }

    }

}
