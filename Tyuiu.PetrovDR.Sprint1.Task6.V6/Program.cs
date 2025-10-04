using Tyuiu.PetrovDR.Sprint1.Task6.V6.Lib;

namespace Tyuiu.PetrovDR.Sprint1.Task6.V6
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
            PrintCenteredLine("Задание #6", width);
            PrintCenteredLine("Вариант #6", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("УСЛОВИЕ:", width);
            PrintCenteredLine("пользователь вводит текст. Напечатать все слова,", width);
            PrintCenteredLine("удалив из них первую букву.", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
            Console.WriteLine(new string('*', width));


            Console.WriteLine("Введите текст:", width);
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);
            Console.WriteLine(new string('*', width));

            Console.WriteLine(ds.DeleteFirstLetter(s));
            Console.ReadLine();
        }
    }
}