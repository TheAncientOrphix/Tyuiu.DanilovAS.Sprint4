using Tyuiu.DanilovAS.Sprint4.Task0.V6.Lib;
namespace Tyuiu.DanilovAS.Sprint4.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            var wait = 32;
            var res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }
    }
}
