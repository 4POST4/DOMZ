using System;

namespace DOMZ2
{
    class Program
    {
        static void Main(string[] args)
        // Задача №7
        // Составить программу вычисления идеального веса человека по его росту, при условии, что идеальный вес(кг) = рост(см) - 100
        {
            Console.WriteLine("Рассчитай свой идеальный вес!");
            Console.WriteLine("Ведите свой нынешний вес (кг):");
            double weight;
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите свой рос (см):");
            double height;
            height = double.Parse(Console.ReadLine());
            double ideal_weight = height - 100;
            Console.WriteLine($" Ваш идеальный вес: {ideal_weight}");

            Console.ReadKey();
        }
    }
}
