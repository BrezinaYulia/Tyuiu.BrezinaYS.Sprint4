using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BrezinaYS.Sprint4.Task5.V9.Lib
{
    public class DataService : ISprint4Task5V9
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;
            int res = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        res ++;
                    }
                }
            }
            return res;
        }
    }
}
