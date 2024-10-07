using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task3.V17.Lib;

public class DataService : ISprint2Task3V17
{
    public double Calculate(double x)
    {
        double res;
        if (x > 1)  res = Math.Pow(x, 2) + Math.Pow(((x + 1) / (x - 1)), 8);
        else if (x == 0)  res = (2 + x - 3 * x) / (x - 7);
        else if (x > -21 && x < 2) res = Math.Pow((1 + (1 / Math.Pow(x, 2))), 4);
        else res = x + 10 * x - (1 / x);
        return Math.Round(res, 3);
    }
} 
