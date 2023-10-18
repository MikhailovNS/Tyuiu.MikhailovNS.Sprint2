﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint2.Task1.V3.Lib;

namespace Tyuiu.MikhailovNS.Sprint2.Task1.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 185;
            int b = 316;
            int c = 136;
            int d = 136;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #3                                                               *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в          *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^, последовательность *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую              *");
            Console.WriteLine("* последовательность(массив): (True, False, False, False, False, False),   *");
            Console.WriteLine("* при a = 185, b = 316, c = 134, d = 134.                                  *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            
            for (int i = 0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
