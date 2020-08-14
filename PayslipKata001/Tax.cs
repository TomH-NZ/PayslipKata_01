using System;

namespace PayslipKata001
{
    public class Tax
    {
        public static int Calculator(double previousTaxAmount, double grossIncome, double previousTaxBracketLimit,
            double taxPercentage, double payPeriodsPerYear)
        {
            var taxAmount = Math.Round((previousTaxAmount + (grossIncome - previousTaxBracketLimit) * taxPercentage / 100) / payPeriodsPerYear, MidpointRounding.AwayFromZero);
            return Convert.ToInt32(taxAmount);
        }
    }
}