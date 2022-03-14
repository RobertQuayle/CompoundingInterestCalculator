using System;

namespace Program
{

    /*

    UserInput Class: Collection of methods for collecting user input for compounding functionality.

    TODO - Add try/catch

     */

    public static class UserInput
    {

        public static double GetInitialValue()
        {
            Console.WriteLine("\nPlease input your starting amount below:");
            Console.Write("£");
            double initialValue = double.Parse(Console.ReadLine());
            return initialValue;
        }

        public static double GetTargetValue()
        {
            Console.WriteLine("\nPlease input your target amount below:");
            Console.Write("£");
            double targetValue = double.Parse(Console.ReadLine());
            return targetValue;
        }

        public static double GetMonthlyCont()
        {
            Console.WriteLine("\nPlease input your monthly contributions:");
            Console.Write("£");
            double monthlyCont = double.Parse(Console.ReadLine());
            return monthlyCont;
        }

        public static double GetYearlyCont()
        {
            Console.WriteLine("\nPlease input your yearly contributions:");
            Console.Write("£");
            double yearlyCont = double.Parse(Console.ReadLine());
            return yearlyCont;
        }

        public static double GetAPR()
        {
            Console.WriteLine("\nPlease input the annual percentage rate (APR):");
            Console.Write("%");
            double apr = double.Parse(Console.ReadLine());
            return apr;
        }

        public static int GetYears()
        {
            Console.WriteLine("\nPlease input the number of years to calculate:");
            Console.Write("Years = ");
            int years = int.Parse(Console.ReadLine());
            return years;
        }

        public static int GetAge()
        {
            Console.WriteLine("\nHow old are you?:");
            Console.Write("Age:");
            int age = int.Parse(Console.ReadLine());
            return age;
        }

        public static int GetRetirementAge()
        {
            Console.WriteLine("\nWhen do you plan to retire?:");
            Console.Write("Age:");
            int retirementAge = int.Parse(Console.ReadLine());
            return retirementAge;
        }

    }

}
