using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint2.Task6.V13.Lib;

namespace Tyuiu.MikhailovNS.Sprint2.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет         *");
            Console.WriteLine("* требуемое значение и возвращает результат.                               *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами: *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m   *");
            Console.WriteLine("* определить дату следующего дня. Заданный год является високосным.        *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            var res = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            if (((n < 1) || (n > 31)) || ((m == 2)&&(n>29)) || ((m==4)|| (m == 6) || (m == 9) || (m == 11))&&(n>30))
            {
                Console.WriteLine("Такого количества дней в месяце не существует;");
            }
            else if ((1>m) || (m > 12))
            {
                Console.WriteLine("Месяца с таким номером не существует");
            }
            else
            {
                if ((n == 31) && (m == 12))
                {
                    g++;
                    m = 1;
                }
                else if (res == 1)
                {
                    m++;
                }
                else if ((n == 29) && (m == 2))
                {
                    m++;
                }
                else if ((n==31)&&((m == 1)|| (m == 3) || (m == 5) || (m == 7) || (m == 8) || (m == 10)))
                {
                    m++;
                }
                else if ((n == 30) && ((m == 4) || (m == 6) || (m == 9) || (m == 11)))
                {
                    m++;
                }
                Console.WriteLine("Следующий день : " + res + "." + m + "." + g) ;
            }
            Console.ReadKey();
        }
    }
}
