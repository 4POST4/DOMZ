using System;

namespace DOMZ3
{
    class Program
    {

        static void Main(string[] args)
        {
            // Задача №4
            // Проверить истнность высказывания: "Данное целое число является четным двузначным числом"

            Console.WriteLine("Проверка высказывания: Данное целое число является четным двузначным числом");

            int a;
            Console.WriteLine("введите число: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0 && a >= 10 && a < 100)

            {

                Console.WriteLine("Четное двузначное число: True");
            }
            else
            {
                Console.WriteLine("Не четное двузначное число: False");

            }

            Console.ReadKey();
        }
    }
}
