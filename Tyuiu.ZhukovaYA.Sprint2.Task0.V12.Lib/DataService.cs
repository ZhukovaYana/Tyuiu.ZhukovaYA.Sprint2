using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task0.V12.Lib;

public class DataService : ISprint2Task0V12
{
    public bool[] GetCompareOperations(int x, int y)
    {
        bool[] result = new bool[6];
        result[0] = x == y + 620;
        result[1] = x - 620 != y;
        result[2] = x < y * 10;
        result[3] = x / 10 > y;
        result[4] = x <= y + 1000;
        result[5] = x - 1000 >= y;
        return result;
    }
} 
