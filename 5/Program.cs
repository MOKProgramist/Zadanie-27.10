using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, y; 

            Console.Write("Введите число: ");
            r = Convert.ToDouble(Console.ReadLine()); // считываем знач консоли

            // т.к. switch не может в подобные сравнения мы вводим дополнительную переменную и задаем ей значение при разных условиях и далее проврим ее в кейсах
            if (1 <= r && r <= 3)
            {
                y = 1; // задаем знач.
            }
            else if (4 <= r && r < 6)
            {
                y = 2; // задаем знач. 
            }
            else
            {
                y = 3; // и тут
            } 

            switch (y) // передаем значение и выполняем действия далее
            {
                case 1:
                    y = Math.Round(2*r+6, 2); // вычисляем и сокращаем
                    Console.WriteLine($"f = {y}");
                    break;
                case 2:
                    y = Math.Round(Math.Pow(r,2) + 5, 2); // вычисляем и сокращаем
                    Console.WriteLine($"f = {y}");
                    break;
                case 3:
                    y = 1; // задаем
                    Console.WriteLine($"f = {y}");
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }
        }
    }
}
