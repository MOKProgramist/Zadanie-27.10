using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите переменную a: ");
            a = Convert.ToInt32(Console.ReadLine()); // считываем значение 

            Console.Write("Введите переменную b: ");
            b = Convert.ToInt32(Console.ReadLine()); // считываем значение 

            Console.WriteLine($"{(b > 0 ? (a * 2) : (a / 2))}"); // тернарный оператор, если b > 0, то первые скобки, иначе вторые
        } 
    }
}
