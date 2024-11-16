using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BrezinaYS.Sprint4.Task7.V4.Lib
{
    public class DataService : ISprint4Task7V4
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matr = new int[n, m];
            for (int i = 0; i < n;i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matr[i, j] % 2 !=0)
                    {
                        res += matr[i, j];
                    }
                }
            }
            return res;
        }
    }
}
