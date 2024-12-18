using Tyuiu.KorotkovNS.Sprint7.Project.V13.Lib;
namespace Tyuiu.KorotkovNS.Sprint7.Project.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint7\Россия.csv";
            string[,] mas = ds.GetMatrix(path);
            string res = mas[0, 0];
            string wait = "Россия";
            Assert.AreEqual(wait, res);
        }
    }
}