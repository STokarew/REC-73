using System;

namespace REC_73
{
    class Program
    {
        static float MinePow(float number)
        {
            return number * number;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число , которое необходимо возвести в квадрат: ");
            var Num = float.Parse(Console.ReadLine());
            Console.Write($"Квадрат введенного числа: {MinePow(Num)} ");
            Console.ReadKey();
        }
    }
}
