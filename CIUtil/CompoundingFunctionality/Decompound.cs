using System;

namespace CIUtil
{

    /*

    Decompound Class: Collection of methods for decompounding interest functionality from a given target.
        - Takes desired target/goal for retirement
        - Takes your current age, desired retirement age, then calculates the years between them
        - Tells you how much you need to invest yearly/monthly to hit your target for your spesificed retirement age.

     */

    public static class Decompound
    {

        public static double Monthly(double goalAmount, int currentAge, int retirementAge, double annualPercentage)
        {
            int compoundTimes = (retirementAge - currentAge) * 12;

            double percentage = annualPercentage / 100;

            double regMonthlyCont = (Math.Pow(1 + percentage / 12, compoundTimes) - 1) / (percentage / 12);

            double result = Math.Round((goalAmount / regMonthlyCont), 2);

            return result;

        }

        public static double Yearly(double goalAmount, int currentAge, int retirementAge, double annualPercentage)
        {
            int compoundTimes = (retirementAge - currentAge);

            double percentage = annualPercentage / 100;

            double regYearlyCont = (Math.Pow(1 + percentage, compoundTimes) - 1) / percentage;

            double result = Math.Round((goalAmount / regYearlyCont), 2);

            return result;

        }

    }

}
