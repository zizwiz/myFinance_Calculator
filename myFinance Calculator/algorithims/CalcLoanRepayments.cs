using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFinance_Calculator.algorithims
{
    class CalcLoanRepayments
    {

        public static double CalculateMonthlyRepayments(double LoanAmount, double InterestRate, double RepaymentTimeSpan)
        {
            /*
             *
             *double a, b, x;
               double monthlyPayment;
               a = (1 + interestRatePerYear / 1200);
               b = financingPeriod;
               x = Math.Pow(a, b);
               x = 1 / x;
               x = 1 - x;
               monthlyPayment = (presentValue ) * (interestRatePerYear / 1200) / x;
             *
             *
             *e.g. £25000 at 10% interest over 60 months = £531.18 monthly
             *
             * 
             *
             */





            return LoanAmount * (InterestRate / 1200) / (1 - (1 / Math.Pow((1 + InterestRate / 1200), RepaymentTimeSpan)));



            
        }



    }
}
