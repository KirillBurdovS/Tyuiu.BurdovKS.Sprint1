using Tyuiu.BurdovKS.Sprint1.Task3.V8.Lib;

class Program
{
    static void Main(string[] IncomeAmount)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        double x, y, z;

        Console.WriteLine("Введите сумму вклада");

        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите процент");

        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество дней");

        z = Convert.ToInt32(Console.ReadLine());




        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(" Сумма равна " + ds.IncomeAmount(x, y, z));

        Console.ReadLine();







    }
}