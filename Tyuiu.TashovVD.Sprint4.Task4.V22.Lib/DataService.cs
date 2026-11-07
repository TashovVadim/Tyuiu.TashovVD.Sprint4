using tyuiu.cources.programming.interfaces.Sprint4;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.TashovVD.Sprint4.Task4.V22.Lib
{
    public class DataService : ISprint4Task4V22
    {
        public int[,] Calculate(int[,] matrix)
        {

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] res = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        res[i,j] = 0;
                    }
                    else
                    {
                        res[i,j ] = matrix[i, j];
                    }
                }
            }

            return res;
        }
    }
}
