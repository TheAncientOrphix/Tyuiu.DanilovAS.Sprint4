using Tyuiu.DanilovAS.Sprint4.Task1.V12.Lib;
namespace Tyuiu.DanilovAS.Sprint4.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[] array = new int[13] { 4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8 };
            var wait = 2205;
            var result = ds.Calculate(array);
            
            Assert.AreEqual(wait, result);
        }
    }
}
