using System;
using System.Collections.Generic;
using System.Text;

namespace GeekHomeworkMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер текущего месяца");
            int.TryParse((Console.ReadLine()), out int month);
            Console.WriteLine(MonthName(month));
            IsOdd(month);
            Console.ReadLine();
        }
        public static string MonthName(int month)
        {
            string monthName = "";
            string error = "Error";
            switch (month)
            {
                case 1:
                    monthName = "Январь";
                    return monthName;
                case 2:
                    monthName ="Февраль";
                    return monthName;
                case 3:
                    monthName = "Март";
                    return monthName;
                case 4:
                    monthName = "Апрель";
                    return monthName;
                case 5:
                    monthName = "Май";
                    return monthName;
                case 6:
                    monthName = "Июнь";
                    return monthName;
                case 7:
                    monthName = "Июль";
                    return monthName;
                case 8:
                    monthName = "Август";
                    return monthName;
                case 9:
                    monthName = "Сентябрь";
                    return monthName;
                case 10:
                    monthName = "Октябрь";
                    return monthName;
                case 11:
                    monthName = "Ноябрь";
                    return monthName;
                case 12:
                    monthName = "Декабрь";
                    return monthName;

                default:
                    monthName = "Хорошая попытка, попробуй еще раз";
                    return error;
            }
        }
        public static void IsOdd(int monthNum)
        {
            string isOdd = "";
            if (monthNum % 2 == 0)
            {
                isOdd = "Число четное";
            }
            else if (monthNum % 2 != 0)
            {
                isOdd = "Число нечетное";
            }
            else
            {
                isOdd = "Ошибка";
            }
            Console.WriteLine(isOdd);
        }
    }
}
