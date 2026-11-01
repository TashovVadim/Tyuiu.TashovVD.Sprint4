using Tyuiu.TashovVD.Sprint4.Task3.V27.Lib;

namespace Tyuiu.TashovVD.Sprint4.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int[,] arr = { {4, 3, 5, 5, 3 },
                           {6, 7, 4, 4, 3 },
                           {3, 3, 7, 3, 6 },
                           {3, 4, 3, 7, 7 },
                           {3, 5, 6, 3, 6 } };

            int wait = 8;

            DataService ds = new DataService();

            int res = ds.Calculate(arr);

            Assert.AreEqual(wait, res);

        }
    }
}
