using Tyuiu.TashovVD.Sprint4.Task2.V7.Lib;

namespace Tyuiu.TashovVD.Sprint4.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int[] arr = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            int wait = 0;

            DataService ds = new DataService();

            int res = ds.Calculate(arr);

            Assert.AreEqual(wait, res);
        }
    }
}
