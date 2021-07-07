using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введите длину стороны А");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nВведите длину стороны B");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Rectangle instance1 = new Rectangle(sideA, sideB);

            Console.WriteLine($"\nПлощадь прямоугольника равна = {instance1.Area}\nПериметр прямоугольника равен = {instance1.Perimeter}");

            Console.ReadKey();
        }
    }
}
