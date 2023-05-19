using STP1;
using System;

namespace STP2
{
    internal class Izdelie
    {
        private Element e1 = new Element();
        private Precious_element e2 = new Precious_element();
        private string name = "";
        public void Init(int v1, double t1, int v2, double t2, double c)
        {
            e1.Init(v1,t1);
            e2.Init(v2,t2,c);
        }

        public void Name()
        {
            name = Console.ReadLine();
        }
        public double Cost()
        {
            return e1.Cost() + e2.Cost();
        }
        public void Display()
        {
            Console.WriteLine(name);
            Console.WriteLine("Элемент-1: ");
            e1.Display();
            Console.WriteLine("Элемент-2: ");
            e2.Display();
        }
        public Element Expensive()
        {
            Element d;
            d = e1;
            double a=e2.Cost();
            if (a > d.Cost()) { d = e2; }
            return d;
        }
    }
}
