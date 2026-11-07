using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TashovVD.Sprint4.Task5.V27.Lib
{
    public class DataService : ISprint4Task5V27
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int res = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] != Math.Abs(matrix[i, j]))
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}
