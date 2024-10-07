using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task1.V6.Lib;

public class DataService : ISprint2Task1V6
{
    public bool[] GetLogicOperations(int a, int b, int c, int d)
    {
        bool[] result = new bool[6];
        result[0] = (a < b) | (c <= d);
        result[1] = (a == b) & (c != d);
        result[2] = (a > b) || (c >= d);
        result[3] = (a >= b) && (c <= d);
        result[4] = !(b != d + 36);
        result[5] = (a == b + 746) ^ (c > d);
        return result;
    }
} 
