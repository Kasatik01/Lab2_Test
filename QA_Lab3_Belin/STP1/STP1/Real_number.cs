using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace STP1
{
    class Real_number : Number
    {
        private int znak;
        public Real_number() :base()
        {
            znak = 1;
        }
        public Real_number(int X, int Y, int Z) :base(X,Y)
        {
            if (Z == 0 || Z == 1 || Z == -1)
            {
                znak = Z;
            }
        }

        public override void Display()
        {
            Console.WriteLine(Convert.ToString(znak*x) +
                 '/' + Convert.ToString(y));
        }
        public override double Real()
        {
            return Math.Round(znak * (double)x / (double)y,3);
        }
    }
}
