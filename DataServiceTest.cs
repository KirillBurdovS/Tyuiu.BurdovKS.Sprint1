
using Tyuiu.BurdovKS.Sprint1.Task6.V16.Lib;


namespace Tyuiu.BurdovKS.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();




            string test = "!?";


            bool res = ds.CheckSpecSymbols(test);

            bool wait = true;


            Assert.AreEqual(res, wait);













        }
    }
}