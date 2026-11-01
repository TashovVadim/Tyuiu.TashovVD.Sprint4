using Tyuiu.TashovVD.Sprint4.Task1.V22.Lib;

namespace Tyuiu.TashovVD.Sprint4.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int[] arr = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };

            int wait = 295245;

            DataService ds = new DataService();

            int res = ds.Calculate(arr);

            Assert.AreEqual(wait, res);
        }
    }
}
