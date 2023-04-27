using System;

namespace Financial_Calculator.algorithims
{
    class ROI
    {
        public static (double, double) CalculateROIChange(float previous, float current, double years)
        {
            /*
             * Invest 12.50
             * for 1 year
             * value now 15.20
             *
             * ROI = 21.6%
             */

            double value = 0;
            
            if (current == 0)
            {
                value = -100;
            }
            else
            {
                value = (Math.Pow((current / previous), (1 / years)))-1;
            }

            double profit = current - previous;
            

            return (value * 100, profit);
        }
    }
}
