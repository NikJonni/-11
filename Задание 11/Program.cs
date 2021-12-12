using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение уравнения : 0=kx+b");
            Console.Write("Введите значение 'k' = ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение 'b' = ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Equation task11 = new Equation();
            Console.Write("x = {0:f1}", task11.Root(k1, b1));
            Console.ReadKey();
        }
        struct Equation
        {
            public double k;
            public double b;
            public Equation(double k, double b)
            {
                this.k = k;
                this.b = b;
            }

            public double Root(double k, double b)
            {
                double x = (b * (-1)) / k;
                return x;
            }
        }
    }

}

