using Tyuiu.TashovVD.Sprint4.Task1.V22.Lib;

namespace Tyuiu.TashovVD.Sprint4.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Ташов В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Ташов В. Д. | АСОиУб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива. С клавиатуры: 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, *");
            Console.WriteLine("* 4, 9                                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] arr = new int[12];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Введите значение {i+1} элемента массива: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
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
