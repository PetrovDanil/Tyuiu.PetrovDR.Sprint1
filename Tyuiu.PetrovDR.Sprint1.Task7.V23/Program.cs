using Tyuiu.PetrovDR.Sprint1.Task7.V23.Lib;

namespace Tyuiu.PetrovDR.Sprint1.Task7.V23
{

    class Program
    {

        static void Main(string[] args)
        {
            DataService ds = new DataService();


            void PrintCenteredLine(string text, int totalWidth)
            {
                var padding = totalWidth - text.Length - 2;
                Console.WriteLine($"* {text}{new string(' ', padding)}*");
            }
            var width = 75;


            PrintCenteredLine("Спринт #1 | Выполнил: Петров Д. Р. | РППб-25-1", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("Спринт #1", width);
            PrintCenteredLine("Тема: Базовые навыки работы в C#", width);
            PrintCenteredLine("Задание #7", width);
            PrintCenteredLine("Вариант #23", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("УСЛОВИЕ:", width);
            PrintCenteredLine("Написать программу, которая вычисляет математическое выражение", width);
            PrintCenteredLine("по исходным значениям данных, вводимых пользователем. (окр. до 3)", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
            Console.WriteLine(new string('*', width));


            Console.WriteLine("Введите значение Х:", width);
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:", width);
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);
            Console.WriteLine(new string('*', width));

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}