using Tyuiu.ZhukovaYA.Sprint2.Task5.V2.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task5.V2; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #2 | Выполнил: Жукова Я.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Оператор switch                                                *"); 
        Console.WriteLine("* Задание #5                                                           *"); 
        Console.WriteLine("* Вариант #2                                                           *"); 
        Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПб-24-1                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: По данному месяцу, определите в какую пору года попадает    *"); 
        Console.WriteLine("* этот месяц (Зима, Лето, Весна, Осень).                               *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите номер месяца:"); 
        int x = int.Parse(Console.ReadLine()!); 

        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        DataService ds = new DataService();
        string res = ds.FindMonthSeason(x);

        Console.WriteLine($"Ответ = {res}"); 
        Console.ReadKey();
    } 
} 
