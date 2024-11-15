using System.Data;
using Tyuiu.BrezinaYS.Sprint4.Task3.V8.Lib;
namespace Tyuiu.BrezinaYS.Sprint4.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] { { 4, 8, 3, 4, 8 }, { 5, 3, 5, 7, 8 }, { 3, 7, 2, 7, 7 }, { 5, 2, 4, 6, 4 }, { 4, 4, 6, 7, 2 } };
            int rows = array.GetUpperBound(0) + 1;
            int col = array.Length / rows;

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Брезина Ю. С. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Брезина Юлия Сергеевна | ИИПб-24-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая находит самый маленький элемент в четвертом *");
            Console.WriteLine("* столбце массива                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++ )
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Минимальный элемент в четвертом столбце массива : ", +res);
            Console.ReadKey();
        }
    }
}
