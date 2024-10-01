
using Tyuiu.BurdovKS.Sprint1.Task7.V30.Lib;

namespace Tyuiu.BurdovKS.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {

            DataService ds = new DataService();

            double x = 2;

            double y = 1;


            double z = 10.539214619068614;


            double actualZ = ds.Calculate(x, y);




            Assert.AreEqual(z, actualZ);





        }
    }
}