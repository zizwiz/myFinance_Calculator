using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFinance_Calculator.algorithims
{
    class GrossToAER
    {
        public static double CalculateGrossToAER( float GrossIntRate, int TimePerYear)
        {


            /*
             *
             *Start by finding out the gross interest rate
               Divide the gross interest rate by how many times interest will be paid in a year
               Add one
               Raise to the power of how many times interest will be paid in a year
               Subtract one
             *
             * Note to get into percentage div by 100 and multiply by 100 as below.
             
             
             e.g 3.65% gross paid 4 times a year = 3.7% AER 
             
             */

            
            return (Math.Pow((1+((GrossIntRate/TimePerYear)/100)),TimePerYear)-1)*100;
        }


    }
}
