using Tyuiu.BurdovKS.Sprint1.Task2.V2.Lib;



namespace Tyuiu.BurdovKS.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {

            DataService ds = new DataService();

            int x = 30;

            var res = ds.ConvertAngleToRad(x);

            Assert.AreEqual(0.524, res);

            


        }
    }
}