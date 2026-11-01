using Tyuiu.TashovVD.Sprint4.Task2.V7.Lib;

namespace Tyuiu.TashovVD.Sprint4.Task2.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Ташов В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Ташов В. Д. | АСОиУб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 4 до 9 подсчитать сумму четных элементов      *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество элементов будущего массива");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[len];

            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(4, 9);
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
