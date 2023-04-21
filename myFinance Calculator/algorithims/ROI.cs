using System;

namespace Financial_Calculator.algorithims
{
    class ROI
    {
        public static double CalculateROIChange(float previous, float current, double years)
        {
            if (previous == 0)
                return 0;

            if (current == 0)
                return -100;


            var result = (Math.Pow((current / previous), (1 / years)))-1;

            return result * 100;
        }
    }
}
