using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TashovVD.Sprint4.Task0.V12.Lib
{
    public class DataService : ISprint4Task0V12
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int res = 1;

            for (int i = 0; i < array.Length; i++)
            {
                res *= array[i];
                i++;
            }

            return res;
        }
    }
}
