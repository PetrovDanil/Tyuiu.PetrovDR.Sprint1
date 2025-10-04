using Tyuiu.PetrovDR.Sprint1.Task7.V23.Lib;

namespace Tyuiu.PetrovDR.Sprint1.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 15.0;
            double y = 10.0;
            Assert.AreEqual(11.172, ds.Calculate(x, y));
        }
    }
}
