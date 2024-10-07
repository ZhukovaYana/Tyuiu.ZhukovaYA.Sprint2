using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task2.V13.Lib;

public class DataService : ISprint2Task2V13
{
    public bool CheckDotInShadedArea(int x, int y)
    {
        if (((y >= 4 && y <= 8)&& x == 4) || (y == 6 && (x >= 3 && x <= 7)) || 
            ((x >= 9 && x <= 12)&&(y == 4 || y == 3)) || 
            ((x >= 8 && x <= 12)&&(y >= 5 && y <= 9)) || 
            (x == 13 && (y >= 6 && y <= 8)) || 
            ((x >=6 && x <=12)&&y==10) || 
            ((x >= 3 && x <= 12) && y == 11) ||
            ((x >= 8 && x <= 12) && y == 13))
        {
            return true;
        }
        return false;
    }
} 
