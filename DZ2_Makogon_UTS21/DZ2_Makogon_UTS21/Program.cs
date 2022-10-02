using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Makogon_UTS21
{
    internal class Program
    {
        // ВАРИАНТ 8
        static void Main(string[] args)
        {
            //печать всех нужных y
            for (double x = -10; x < 8.1;x += 0.2)
            {
                if (x < -6)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x, 2));
                }
                else if (x < 2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x));
                    // в точке с x = 2 наблюдается разрыв
                    if (x > 1.8)
                    {
                        //прямая, начиная с этой точки, лежит на оси x
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, 0);
                    }
                }
                else if (x < 6)
                {
                    //на данном участке прямая лежит на оси x
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, 0);

                }
                else if (x < 8.1)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(x));
                }
            }
        }
        // расчёт точек окружности
        static double segment1(double x, double r)
        {
            //центр окружности
            double a = -8;
            double b = -2;
            //уравнение окружности
            double y;
            y = Math.Sqrt(Math.Abs(r * r - (x - a) * (x - a))) + b;
            return y;
        }
        // расчёт точек прямой
        static double segment2(double x)
        {
            //кофициенты уравнения прямой
            double b = 1;
            double k = 0.5;
            //уравнение прямой
            double y = k * x + b;
            return y;
        }
        // расчёт точек параболы
        static double segment3(double x)
        {
            //кофициенты уравнения параболы
            double a = -6;
            //уравнение параболы
            double y = (x+a)*(x+a);
            return y;
        }
    }
}
