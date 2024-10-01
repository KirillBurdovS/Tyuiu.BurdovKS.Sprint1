

using Tyuiu.BurdovKS.Sprint1.Task7.V30.Lib;

class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();



        Console.Title = "Спринт #1 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
        Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*               sinx^5 + x^3       y^5                                    *");
        Console.WriteLine("* z = x + e^x + ------------- + ----------                                *");
        Console.WriteLine("*                     3^x          5^y                                    *");
        Console.WriteLine("***************************************************************************");




        double x, y;


        Console.WriteLine("Введите переменную x");

        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите переменную y");

        y = Convert.ToDouble(Console.ReadLine());





        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

       




        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadLine();
    }
}