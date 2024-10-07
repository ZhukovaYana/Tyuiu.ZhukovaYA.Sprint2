using Tyuiu.ZhukovaYA.Sprint2.Task1.V6.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task1.V6; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #2 | Выполнил: Жукова Я.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Логические операции                                            *"); 
        Console.WriteLine("* Задание #1                                                           *"); 
        Console.WriteLine("* Вариант #6                                                           *"); 
        Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПб-24-1                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:Написать программу из операций сравнений и логических        *"); 
        Console.WriteLine("* операций, а также арифметических выражений, которая вернет           *");
        Console.WriteLine("* логическую последовательность(массив)                                *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную A:"); 
        int a = int.Parse(Console.ReadLine()!); 
        Console.WriteLine("Введите переменную B:"); 
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите переменную C:");
        int c = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите переменную D:");
        int d = int.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");

        DataService dataService = new DataService();
        bool[] res = dataService.GetLogicOperations(a, b, c ,d);

        Console.Write("Ответ = [");
        for (int i = 0; i < res.Length; i++)
        {
            Console.Write($"{res[i]},");
        }
        Console.WriteLine("]");
        Console.ReadKey();
    } 
} 
