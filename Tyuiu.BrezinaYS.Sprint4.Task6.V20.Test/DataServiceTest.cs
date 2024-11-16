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
            var array = new string[] { "����������", "������", "�����", "��������", "���������", "�������", "����������" };
            string[] res = ds.Calculate(array);
            string[] wait = new string[] { "������", "�����", "��������", "���������", "�������" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}