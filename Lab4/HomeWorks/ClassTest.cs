using System;

namespace Lab4.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода с обработкой исключений
    /// </summary>
    public static class ClassTest
    {
        public static void MetrodWithException(int temp) 
        {
            try
{
                int result = 0;
    int [] array = { 1, 2,3,4, 5,6,7,8,9,10}
                for  (int i = 0; i < array.Length; i++)
                {
                    result = array[i-1];
                }
}
     catch (IndexOutOfRangeException e)
{
    throw new Exception();
}
        }
    }
}