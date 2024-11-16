using Tyuiu.BrezinaYS.Sprint4.Task7.V4.Lib;
namespace Tyuiu.BrezinaYS.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 3;
            int col = 4;
            int[,] matrix = new int[rows, col];
            string str = "382976421897";
            int res = ds.Calculate(rows, col, str);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}