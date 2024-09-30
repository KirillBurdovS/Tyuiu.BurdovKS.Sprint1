
using Tyuiu.BurdovKS.Sprint1.Task5.V1.Lib;


namespace Tyuiu.BurdovKS.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x1 = -1;
            double y1 = 5;


            double x2 = 3;
            double y2 = 5;

            double res = ds.DistanceBetweenDots(x1,y1,x2,y2);


            double wait = 4.0;

            Assert.AreEqual(wait, res, 0.001);







        }
    }
}