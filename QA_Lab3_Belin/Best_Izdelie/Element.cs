namespace QA_Lab3
{
    /// <summary>
    /// Вспомогательный класс Element содержит информацию об элементе изделия.
    /// </summary>
    public class Element
    {
        private int ves; // вес в граммах
        private double tsena; // цена за грамм
        private double cost; // стоимость элемента

        /// <summary>
        /// Метод инициализации данных элемента
        /// </summary>
        /// <param name="v">Вес элемента в граммах</param>
        /// <param name="t">Цена за грамм элемента</param>
        public void Init(int v, double t)
        {
            ves = v;
            tsena = t;
        }

        /// <summary>
        /// Метод чтения данных элемента с консоли
        /// </summary>
        public void Read()
        {
            string s = "";
            Console.Write("Введите вес и цену: "); ;
            s = Console.ReadLine();
            string[] s1 = s.Split(new char[] { ' ', '\t' },
            StringSplitOptions.RemoveEmptyEntries);
            ves = Convert.ToInt32(s1[0]);
            tsena = Convert.ToDouble(s1[1]);
        }

        /// <summary>
        /// Метод вычисления стоимости элемента
        /// </summary>
        /// <returns>
        /// Метод использует поля класса Element,
        /// возвращая стоимость элемента по формуле: 
        /// высчитывается по формуле:
        /// $$Element_Cost = ves * tsena$$
        /// </returns>
        public double Element_Cost()
        {
            cost = Math.Round(tsena * ves, 2, MidpointRounding.AwayFromZero);
            return cost;
        }

        /// <summary>
        /// Метод отображения данных об элементе в консоли.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Вес элемента:" + ves.ToString());
            Console.WriteLine("Цена грамма элемента:" + tsena.ToString());
        }
    }

}
