using Tyuiu.TashovVD.Sprint4.Task6.V11.Lib;

namespace Tyuiu.TashovVD.Sprint4.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            string[] arr = {"Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };

            int wait = 3;

            DataService ds = new DataService();

            int res = ds.Calculate(arr);

            Assert.AreEqual(wait, res);
        }
    }
}
