using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint2.Task4.V2.Lib;

namespace Tyuiu.MikhailovNS.Sprint2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #2                                                               *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с               *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение    *");
            Console.WriteLine("* переменных x,y с клавиатуры, если:                                       *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                      x+1           y+5                                   *");
            Console.WriteLine("* x > y+3, то z = x + -----, иначе (-----)                                 *");
            Console.WriteLine("*                       y            y+2                                   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой.              *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            double y = Convert.ToInt32(Console.ReadLine());

            double z = ds.Calculate(x, y);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Результат: z = " + z);
            Console.ReadKey();
        }
    }
}
