using STP1;
using System;

namespace STP1
{
    internal class Izdelie
    {
        private Element e1 = new Element();
        private Element e2 = new Element();
        private Element e3 = new Element();
        private string name = "";
        public void Init(int v1, int v2, int v3, double t1, double t2, double t3)
        {
            e1.Init(v1, t1);
            e2.Init(v2, t2);
            e3.Init(v3, t3);
        }
        public void Read()
        {
            e1.Read();
            e2.Read();
            e3.Read();
        }
        public void Name()
        {
            name = Console.ReadLine();
        }
        public double Cost()
        {
            double cost = e1.Cost() + e2.Cost() + e3.Cost();
            return cost;
        }
        public void Display()
        {
            Console.WriteLine(name);
            Console.WriteLine("Элемент-1:");
            e1.Display();
            Console.WriteLine("Элемент-2:");
            e2.Display();
            Console.WriteLine("Элемент-3:");
            e3.Display();
        }
        public Element Expensive()
        {
            double a = e1.Cost();
            double b = e2.Cost();
            double c = e3.Cost();
            if (a >= b && a >= c) { return e1; }
            if (b > a && b >= c) { return e2; }
            if (c > a && c > b) { return e3; }
            return null;
        }

    }
}
