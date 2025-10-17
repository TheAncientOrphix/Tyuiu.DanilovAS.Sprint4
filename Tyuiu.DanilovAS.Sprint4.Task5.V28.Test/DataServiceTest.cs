using Microsoft.VisualBasic;
using Tyuiu.DanilovAS.Sprint4.Task5.V28.Lib;
namespace Tyuiu.DanilovAS.Sprint4.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5];

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[,] waitMatrix = new int[5, 5] { { 4, 3, 2, 8, 7 },
                                              { 0,0,0,0,0 },
                                              { 3, 8, 8, 3, 5 },
                                              { 5, 7, 5, 4, 4 },
                                              { 8, 8, 3, 7, 6 } };

            int[,] result = new int[5, 5]     { { 4, 3, 2, 8, 7 },
                                              { -4, -5, -5, -5, -7 },
                                              { 3, 8, 8, 3, 5 },
                                              { 5, 7, 5, 4, 4 },
                                              { 8, 8, 3, 7, 6 } };

            result = ds.Calculate(result);
            CollectionAssert.AreEqual(waitMatrix, result);
        }
    }
}
