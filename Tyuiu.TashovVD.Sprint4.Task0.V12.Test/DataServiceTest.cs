using Tyuiu.TashovVD.Sprint4.Task0.V12.Lib;

namespace Tyuiu.TashovVD.Sprint4.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            int[] arr = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

            int wait = 1536;
            
            DataService ds = new DataService();

            int res = ds.GetMultEvenArrEl(arr);

            Assert.AreEqual(wait, res);
        }
    }
}
