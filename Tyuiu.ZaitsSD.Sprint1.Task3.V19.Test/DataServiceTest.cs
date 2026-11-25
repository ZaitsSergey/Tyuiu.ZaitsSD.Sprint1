using Tyuiu.ZaitsSD.Sprint1.Task3.V19.Lib;
namespace Tyuiu.ZaitsSD.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckElephCanMove()
        {
            double x1 = 5.0;
            double y1 = 1.0;
            double x2 = 5.0;
            double y2 = 1.0;
            bool res = ds.ElephCanMove(x1, y1, x2, y2);
            Assert.IsTrue(res);
        }
    }
}
