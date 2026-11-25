using Tyuiu.ZaitsSD.Sprint1.Task4.V6.Lib;
namespace Tyuiu.ZaitsSD.Sprint1.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void FormulaCheck()
        {
            double x = 3.0;
            double y = 2.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.167, res);

        }
    }
}
