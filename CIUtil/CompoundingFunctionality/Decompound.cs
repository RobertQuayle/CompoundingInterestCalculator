using System;

namespace CIUtil
{
    public static class Decompound
    {

        public static string Monthly(double goalAmount, int currentAge, int retirementAge, double annualPercentage, double monthlyCont = 0)
        {
            int compoundTimes = (retirementAge - currentAge) * 12;

            double percentage = annualPercentage / 100;

            double regMonthlyCont = (Math.Pow(1 + percentage / 12, compoundTimes) - 1) / (percentage / 12);

            double result = Math.Round((goalAmount / regMonthlyCont), 2);

            return result.ToString("C");

        }

    }

}
