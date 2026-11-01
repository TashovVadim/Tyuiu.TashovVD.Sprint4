using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TashovVD.Sprint4.Task3.V27.Lib
{
    public class DataService : ISprint4Task3V27
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int res = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] % 2 == 0) 
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}
