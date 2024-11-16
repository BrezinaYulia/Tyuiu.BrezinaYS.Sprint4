using Tyuiu.BrezinaYS.Sprint4.Task6.V20.Lib;
namespace Tyuiu.BrezinaYS.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var array = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            string[] res = ds.Calculate(array);
            string[] wait = new string[] { "Физика", "Химия", "Биология", "География", "История" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}