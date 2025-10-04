using Tyuiu.PetrovDR.Sprint1.Task2.V29.Lib;

namespace Tyuiu.PetrovDR.Sprint1.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 360;
            var res = x / 60;
            Assert.AreEqual(6, res);
        }
    }
}
