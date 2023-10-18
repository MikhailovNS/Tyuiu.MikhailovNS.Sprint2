using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MikhailovNS.Sprint2.Task4.V2.Lib
{
    public class DataService : ISprint2Task4V2
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Round((x > y +3) ? (x + ((x + 1) / y)): ((y + 5) / (y + 2)), 3);
            return z;
        }
    }
}
