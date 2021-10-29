using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите число для проверка -> ");

            a = Convert.ToInt32(Console.ReadLine()); // считываем значение

            Console.WriteLine($"a) Кратно двум или трем: {(((a % 2) == 0 || (a % 3) == 0) ? "Истина" : "Ложь")}"); // тернарный оператор 
            Console.WriteLine($"б) Не кратна трем и оканчивается цифрой 5: {(((a % 3) != 0 && (a % 5) == 0) ? "Истина" : "Ложь")}"); // тернарный оператор 
            Console.WriteLine($"в) Кратно четрым и оканчивается нулём: {((a % 4) == 0 ? "Истина" : "Ложь")}"); // тернарный оператор 

            Console.ReadLine(); // задерживаем консоль
        }
    }
}
