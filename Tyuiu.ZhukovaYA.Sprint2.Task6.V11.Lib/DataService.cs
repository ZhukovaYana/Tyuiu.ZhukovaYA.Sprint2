using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZhukovaYA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    {
                        if (n == 31)
                        {
                            n = 1; m++;
                        }
                        else n++;
                        return $"{g}.{m}.{n}";
                    }
                case 2:
                    {
                        if (n == 28)
                        {
                            n = 1; m++;
                        }
                        else n++;
                        return $"{g}.{m}.{n}";
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        if (n == 30)
                        {
                            n = 1; m++;
                        }
                        else n++;
                        return $"{g}.{m}.{n}";
                    }
                case 12:
                    {
                        if (n == 31)
                        {
                            n = 1; m = 1; g++;
                        }
                        else n++;
                        return $"{g}.{m}.{n}";
                    }
                default: return $"{g}.{m}.{n}";

            }
        }
    }
}
