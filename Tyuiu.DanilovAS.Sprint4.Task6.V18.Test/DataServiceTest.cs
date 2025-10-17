using System.Diagnostics.CodeAnalysis;
using Tyuiu.DanilovAS.Sprint4.Task6.V18.Lib;
namespace Tyuiu.DanilovAS.Sprint4.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };
            string[] waitArray = { "Попугай", "Черепаха" };
            string[] resultArray = ds.Calculate(array);

            CollectionAssert.AreEqual(waitArray, resultArray);
        }
    }
}
