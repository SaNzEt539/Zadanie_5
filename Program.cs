using System;

namespace consoleTask_5_1
{
    class Program
    {
        static void f(double x)
        {
            if ((3*x) < 0)
            {
                throw new Exception("Логарифм отрицательного числа");
            }
            if ((2 * x * x * x * x * x - 1) < 0)
            {
                throw new Exception("Квадратный корень из отрицательного числа");
            }
            if ((3 * x) == 0)
            {
                throw new Exception("Логарифм нуля - бесконечность");
            }
            double res = Math.Log(3 * x) * Math.Sqrt(2 * x * x * x * x * x - 1);            
            Console.WriteLine("f({0}) = {1}", x, res);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите a: ");
                double a = Double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                double b = Double.Parse(Console.ReadLine());
                Console.Write("Введите h: ");
                double h = Double.Parse(Console.ReadLine());
                if (h == 0 || h < 0)
                {
                    throw new Exception("h должно быть больше нуля");
                }
                for (double x = a; x <= b; x += h)
                {
                    f(x);
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введено что-то не то");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
