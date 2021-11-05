using System;

namespace Базовые_переменные
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal max_temp, min_temp, random;

            Console.WriteLine("Введите максимальную температуру за сутки");
            max_temp = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите минимальную температуру за сутки");
            min_temp = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Среднесуточная температура: " + (max_temp + min_temp) / 2);



            Console.WriteLine("Введите номер месяца");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;

                case 2:
                    Console.WriteLine("Февраль");
                    break;

                case 3:
                    Console.WriteLine("Март");
                    break;

                case 4:
                    Console.WriteLine("Апрель");
                    break;

                case 5:
                    Console.WriteLine("Май");
                    break;

                case 6:
                    Console.WriteLine("Июнь");
                    break;

                case 7:
                    Console.WriteLine("Июль");
                    break;

                case 8:
                    Console.WriteLine("Август");
                    break;

                case 9:
                    Console.WriteLine("Сентябрь");
                    break;

                case 10:
                    Console.WriteLine("Октябрь");
                    break;

                case 11:
                    Console.WriteLine("Ноябрь");
                    break;

                case 12:
                    Console.WriteLine("Декабрь");
                    break;

                default:
                    Console.WriteLine("Попробуйте еще раз");
                    break;
            }
        }
    }
}
