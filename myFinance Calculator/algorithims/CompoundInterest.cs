using System;

namespace Financial_Calculator.algorithims
{
    class CompoundInterest
    {
        /// <summary>
        /// CompoundInterest.
        /// Invest = 10000
        /// interest = 15%
        /// Term = 20years
        /// Int calculated once a year
        ///
        /// value = 163 665.37
        /// </summary>
        public static (double, bool, double) CompoundInterestCalc(double InitialInvestmentValue,
            double interestRate,
            int timesPerYear,
            double years)
        {
            bool flag = false;
            // (1 + r/n)
            // r = interest rate per annum,
            // n = number of compounding periods per annum
            double body = 1 + (interestRate / timesPerYear);

            // nt
            // n = number of compounding periods per annum
            // t = timespan
            double exponent = timesPerYear * years;

            // P(1 + r/n)^nt
            double FinalValue = InitialInvestmentValue * Math.Pow(body, exponent);
            double TotalInterest = FinalValue - InitialInvestmentValue;


            //You pay tax on interest over £1000.00
            if (FinalValue - InitialInvestmentValue > 1000) flag = true; //Paying tax



            return (FinalValue, flag, TotalInterest);






        }
    }
}
