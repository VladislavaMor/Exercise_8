using System;
using static System.Console;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            
            while(true)
            {
                Write("1.Введите номер телефона: ");
                string number = ReadLine();
                if (number == string.Empty) break;
                Write("2.Введите ФИО владельца: ");
                string FIO = ReadLine();
                dic.Add(number, FIO);
                WriteLine("---------------------------------------------------------");
            }
            WriteLine("---------------------------------------------------------");
            WriteLine("Поиск владельца.");
            Write("Введите номер телефона для поиска: ");
            string phone = ReadLine();
            
            dic.TryGetValue(phone, out string fio);
            if (fio == string.Empty) WriteLine("Владельца с таким номером телефона не зарегестрировано."); 
            else WriteLine($"Имя владельца: {fio}");
        }
    }
}
