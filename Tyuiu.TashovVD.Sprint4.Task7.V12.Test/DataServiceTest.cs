using Tyuiu.TashovVD.Sprint4.Task7.V12.Lib;

namespace Tyuiu.TashovVD.Sprint4.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            string str = "658932125478";
             
            int wait = 30;

            DataService ds = new DataService();

            int res = ds.Calculate(3, 4, str);

            Assert.AreEqual(wait, res);


        }
    }
}
