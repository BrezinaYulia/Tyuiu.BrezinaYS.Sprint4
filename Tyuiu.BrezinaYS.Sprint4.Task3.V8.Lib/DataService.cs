using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BrezinaYS.Sprint4.Task3.V8.Lib
{
    public class DataService : ISprint4Task3V8
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int col = array.Length / rows;
            int res = 10;
            for (int i = 0; i < rows; i++)
            {
                if (array[i, 3] < res)
                {
                    res = array[i, 3];
                }
            }
            return res;
        }
    }
}
