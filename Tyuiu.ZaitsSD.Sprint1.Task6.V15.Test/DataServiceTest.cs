using Tyuiu.ZaitsSD.Sprint1.Task6.V15.Lib;
namespace Tyuiu.ZaitsSD.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TextTest()
        {
            string Text = "Hello World";
            bool res = ds.CheckLettersCount(Text);
            Assert.IsTrue(res);

        }
    }
}
