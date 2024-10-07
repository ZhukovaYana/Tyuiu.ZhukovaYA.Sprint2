using Tyuiu.ZhukovaYA.Sprint2.Task3.V17.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task3.V17; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #2 | Выполнил: Жукова Я.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Вложенные операторы if - else                                  *"); 
        Console.WriteLine("* Задание #3                                                           *"); 
        Console.WriteLine("* Вариант #17                                                          *"); 
        Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПб-24-1                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:Написать программу, которая вычисляет требуемое значение     *"); 
        Console.WriteLine("* функции Y с использованием вложенных оператор if-else, где           *");
        Console.WriteLine("* пользователь вводит значение переменной X с клавиатуры               *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную X:"); 
        int x = int.Parse(Console.ReadLine()!); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        DataService ds  = new DataService();
        double res = ds.Calculate(x);

        Console.WriteLine($"Ответ = {res}");
        Console.ReadKey();
    } 
} 
