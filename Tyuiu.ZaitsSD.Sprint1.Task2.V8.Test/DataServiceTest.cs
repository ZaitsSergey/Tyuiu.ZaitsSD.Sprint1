using Tyuiu.ZaitsSD.Sprint1.Task2.V8.Lib;
namespace Tyuiu.ZaitsSD.Sprint1.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckPerimetr()
        {
            int a = 3;
            int b = 5;
            int res = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(16, res);
        }
    }
}
