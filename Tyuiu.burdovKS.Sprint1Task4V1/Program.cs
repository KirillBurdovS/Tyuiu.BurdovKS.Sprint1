

using Tyuiu.burdovKS.Sprint1Task4V1.Lib;



class Program
{
    static void Main(string[] args)
    {
        
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ФОРМУЛА:                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*     1                                                                   *");
        Console.WriteLine("* ---------                                                               *");
        Console.WriteLine("* (x + 2)^2                                                               *");
        Console.WriteLine("***************************************************************************");


        double x;

        Console.WriteLine("Введите значение x");

        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(" Выражение равно " + ds.Calculate(x));

        Console.ReadLine();



    }




}
