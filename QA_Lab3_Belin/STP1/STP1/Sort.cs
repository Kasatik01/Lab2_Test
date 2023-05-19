using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STP1
{
    internal class Sort : IComparer<double> // компаратор для вещественных чисел
    {
        public int Compare(double x, double y){
            double x1 = x % 1;
            double y1 = y % 1;
            if (x1 >= 0.4)
            {
                if (y1 >= 0.4)
                {
                    if (x >= y) { return -1; }
                    else { return 1; }
                }
                else { return -1; }
            }
            else if (x1 < 0.4)
            {
                if (y1 >= 0.4)
                {
                    return 1;
                }
                else
                {
                    if (x <= y) { return -1; }
                    else { return 1; }
                }
            }
            return -1;
        }
    }
}