using System.Xml.Linq;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ФИО");
            string _name = Console.ReadLine();

            Console.WriteLine("Введите улицу");
            string _street = Console.ReadLine();

            Console.WriteLine("Введите номер дома");
            string _houseNumber = Console.ReadLine();

            Console.WriteLine("Введите номер квартиры");
            string _flatNumber = Console.ReadLine();

            Console.WriteLine("Введите мобильный телефон");
            string _mobilePhone = Console.ReadLine();

            Console.WriteLine("Введите домашний телефон");
            string _flatPhone = Console.ReadLine();


            XElement Person = 
                new XElement("Person",
                    new XAttribute("name", _name),
                    new XElement("Address",
                        new XElement("Street", _street),
                        new XElement("HouseNumber", _houseNumber),
                        new XElement("FlatNumber", _flatNumber)
                    ),
                    new XElement("Phones",
                        new XElement("MobilePhone", _mobilePhone),
                        new XElement("FlatPhone", _flatPhone)
                    )
                );

            Person.Save("_Person3.xml");
        }
    }
}
