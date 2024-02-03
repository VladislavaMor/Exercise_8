using System;
using static System.Console;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> count = new List<int>();

            void Fill()
            {
                Random random = new Random();
                for (int i = 0; i < 100; i++)
                {
                    count.Add(random.Next(101));
                }
                Show();
                WriteLine();
            }
            void Show()
            {
                Write("Последовательность чисел:");
                foreach (int i in count)
                {
                    Write($"{i} ");
                }
            }
            void Remove()
            {
                count.RemoveAll(item => ((item < 50) && (item > 25)) );
                Show();
            }
            
            Fill();
            Remove();
            ReadLine();
        }
    }
}
