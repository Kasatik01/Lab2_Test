using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace QA_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Izdelie chair = new Izdelie();
            Console.Write("Изделие: ");
            chair.Name();
            chair.Init(200, 300, 500, (double)0.7, (double)0.5, (double)0.3);
            chair.Display();
            chair.Read();
            chair.Display();
            Console.WriteLine("Общая стоимость: " + chair.Cost().ToString());
            Element expensive = chair.Expensive();
            Console.WriteLine("Дорогой элемент: ");
            expensive.Display();
            Console.WriteLine("Наибольшая стоимость: " + expensive.Cost().ToString());
        }
    }
}
