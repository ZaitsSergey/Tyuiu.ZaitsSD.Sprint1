using Tyuiu.ZaitsSD.Sprint1.Task1.V29.Lib;
namespace Tyuiu.ZaitsSD.Sprint1.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void Example()
        {
            double a, b, c;
            a = 2.0;
            b = 3.0;
            c = 5.0;
            var res = ds.Calculate(a,b,c);
            Assert.AreEqual(3.0, res);
        }
    }
}
