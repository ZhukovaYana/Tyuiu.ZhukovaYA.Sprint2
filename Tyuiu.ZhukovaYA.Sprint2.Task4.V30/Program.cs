using Tyuiu.ZhukovaYA.Sprint2.Task4.V30.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint2.Task4.V30; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #2 | Выполнил: Жукова Я.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Тернарный оператор                                             *"); 
        Console.WriteLine("* Задание #4                                                           *"); 
        Console.WriteLine("* Вариант #30                                                          *"); 
        Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПб-24-1                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Написать программу, которая вычисляет требуемое значение с  *"); 
        Console.WriteLine("* использованием тернарного оператора, где пользователь вводит         *");
        Console.WriteLine("* значение переменных x,y с клавиатуры                                 *");
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

        DataService ds = new DataService();
        double res = ds.Calculate(x, y);

        Console.WriteLine($"Ответ = {res}");
        Console.ReadKey();
    } 
} 
