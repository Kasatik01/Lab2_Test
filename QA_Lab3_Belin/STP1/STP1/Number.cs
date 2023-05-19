using System;

namespace STP1
{
    class Number
    {
        protected int x, y;
        public Number()
        {
            x = 1;
            y = 1;
        }
        public Number(int X, int Y)
        {
            x = X;
            y = Y;
        }
        virtual public void Display()
        {
            Console.WriteLine(Convert.ToString(x) +
                '/' + Convert.ToString(y));
        }
        virtual public double Real()
        {
            return Math.Round((double)x / (double)y, 3);
        }

        internal object getClass()
        {
            throw new NotImplementedException();
        }
    }
}
