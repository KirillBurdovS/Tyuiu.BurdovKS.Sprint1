﻿using Tyuiu.BurdovKS.Sprint1.Task0.V4.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;



class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();


        Console.Title = "Спринт #1 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение 4/2*5/(3+2)*(5-2)       *");
        Console.WriteLine("* и печатает результат на экране.                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* 4/2*5/(3+2)*(5-2)                                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine(ds.Calculate());

        Console.ReadLine();



    }
}