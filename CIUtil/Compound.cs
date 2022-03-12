namespace CIUtil
{

    /*

    Compound Class: Collection of methods for compounding interest functionality.

    COMPLETED - Monthly() Method: Takes 4 parameters. Contributions added first, compounded monthly.
    TODO - Yearly() Method: Takes 4 parameters. Contributions added first, compounded yearly.
    TODO - Reverse() Method: Takes ? parameters. Starts at goal, back-tracks informing user on actions to hit target.
    TODO - APR() Method: Returns average APR% for well known asset classes, S&P500 for example.

     */

    public static class Compound
    {

        public static string Monthly(decimal startAmount, decimal monthlyCont, decimal annualPercent, int years)
        {
            decimal total = startAmount;

            int totalMonths = years * 12;

            decimal monthlyPercent = annualPercent / 12;

            for (int i = 0; i < totalMonths; i++)
            {
                total += monthlyCont;
                total = (total / 100) * (monthlyPercent + 100); 
            }

            decimal result = decimal.Round(total, 2);

            // "C" formats output to currency.
            return result.ToString("C");

        }

    }

}
