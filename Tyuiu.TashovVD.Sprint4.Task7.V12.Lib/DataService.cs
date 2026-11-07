using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TashovVD.Sprint4.Task7.V12.Lib
{
    public class DataService : ISprint4Task7V12
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] data = new int[n, m];

            for (int i = 0; i < n; i++)
            {

                for (var j = 0; j < m; j++)
                {
                    data[i, j] = int.Parse(value.Substring(i*m + j, 1));
                }

            }

            int res = 0;

            for (int i = 0; i < n; i++)
            {

                for (var j = 0; j < m; j++)
                {
                    if (data[i, j] % 2 != 0) 
                    {
                        res += data[i, j];
                    }
                }

            }

            return res;
        }
    }
}
