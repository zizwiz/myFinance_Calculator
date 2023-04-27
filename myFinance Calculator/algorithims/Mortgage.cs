using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFinance_Calculator.algorithims
{
    class Mortgage
    {

        public static (double, double, double)CalculateMortgageRepayments(double mortgage, double deposit,
            double interest, double timescale, bool years)
        {

            /*
             *
                      
             Mortgage = 120000
            Deposit = 20000
            interest = 6%
            Term = 30
             
             result = 599.55
             */


            interest /= 100;
            if (years) timescale *= 12;

            double Repayment =  (mortgage - deposit) * (Math.Pow((1 + interest / 12), timescale) * interest) / (12 * (Math.Pow((1 + interest / 12), timescale) - 1));
            double TotalRepaid = Repayment * timescale;
            double TotalInterest = TotalRepaid - mortgage;
            
            return (Repayment, TotalRepaid, TotalInterest);
        }

    }
}
