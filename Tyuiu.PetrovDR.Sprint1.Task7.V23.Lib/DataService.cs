using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PetrovDR.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            double slog1 = x - Math.Pow(10, Math.Sin(x));
            double slog2 = (20 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3));
            double slog3 = Math.Cos(Math.Pow(x, 2) - y);

            double summa = slog1 + slog2 + slog3;

            return Math.Round(summa, 3);
        }
    }
}
