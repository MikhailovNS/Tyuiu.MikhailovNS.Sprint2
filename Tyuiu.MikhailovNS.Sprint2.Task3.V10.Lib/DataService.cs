using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MikhailovNS.Sprint2.Task3.V10.Lib
{
    public class DataService : ISprint2Task3V10
    {
        public double Calculate(double x)
        {
            double res = 10101;
            if (x > 0)
            {
                res = Math.Round(Math.Pow((x - ((x + 15) / (x - 4))), x), 3);
            }
            else if (x == 0)
            {
                res = Math.Round(((Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 2)), 3);
            }
            else if ((x < 0)&&(-14<x))
            {
                res = Math.Round(Math.Pow(5+(1/(Math.Pow(x,2))), x), 3); // попробуй если не сработает () добавить в степень
            }
            else if (x < -14)
            {
                res = Math.Round((x+10*x-(1/x)),3);
            }
            else 
            {
                Console.WriteLine("Мы не знаем что это это такое, если бы мы знали что это такое, мы не знаем что это такое");
            }

            return res;
        }
    }
}
