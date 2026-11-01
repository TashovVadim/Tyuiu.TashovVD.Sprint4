using Tyuiu.TashovVD.Sprint4.Task3.V27.Lib;

namespace Tyuiu.TashovVD.Sprint4.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Ташов В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Ташов В. Д. | АСОиУб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 7. Подсчитайте количество   *");
            Console.WriteLine("* четных элементов во всем массиве.                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] arr = { {4, 3, 5, 5, 3 },
                           {6, 7, 4, 4, 3 },
                           {3, 3, 7, 3, 6 },
                           {3, 4, 3, 7, 7 },
                           {3, 5, 6, 3, 6 } };

            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
                
            }

            DataService ds = new DataService();

            int res = ds.Calculate(arr);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}
