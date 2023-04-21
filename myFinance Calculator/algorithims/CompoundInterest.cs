using System;

namespace Financial_Calculator.algorithims
{
    class CompoundInterest
    {
        /// <summary>
        /// CompoundInterest.
        /// </summary>
        public static (double, bool) CompoundInterestCalc(double principal,
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
            double total = principal * Math.Pow(body, exponent);


            //You pay tax on interest over £1000.00
            if (total - principal > 1000) flag = true; //Paying tax



            return (total, flag);






        }
    }
}
