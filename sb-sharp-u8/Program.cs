namespace Task_1
{
    internal class Program
    {
        /// <summary>
        /// Создает коллекцию list int и заполняет случайными целыми числами в заданном диапазоне.
        /// </summary>
        /// <param name="count">Число элементов</param>
        /// <param name="min">Включенный нижний предел случайного числа.</param>
        /// <param name="max">Исключенный верхний предел случайного числа. Значение свойства
        ///     max должно быть больше или равно значению свойства min.</param>
        /// <returns>Возвращает заполненную случайными целыми числами коллекцию list int</returns>
        static List<int> Fill(int count, int min, int max)
        {
            List<int> intList = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
                intList.Add(rnd.Next(min, max));

            return intList;
        }


        /// <summary>
        /// Удаляет в коллекции list int элементы больше min и меньше max
        /// </summary>
        /// <param name="intList">Коллекция list int </param>
        /// <param name="min">Исключенный нижний предел диапазона</param>
        /// <param name="max">Исключенный верхний предел диапазона</param>
        /// <returns>Возвращает неполную копию диапазона элементов исходного списка</returns>
        static List<int> RemoveInRange(List<int> intList, int min, int max)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] > min && intList[i] < max)
                {
                    intList.Remove(intList[i]);
                    i--;
                }
            }

            return intList;
        }


        /// <summary>
        /// Вывод на консоль значение всех элементов коллекции
        /// </summary>
        /// <param name="list">Коллекция list int</param>
        static void Print(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            List<int> _intList = new List<int>();

            _intList = Fill(100,0,100);

            Print(_intList);

            Print(RemoveInRange(_intList,25,50));
        }
    }
}
