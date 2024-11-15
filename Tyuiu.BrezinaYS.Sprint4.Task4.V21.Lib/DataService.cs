using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BrezinaYS.Sprint4.Task4.V21.Lib
{
    public class DataService : ISprint4Task4V21
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;
            int res = 0;
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        res += matrix[i, j];
                    }
                }
            }
            return res;
        }
    }
}
