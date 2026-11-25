using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZaitsSD.Sprint1.Task7.V14.Lib
{
    public class DataService : ISprint1Task7V14
    {
        public double Calculate(double x, double y)
        {
            double expression_1 = Math.Pow(2, -x) + (5 * x * x) / (3 * x * x * x);
            double expression_2 = Math.Cos(x * x);
            double res = expression_1 - expression_2 + Math.Sin(2 * x * y);
            return Math.Round(res,3);
        }
    }
}
