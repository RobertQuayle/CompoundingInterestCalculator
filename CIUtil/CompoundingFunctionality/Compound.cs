using System;

namespace CIUtil
{

    /*

    Compound Class: Collection of methods for compounding interest functionality.

    TODO - Time() Method: Returns how many years to reach your goal based off initial investment and montly increments.
    TODO - APR() Method: Returns average APR% for well known asset classes, S&P500 for example.

     */

    public static class Compound
    {

        public static void Monthly(double startAmount, int years, double annualPercent, double monthlyCont = 0)
        {
            double total = startAmount;

            int totalMonths = years * 12;

            double monthlyPercent = annualPercent / 12;

            int currentYear = 1;

            for (int i = 0; i <= totalMonths; i++)
            {

                if (monthlyCont > 0)
                {
                    total += monthlyCont;
                }

                total = (total / 100) * (monthlyPercent + 100);

                if (i % 12 == 0 && i >= 12)
                {
                    Console.WriteLine($"Year {currentYear}: {total.ToString("C")}");
                    currentYear++;
                }

            }

        }

        public static void Yearly(double startAmount, int years, double annualPercent, double yearlyCont = 0)
        {
            double total = startAmount;

            int currentYear = 1;

            for (int i = 0; i < years; i++)
            {
                if (yearlyCont > 0)
                {
                    total += yearlyCont;
                }

                total = (total / 100) * (annualPercent + 100);

                Console.WriteLine($"Year {currentYear}: {total.ToString("C")}");
                currentYear++;

            }

        }

    }

}
