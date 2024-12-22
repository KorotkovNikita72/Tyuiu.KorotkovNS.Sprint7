using Tyuiu.KorotkovNS.Sprint7.Project.V13.Lib;
namespace Tyuiu.KorotkovNS.Sprint7.Project.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint7\Россия.csv";
            string[,] mas = ds.GetMatrix(path);
            string res = mas[1, 0];
            string wait = "Россия";
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void AverageSquare()
        {
            DataService ds = new DataService();
            int[,] mas = new int[3, 4] { { 1, 2, 3, 5 },
                { 9, 10, 5, 5, },
                { 8, 0, 6, 5 }
            };
            double res = ds.avgSquare(mas);
            double wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}