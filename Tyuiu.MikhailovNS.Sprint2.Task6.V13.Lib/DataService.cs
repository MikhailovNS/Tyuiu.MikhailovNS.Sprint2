using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MikhailovNS.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public double FindDateOfNextDay(int g, int m, int n)
        {
            switch(m)
            {
                case 1: 
                case 3: 
                case 5: 
                case 7: 
                case 8: 
                case 10:
                    switch(n)
                    {
                        case 31: return 1;
                        default: return (n+1);
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    switch(n)
                    {
                        case 30: return 1;
                        default: return (n + 1);
                    }
                case 12:
                    switch(n)
                    {
                        case 31:
                            return 1;  
                        default: return (1 + n);
                    }
                case 2:
                    switch (n)
                    {
                        case 29: return 1;
                        default: return (1 + n);
                    }
            }
            return m;
        }
    }
}
