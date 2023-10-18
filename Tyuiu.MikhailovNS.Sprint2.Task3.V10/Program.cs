using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint2.Task3.V10.Lib;

namespace Tyuiu.MikhailovNS.Sprint2.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x;

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с     *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит       *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до     *");
            Console.WriteLine("* трех знаков после запятой;                                               *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*       | x-((x+15)/(x-4))^x, если x>0;                                    *");
            Console.WriteLine("*       | (x^2+cosx^2-3)/(x^2-sinx^2+2), если x = 0;                       *");
            Console.WriteLine("*  y = <  (5+(1/(x^2)))^x, если -14<x<0;                                   *");
            Console.WriteLine("*       | x+10x-(1/x), если x<-14                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите переменную х:");
            x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Резултат: y = " + res);

            Console.ReadKey();
        }
    }
}
