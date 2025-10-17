using System.Data;
using Tyuiu.DanilovAS.Sprint4.Task3.V2.Lib;
namespace Tyuiu.DanilovAS.Sprint4.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Данилов А.С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:                              *");
            Console.WriteLine("* Задание #                                                              *");
            Console.WriteLine("* Вариант #                                                              *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИИПб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длине.                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5] { { 4, 3, 2, 8, 7 }, 
                                            { 4, 6, 5, 5, 7 },                        
                                            { 3, 8, 8, 3, 5 }, 
                                            { 5, 7, 5, 4, 4 }, 
                                            { 8, 8, 3, 7, 6 } };

            int rows = matrix.GetUpperBound(0) + 1; //Строки
            int columns = matrix.Length / rows; //Столбцы

            for (int i = 0; i<rows; i++)
            {
                for (int j = 0; j<columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t" );
                }

                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(matrix);
            Console.WriteLine($"Наибольший элемент в первой строке => {result}");
            Console.ReadKey();

        }
    }
}
