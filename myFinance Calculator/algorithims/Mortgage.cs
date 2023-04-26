using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFinance_Calculator.algorithims
{
    class Mortgage
    {

        public static double CalculateMortgageRepayments(double mortgage, double deposit,
            double interest, double timescale, bool years)
        {

            /*
             *
                      
             Mortgage = 120000
            Deposit = 20000
            interest = 6%
            Term = 30
             
             
             */


            interest /= 100;
           
            if (years) timescale *= 12;

            return (mortgage - deposit) * (Math.Pow((1 + interest / 12), timescale) * interest) / (12 * (Math.Pow((1 + interest / 12), timescale) - 1));




        }

    }
}
