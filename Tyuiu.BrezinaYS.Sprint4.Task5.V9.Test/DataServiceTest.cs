using Tyuiu.BrezinaYS.Sprint4.Task5.V9.Lib;
namespace Tyuiu.BrezinaYS.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 1, 0, 2, 3, -1 }, { -2, 1, 3, -3, -4 }, { 1, 2, 3, -1, -3 }, { -3, 3, 2, -2, 1 }, { 1, -3, 0, -4, -1} };
            int res = ds.Calculate(array);
            int wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}