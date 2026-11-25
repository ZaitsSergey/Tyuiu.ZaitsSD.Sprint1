using Tyuiu.ZaitsSD.Sprint1.Task0.V6.Lib;
namespace Tyuiu.ZaitsSD.Sprint1.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(15.0, res);
        }
    }
}
