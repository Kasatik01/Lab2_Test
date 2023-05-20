namespace QA_Lab3
{
    /// <summary>
    /// Исполняемый класс программы с методом Main. Производится ввод данных и выводится соотвествующая информация.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Izdelie chair = new Izdelie();
            //chair.Init(200, 300, 500, (double)0.7, (double)0.5, (double)0.3, "весло");
            //chair.Display();
            chair.Name();
            chair.Read();
            chair.Display();
            Console.WriteLine("Общая стоимость: " + chair.Izdelie_Cost().ToString());
            Element expensive = chair.Expensive();
            Console.WriteLine("Дорогой элемент: ");
            expensive.Display();
            Console.WriteLine("Наибольшая стоимость: " + expensive.Element_Cost().ToString());
        }
    }
}
