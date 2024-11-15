using Tyuiu.BrezinaYS.Sprint4.Task2.V12.Lib;
namespace Tyuiu.BrezinaYS.Sprint4.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 5, 9, 6, 4, 5 };
            int res = ds.Calculate(array);
            int wait = 19;
            Assert.AreEqual(wait, res);
        }
    }
}