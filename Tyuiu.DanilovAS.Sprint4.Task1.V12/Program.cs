using Tyuiu.DanilovAS.Sprint4.Task1.V12.Lib;
namespace Tyuiu.DanilovAS.Sprint4.Task1.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Данилов А.С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:                             *");
            Console.WriteLine("* Задание #                                                              *");
            Console.WriteLine("* Вариант #                                                              *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИИПб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("*  значениями с клавиатуры в диапазоне от 4 до 9 подсчитать произведение  *");
            Console.WriteLine("*  нечетных элементов массива.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[13];

            for (int i = 0; i <= array.Length-1; i++)
            {
                Console.Write($"Введите эл-т массива {i + 1} => ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine($"Ответ равен => {result}");
            Console.ReadKey();
        }
    }
}
