using STP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STP1
{
    internal class Precious_element : Element
    {
        private double precious_cost;
        public void Init(int v, double t, double c)  // метод инициализации
        {
            base.Init(v, t);
            precious_cost = c;
        }
        public double Cost()
        {
            return Math.Round(tsena * ves + precious_cost*ves/100, 2, MidpointRounding.AwayFromZero);
        }
        public void Display()
        {
            Console.WriteLine("Вес элемента:" + ves.ToString()); ;
            Console.WriteLine("Цена грамма элемента:" + tsena.ToString());
            Console.WriteLine("Стоимость драг.примесей в 100г: " + precious_cost.ToString());
        }
    }
}
