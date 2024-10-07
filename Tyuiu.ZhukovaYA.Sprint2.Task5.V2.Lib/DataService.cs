using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZhukovaYA.Sprint2.Task5.V2.Lib;

public class DataService : ISprint2Task5V2
{
    public string FindMonthSeason(int value)
    {
        string res;
        switch (value)
        {
            case < 1: res = "Месяц должен быть от 1 до 12"; break;
            case 12:
            case < 3: res = "зима"; break;
            case < 6: res = "весна"; break;
            case < 9: res = "лето"; break;
            case < 12: res = "осень"; break;
            default: res = "Месяц должен быть от 1 до 12"; break;
        }
        return res;
    }
}
