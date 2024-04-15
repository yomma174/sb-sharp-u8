namespace Task_2

{
    internal class Program
    {
        /// <summary>
        /// Добавление новых записей в словарь
        /// </summary>
        /// <param name="phoneBook">Коллекция dictionary string string</param>
        static void AddContactRecords(Dictionary<string, string> phoneBook)
        {
            string userInput;
            string[] userInputSplit;
            bool isInputDone = false;

            do
            {
                Console.WriteLine("Введите номер телефона и ФИО владельца через запятую: ");

                userInput = Console.ReadLine();

                if (userInput == "")
                {
                    isInputDone = true;
                    continue;
                }

                userInputSplit = userInput.Split(',', '.');
                phoneBook.Add(userInputSplit[0], userInputSplit[1]);
            }
            while (!isInputDone);
        }


        /// <summary>
        /// Поиск владельца номера в словаре
        /// </summary>
        /// <param name="phoneBook">Коллекция dictionary string string</param>
        static void FindOwnerNumber(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Введите номер телефона для поиска владельца номер: ");

            string userInput = Console.ReadLine();

            if (phoneBook.TryGetValue(userInput, out string FIO))
                Console.WriteLine($"Владелец номера {userInput} {FIO}");
            else
                Console.WriteLine("Владельца по такому номеру телефона не зарегистрировано");
        }


        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            AddContactRecords(phoneBook);
            FindOwnerNumber(phoneBook);
        }
    }
}
