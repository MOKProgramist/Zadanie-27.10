using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для проверки на четность: "); // вывод в консоль

            Console.WriteLine($"{(Convert.ToInt32(Console.ReadLine()) % 2 == 0 ? "true" : "felse") } "); // проверил способ макимально короткой записи, больше такого не будет...
        }
    }
}
