using Tyuiu.ZaitsSD.Sprint1.Task2.V8.Lib;
namespace Tyuiu.ZaitsSD.Sprint1.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Заиц С. Д. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Ввести длины двух сторон прямоугольника.                                *");
            Console.WriteLine("* Вычислить и вывести его периметр.                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите длину первой стороны:");
            int a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите длину второй стороны:");
            int b = int.Parse(Console.ReadLine()!);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.CalculatePerimetr(a, b);
            Console.WriteLine($"Периметр прямоугольника = {res}");
            Console.ReadKey();
        }
    }
}
