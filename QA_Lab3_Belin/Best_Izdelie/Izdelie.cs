namespace QA_Lab3
{
    /// \author Belin N.
    /// <summary>
    /// Основной класс Izdelie содержит информацию об изделии и 
    /// использует вспомогательный класс Element.
    /// </summary>
    /// \image html chair.jpg
    /// \callgraph
    public class Izdelie
    {
        private Element e1 = new Element(); // 3 элемента
        private Element e2 = new Element();
        private Element e3 = new Element();
        private string name = ""; // название изделия
        /// <summary>
        /// Метод инициализации изделия с тремя элементами.
        /// </summary>
        /// <param name="v1">Вес первого элемента (в граммах)</param>
        /// <param name="v2">Вес второго элемента (в граммах)</param>
        /// <param name="v3">Вес третьего элемента (в граммах)</param>
        /// <param name="t1">Цена за грамм первого элемента</param>
        /// <param name="t2">Цена за грамм второго элемента</param>
        /// <param name="t3">Цена за грамм третьего элемента</param>
        /// <param name="s">Название изделия</param>
        public void Init(int v1, int v2, int v3, double t1, double t2, double t3, string s)
        {
            e1.Init(v1, t1); // первый элемент
            e2.Init(v2, t2); // второй элемент
            e3.Init(v3, t3); // третий элемент
            name = s; // название
        }

        /// <summary>
        /// Метод чтения с консоли данных об элементах изделия.
        /// </summary>
        public void Read() 
        {
            Console.WriteLine("Запись элемента-1:");
            e1.Read();
            Console.WriteLine("Запись элемента-2:");
            e2.Read();
            Console.WriteLine("Запись элемента-3:");
            e3.Read();
        }

        /// <summary>
        /// Метод чтения с консоли названия изделия.
        /// </summary>
        public void Name() //ввод названия с консоли
        {
            Console.Write("Изделие: ");
            name = Console.ReadLine();
        }

        /// <summary>
        /// Метод отображения данных об изделии в консоли.
        /// </summary>
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

        /// <summary>
        /// Метод посчёта стоимости изделия.
        /// </summary>
        /// <returns>
        /// Метод использует поля класса Element и его метод Element_Cost(),
        /// возвращая стоимость всего изделия по формуле: 
        /// $$Izdelie_Cost = Element_Cost{1} + Element_Cost{2} + Element_Cost{3}$$
        ///</returns>
        public double Izdelie_Cost()
        {
            double cost = e1.Element_Cost() + e2.Element_Cost() + e3.Element_Cost();
            return cost;
        }

        /// <summary>
        /// Метод нахождения самого дорогого элемента в изделии.
        /// </summary>
        /// <returns>
        /// Метод возвращает поле от вспомогательного класса
        /// с наибольшей стоимостью.</returns>
        public Element Expensive() // сравнение стоимости 3-х элементов
        {
            double a = e1.Element_Cost();
            double b = e2.Element_Cost();
            double c = e3.Element_Cost();
            if (a >= b && a >= c) { return e1; } // если 1-й дороже
            if (b > a && b >= c) { return e2; } // если 2 - й дороже
            if (c > a && c > b) { return e3; } //если 3 - й дороже
            return null;
        }

    }
}
