using Tyuiu.BrezinaYS.Sprint4.Task4.V21.Lib;
namespace Tyuiu.BrezinaYS.Sprint4.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Брезина Ю. С. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Брезина Юлия Сергеевна | ИИПб-24-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая находит сумму четных элементов массива      *");
            Console.WriteLine("* столбце массива                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, cols];
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                    
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Сумма четных элементов массива: " + res);
            Console.ReadKey();

        }
    }
}
