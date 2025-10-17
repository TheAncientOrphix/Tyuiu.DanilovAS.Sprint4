using Tyuiu.DanilovAS.Sprint4.Task3.V2.Lib;
namespace Tyuiu.DanilovAS.Sprint4.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 4, 3, 2, 8, 7 },
                                            { 4, 6, 5, 5, 7 },
                                            { 3, 8, 8, 3, 5 },
                                            { 5, 7, 5, 4, 4 },
                                            { 8, 8, 3, 7, 6 } };

            var wait = 8;
            var result = ds.Calculate(matrix);

            Assert.AreEqual(wait,result);
        }
    }
}
