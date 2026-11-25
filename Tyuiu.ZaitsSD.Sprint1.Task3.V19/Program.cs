using Tyuiu.ZaitsSD.Sprint1.Task3.V19.Lib;

namespace Tyuiu.ZaitsSD.Sprint1.Task3.V19
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Проверить, может ли слон за один ход перейти с одной клетки на другую.  *");
            Console.WriteLine("* Ввести x1, y1, x2 и y2. Координаты от 1 до 8.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            bool res = ds.ElephCanMove(x1, y1, x2, y2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res.ToString().ToLower());
            Console.ReadKey();


        }
    }
}
