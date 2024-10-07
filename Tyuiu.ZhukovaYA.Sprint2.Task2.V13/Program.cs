using Tyuiu.ZhukovaYA.Sprint2.Task2.V13.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task2.V13; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #2 | Выполнил: Жукова Я.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                   *"); 
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #13                                                          *"); 
        Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПб-24-1                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Написать программу на, которая запрашивает целые значения с *"); 
        Console.WriteLine("* клавиатуры и вычисляет находится ли точка с координатами X,Y в       *");
        Console.WriteLine("* заштрихованной области.                                              *");
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
 
        DataService ds  = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine($"Ответ = {res}");
        Console.ReadKey();
    } 
} 
