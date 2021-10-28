using System;
using System.Collections.Generic;
using System.Text;

namespace GeekHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру");
            float tempMin = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру");
            float tempMax = float.Parse(Console.ReadLine());
            float tempAv = (tempMax + tempMin) / 2;
            Console.WriteLine($"Среднесуточная температура составляет {tempAv}");
            Console.ReadLine();
        }
    }
}
