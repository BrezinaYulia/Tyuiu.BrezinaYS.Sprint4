using Tyuiu.BrezinaYS.Sprint4.Task0.V29.Lib;
namespace Tyuiu.BrezinaYS.Sprint4.Task0.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Брезина Ю. С. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Брезина Юлия Сергеевна | ИИПб-24-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов.                    *");
            Console.WriteLine("* Подсчитать сумму нечетных элементов массива.                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма нечетных элементов массива: " + ds.GetSumOddArrEl(array));
            Console.ReadKey();

        }
    }
}
