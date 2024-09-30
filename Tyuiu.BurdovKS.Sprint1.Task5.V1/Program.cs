
using Tyuiu.BurdovKS.Sprint1.Task5.V1.Lib;


class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();



        Console.Title = "Спринт #1 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
        Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x1,x2,y1,y2;


        Console.WriteLine("Введите координату x1");

        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату x2");

        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату y1");

        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координату y2");

        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");



        int res = Convert.ToInt32(ds.DistanceBetweenDots(x1,y1,x2,y2));



        Console.WriteLine(res);

        Console.ReadLine();








    }
}