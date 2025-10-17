using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DanilovAS.Sprint4.Task2.V26.Lib
{
    public class DataService : ISprint4Task2V26
    {
        public int Calculate(int[] array)
        {
            int result = 1;

            for(int i = 0; i<=array.Length -1; i++)
            {
                if (array[i] %2 != 0)
                {
                    result *= array[i];
                }
            }
            return result;
        }
    }
}
