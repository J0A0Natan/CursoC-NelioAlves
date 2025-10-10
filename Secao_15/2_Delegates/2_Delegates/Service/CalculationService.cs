namespace _2_Delegates.Service
{
    internal class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
            /*if (x > y)
                return x;
            else
                return y;*/
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Square(double x)
        {
            return x * x;
        }
    }
}
