using System;
using static System.Console;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            while (true)
            {
                Write("Введите число: ");
                int count = int.Parse(ReadLine());

                if (!set.Contains(count))
                {
                    set.Add(count);
                    WriteLine("Число успешно сохранено в HashSet.");
                }
                else WriteLine("Число уже содержится в HashSet.");
            }

        }
    }
}
