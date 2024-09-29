using Tyuiu.BurdovKS.Sprint1.Task3.V8.Lib;

namespace Tyuiu.BurdovKS.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {

            DataService ds = new DataService();

            double x = 2500;

            double y = 20;

            double z = 30;

            double wait = 4109.58904109589;

            var res = ds.IncomeAmount(x, y, z);

            Assert.AreEqual(wait, res);






        }
    }
}