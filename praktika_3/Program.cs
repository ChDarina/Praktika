using System;

namespace praktika_3
{
    class Program
    {
        static public double InputNumber(string ForUser)
        {
            bool ok = true;
            double number = 0;
            do
            {
                Console.WriteLine(ForUser);
                try
                {
                    string buf = Console.ReadLine();
                    number = Convert.ToDouble(buf);
                    ok = false;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод числа!");
                }
            } while (ok);
            return number;
        }

        static void Main(string[] args)
        {
            double u;
            double x = InputNumber("Введите x:");
            double y = InputNumber("Введите y:");
            if (x * x + y * y <= 1 & y>=x & y<=-x) u = Math.Sqrt(Math.Abs(x * x - 1));
            else u = x + y;
            Console.WriteLine("Число u равно: " + u);
            Console.ReadKey();
        }
    }
}
