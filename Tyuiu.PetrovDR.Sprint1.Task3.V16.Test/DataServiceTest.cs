using Tyuiu.PetrovDR.Sprint1.Task3.V16.Lib;

namespace Tyuiu.PetrovDR.Sprint1.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService res = new DataService();
            Assert.AreEqual(res.CoeffOfQuadraticEquation(3, 2), -5);
        }
    }
}
