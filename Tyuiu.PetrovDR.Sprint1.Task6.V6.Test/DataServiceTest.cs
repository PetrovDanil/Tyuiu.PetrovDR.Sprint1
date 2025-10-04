using Tyuiu.PetrovDR.Sprint1.Task6.V6.Lib;

namespace Tyuiu.PetrovDR.Sprint1.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string prov = "Hello World!";
            Assert.AreEqual("ello orld!", ds.DeleteFirstLetter(prov));
        }
    }
}
