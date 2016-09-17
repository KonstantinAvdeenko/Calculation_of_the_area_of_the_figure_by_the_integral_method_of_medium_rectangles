using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodPryamougolnicov 
{
    class Program
    {
        static void Main(string[] args)
        {
//метод средних прямоугольников
            //h-высота,s-вся площадь,k-точность,n-количество прямоугольников,f-функция

double a, b, h, s, n, k, f;

            Console.WriteLine("Введите нижний предел интеграла");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхний предел интеграла");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество прямоугольников");
            n = double.Parse(Console.ReadLine());
            h = (b - a) / n; // формула вычисления интеграла методом  средних прямоугольников
            for (double x1 = 0, x = a; x <= b; x += h)
            {
                if (x < b)
                {
                    x1 = x + h / 2; // абсолютная погрешность метода средних прямоугольников
                    if (x1 >= b)
                        continue;
                    f = Math.Pow(x1, b) * Math.Sqrt((b * b - x1 * x1));
                    s += f;
                }
            }
            Console.WriteLine("**********************************");
            Console.WriteLine("Данный интеграл равен: {0:0.0000}", s * h);
            Console.ReadKey();
         }
     }
}
