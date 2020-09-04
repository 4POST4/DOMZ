using System;

namespace DOMZ4
{
    class Program
    {
        static void Main(string[] args)

        // Задача №11
        // Все цифры данного трехзначного числа равны
        {
            Console.WriteLine("Проверка - все цифры данного трехзначного числа равны");
            int a;
            Console.WriteLine("Ведите трехзначное число:");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 111 == 0)
            {

                Console.WriteLine("Все числа равны: True");
            }
            else
            {
                Console.WriteLine("Числа не равны: False");

            }

            Console.ReadKey();
        }
    }
}
