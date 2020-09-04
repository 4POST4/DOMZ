using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMZ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача №24
            // Найти периметр и площать прямоугольного треугольника, если даны длины его катетов a и b
            Console.WriteLine("Ведите катет a:");
            double a;
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите катет b:");
            double b;
            b = double.Parse(Console.ReadLine());
            // Найдем гипотенузу
            double c = Math.Sqrt((a*a) + (b*b));
            Console.WriteLine($"Гипотенуза = {c}");
            double p = a + b + c; //периметр
            Console.WriteLine($"Периметр = {p}");
            //Найдем площадь прямоугольного треугольника
            double S = 0.5*(a*b);
            Console.WriteLine($"Площадь прямоугольного треугольника = {S}");

            Console.ReadKey();





        }
    }
}
