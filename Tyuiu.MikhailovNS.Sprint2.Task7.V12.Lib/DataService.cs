using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MikhailovNS.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y>=(2-x))&&(y<=Math.Pow(x,2)&&(y>=0)&&(x<=0))||(Math.Pow(x,2)>=y)&&(y<=(2-x))&&(x>=0)&&(y>=0))
            {
                res = true;
            }    
            else
            {
                res = false;
            }
            return res;
        }
    }
}
