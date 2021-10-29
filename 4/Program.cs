using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double K;
            Console.WriteLine("Введите оценку");
            K = Convert.ToDouble(Console.ReadLine()); // считываем с консоли значение 

            switch (K) // передаем в оператор нашу оценку и сравниваем
            {
                case 1:
                    Console.WriteLine("Плохо");
                    break;
                case 2:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case 3:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case 4:
                    Console.WriteLine("Хорошо");
                    break;
                case 5:
                    Console.WriteLine("Отлично");
                    break;

                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
