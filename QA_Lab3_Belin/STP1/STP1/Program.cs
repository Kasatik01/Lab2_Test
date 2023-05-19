using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace STP1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> a = new List<double>();  // коллекция из вещественных чисел
            StreamReader f = new StreamReader("E:\\test2.txt");
            while (!f.EndOfStream)
            {
                a.Add(Convert.ToDouble(f.ReadLine()));
            }
            f.Close();
            string ss;
            Console.WriteLine("Исходные числа: ");
            foreach (double k in a)
            {
                ss = Convert.ToString(k);
                Console.Write(ss + " ");
            }
            Sort sort = new Sort();
            a.Sort(sort);
            Console.WriteLine();
            Console.WriteLine("Отсортированные числа: ");
            foreach (double k in a)
            {
                ss = Convert.ToString(k);
                Console.Write(ss + "  ");
            }
            Console.ReadKey();
        }
    }
}
