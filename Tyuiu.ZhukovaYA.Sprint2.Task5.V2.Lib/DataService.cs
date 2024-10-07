using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task5.V2.Lib;

public class DataService : ISprint2Task5V2
{
    public string FindMonthSeason(int value)
    {
        string res;
        switch (value) {
            case < 1: res = "����� ������ ���� �� 1 �� 12"; break;
            case 12:
            case < 3: res = "����"; break;
            case < 6: res = "�����"; break;
            case < 9: res = "����"; break;
            case < 12: res = "�����"; break;
            default: res = "����� ������ ���� �� 1 �� 12"; break;
        }
        return res;
    }
} 
