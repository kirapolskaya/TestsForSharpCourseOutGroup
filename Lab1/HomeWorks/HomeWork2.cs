namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки строк.
    /// Исходные условия: Метод принимает исходный массив строк, и возвращает результат обработки
    /// </summary>
    public class HomeWork2
    {
        /// <summary>
        /// Найти самую короткую и самую длинную строки. Вернуть найденные строки и их длину.
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Самая длинная строка, ее длина, самая маленькая трока и ее длина. Пример вывода return ("max1", 4, "min", 3);</returns>
        public static (string max, int lengthMax, string min, int lengthMin) Variant1(string[] temp)
        {
            //string lengthMin = [0];
            //string lengthMax = [0];


            //foreach (string t in temp)
            //{
            //    if (lengthMin.Length > t.Length)
            //        lengthMin = t;
            //    if (lengthMax.Length < t.Length)
            //        lengthMax = t;


            //}
            //return lengthMin, lengthmin.Length, lengthMax, lenthmax.Length
            return ("", 0, "", 0);
        }





            /// <summary>
            /// Найти слово, состоящее только из цифр. Если таких слов больше одного, найти второе из них
            /// </summary>
            /// <param name="temp">Исходный массив строк</param>
            /// <returns>Слово состоящее только из цифр.</returns>
            public static string Variant2(string[] temp)
        {  
            string result = null;
           foreach (string t in temp)
        {
                if (isWordContainsDigitsOnly(t))
                {
                    if(result == null)
                    {
                        result = t; 
                    }
                    else
                    {
                        result = t;
                        break;
                    }
                    
                }
        }
          return result;
        }
        public static bool isWordContainsDigitsOnly(string word)
        {
            char[] chars = word.ToCharArray();
            foreach(char c in chars)
            {
                if (!char.IsDigit(c))
                {
                    return false;   
                }
                else
                {
                    return true;    
                }
            }

            return false;
        }
    }
}