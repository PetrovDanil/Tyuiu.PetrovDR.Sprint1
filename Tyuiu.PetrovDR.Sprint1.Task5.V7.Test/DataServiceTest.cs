using Tyuiu.PetrovDR.Sprint1.Task5.V7.Lib;

namespace Tyuiu.PetrovDR.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 60;
            var res = ds.AngleToHoursMinutes(x);
            Assert.AreEqual(2, res);
        }
    }
}
