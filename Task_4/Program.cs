using System;
using static System.Console;
using System.Xml.Linq;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите ФИО: ");
            string FIO = ReadLine();
            Write("Введите улицу: ");
            string street= ReadLine();
            Write("Введите номер дома: ");
            int house = int.Parse(ReadLine());
            Write("Введите номер квартиры: ");
            int flat = int.Parse(ReadLine());
            Write("Введите мобильный телефон: ");
            string mobilPhone = ReadLine();
            Write("Введите домашний телефон: ");
            string housePhone = ReadLine(); 

            XElement _FIO  = new XElement("Person");
            XElement _address = new XElement("Address");
            XElement _phones = new XElement("Phones");
            XElement _street = new XElement("Street");
            XElement _houseNumber = new XElement("HouseNumber");
            XElement _flatNumber = new XElement("FlatNumber");
            XElement _mobilPhone = new XElement("MobilePhone");
            XElement _flatPhone = new XElement("FlatPhone");

            XAttribute _name = new XAttribute("Name", FIO);

            _street.Add(street);
            _houseNumber.Add(house);
            _flatNumber.Add(flat);
            _mobilPhone.Add(mobilPhone);
            _flatPhone.Add(housePhone);

            _phones.Add(_mobilPhone, _flatPhone);
            _address.Add(_street, _houseNumber, _flatNumber);

            _FIO.Add(_address, _phones, _name);

            _FIO.Save("Person.xml");





        }
    }
}
