using System.Linq.Expressions;
using Tyuiu.DanilovAS.Sprint4.Task7.V21.Lib;
namespace Tyuiu.DanilovAS.Sprint4.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "425963128528";
            int n = 4;
            int m = 3;

            int result = ds.Calculate(n, m,value);
            int wait = 12;
            
            Assert.AreEqual(wait, result);
        }
    }
}
