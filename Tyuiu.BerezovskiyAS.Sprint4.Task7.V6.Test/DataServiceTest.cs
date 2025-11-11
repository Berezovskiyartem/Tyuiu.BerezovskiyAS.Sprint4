using Tyuiu.BerezovskiyAS.Sprint4.Task7.V6.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint4.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(3, 4, "458963214789");
            Assert.AreEqual(5 + 9 + 3 + 1 + 7 + 9, res);
        }
    }
}
