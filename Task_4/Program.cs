using System.Xml.Linq;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XElement Person = new XElement("Person");

            Console.WriteLine("Введите ФИО");
            XAttribute name = new XAttribute("name", Console.ReadLine());

            XElement Address = new XElement("Address");

            Console.WriteLine("Введите улицу");
            XElement Street = new XElement("Street", Console.ReadLine());

            Console.WriteLine("Введите номер дома");
            XElement HouseNumber = new XElement("HouseNumber",Console.ReadLine());

            Console.WriteLine("Введите номер квартиры");
            XElement FlatNumber = new XElement("FlatNumber",Console.ReadLine());

            XElement Phones = new XElement("Phones");

            Console.WriteLine("Введите мобильный телефон");
            XElement MobilePhone = new XElement("MobilePhone", Console.ReadLine());

            Console.WriteLine("Введите домашний телефон");
            XElement FlatPhone = new XElement("FlatPhone", Console.ReadLine());

            Person.Add(name,Address,Phones);

            Address.Add(Street,HouseNumber,FlatNumber);

            Phones.Add(HouseNumber, FlatNumber);

            Person.Save("_Person2.xml");
        }
    }
}
