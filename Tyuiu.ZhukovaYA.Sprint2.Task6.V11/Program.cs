using Tyuiu.ZhukovaYA.Sprint2.Task6.V11.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task6.V11; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #2 | Выполнил: Жукова Я.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #11                                                          *"); 
        Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПб-24-1                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Дата некоторого дня характеризуется тремя натуральными      *"); 
        Console.WriteLine("* числами: g (год), m (порядковый номер месяца) и n (число).           *");
        Console.WriteLine("* По заданным g, n и m определить дату следующего дня.                 *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите год:"); 
        int g = int.Parse(Console.ReadLine()!); 
        Console.WriteLine("Введите месяц:"); 
        int m = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите дату:");
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        DataService ds = new DataService();
        string res = ds.FindDateOfNextDay(g,m,n);

        Console.WriteLine($"Ответ = {res}");
        Console.ReadKey();
    } 
} 
