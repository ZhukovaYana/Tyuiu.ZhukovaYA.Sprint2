using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task5.V2.Lib;

public class DataService : ISprint2Task5V2
{
    public string FindMonthSeason(int value)
    {
        string res;
        switch (value) {
            case 1: res = "����"; break;
            case 2: res = "����"; break;
            case 3: res = "�����"; break;
            case 4: res = "�����"; break;
            case 5: res = "�����"; break;
            case 6: res = "����"; break;
            case 7: res = "����"; break;
            case 8: res = "����"; break;
            case 9: res = "�����"; break;
            case 10: res = "�����"; break;
            case 11: res = "�����"; break;
            case 12: res = "����"; break;
            default: res = "����� ������ ���� �� 1 �� 12"; break;
        }
        return res;
    }
} 
