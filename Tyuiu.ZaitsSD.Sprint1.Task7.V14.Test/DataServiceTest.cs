using Tyuiu.ZaitsSD.Sprint1.Task7.V14.Lib;
namespace Tyuiu.ZaitsSD.Sprint1.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestExample()
        {
            double x = 1.0;
            double y = 0.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(1.626, res);
        }
    }
}
