using System;

namespace QA_Lab3
{
    internal class Element
    {
        private int ves;
        private double tsena;
        public void Init(int v, double t)
        {
            ves = v;
            tsena = t;
        }
        public void Read()
        {
            string s = "";
            s = Console.ReadLine();
            string[] s1 = s.Split(new char[] { ' ', '\t' },
            StringSplitOptions.RemoveEmptyEntries);
            ves = Convert.ToInt32(s1[0]);
            tsena = Convert.ToDouble(s1[1]);
        }
        public double Cost()
        {
            return Math.Round(tsena * ves, 2, MidpointRounding.AwayFromZero);
        }
        public void Display()
        {
            Console.WriteLine("Вес элемента:" + ves.ToString()); ;
            Console.WriteLine("Цена грамма элемента:" + tsena.ToString());
        }
    }

}
