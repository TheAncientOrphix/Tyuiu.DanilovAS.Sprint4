using Tyuiu.DanilovAS.Sprint4.Task2.V26.Lib;
namespace Tyuiu.DanilovAS.Sprint4.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[] testArray = new int[14] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            var wait = 135135;
            var result = ds.Calculate(testArray);

            Assert.AreEqual(wait, result);
            
        }
    }
}
