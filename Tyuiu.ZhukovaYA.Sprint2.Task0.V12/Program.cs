using Tyuiu.ZhukovaYA.Sprint2.Task0.V12.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task0.V12; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #2 | Выполнил: Жукова Я.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Операции сравнения                                             *"); 
        Console.WriteLine("* Задание #0                                                           *"); 
        Console.WriteLine("* Вариант #12                                                          *"); 
        Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПб-24-1                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Написать программу из операций сравнений (==, !=, <, >, <=, *"); 
        Console.WriteLine("* >=, последовательность операций не должна нарушаться) и              *");
        Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):     *");
        Console.WriteLine("* (True, False, True, False, True, False), при x = 1095, y = 475       *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную X:"); 
        int x = int.Parse(Console.ReadLine()!); 
        Console.WriteLine("Введите переменную Y:"); 
        int y = int.Parse(Console.ReadLine()!); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 

        DataService dataService = new DataService();
        bool[] res = dataService.GetCompareOperations(x, y);

        Console.Write("Ответ = [");
        for (int i = 0; i < res.Length; i++) 
        { 
            Console.Write($"{res[i]},");
        }
        Console.WriteLine("]");
        Console.ReadKey();

    } 
} 
