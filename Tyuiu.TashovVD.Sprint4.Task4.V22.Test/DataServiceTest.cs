using Tyuiu.TashovVD.Sprint4.Task4.V22.Lib;

namespace Tyuiu.TashovVD.Sprint4.Task4.V22.Test
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

            int[,] wait = { {4, 0, 0, 0, 0 },
                           {6, 0, 4, 4, 0 },
                           {0, 0, 0, 0, 6 },
                           {0, 4, 0, 0, 0 },
                           {0, 0, 6, 0, 6 } }; ;

            DataService ds = new DataService();

            int[,] res = ds.Calculate(arr);

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
