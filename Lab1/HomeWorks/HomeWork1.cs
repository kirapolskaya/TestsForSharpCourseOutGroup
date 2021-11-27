namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки массива.
    /// Исходные условия: Метод принимает исходный массив, и возвращает результат обработки
    /// </summary>
    public static class HomeWork1
    {
        /// <summary>
        /// В массиве целых чисел поменять местами максимальный отрицательный элемент и минимальный положительный.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны местами максимальный отрицательный элемент и минимальный положительный</returns>
        public static int[] Variant1(int[] temp)
        {
           int minValue ;
                int maxValue;
            for (int i = 1 ; i < temp.Length ; i++) { 
                minValue = temp[0] ;

            if (minValue < temp[i]){
                    minValue = temp [i]
                        }
            }
            for (int i = 0 ; i < temp.Length ; i++) {
               
                    if(temp[i] >= 1 && maxValue < temp[i] )
                    {
                        maxValue = temp [i];
                    }

                }
            for (int i = 0 ;i < temp.Length ; i+) {
                    if (temp[i] == minValue)
                    {
                        temp[i] = maxValue;
                    }
                    if (temp[i] = maxValue)
                    {
                        temp[i] = minValue;
                    }
             
            }
            return temp;
            }
        
        }

        /// <summary>
        /// В массиве целых чисел определить сумму элементов, состоящих на чётных позициях
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Сумма элементов, состоящих на чётных позициях массива</returns>
        public static int Variant2(int[] temp)
        {
          int sum;
        for (int i = 0 ; i < temp.Length ; i++) {
            int i = temp[0];
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
           return sum;
        }

        /// <summary>
        /// В массиве целых чисел заменить нулями отрицательные элементы.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны отрицательные элементы на нули</returns>
        public static int[] Variant3(int[] temp)
        {
          for (int i = 0 ; i < temp ; i++)
        {
            if(temp[i] < 0)
            {
                temp[i] = 0;
            }
        }
          return temp;
        }

        /// <summary>
        /// В массиве целых чисел утроить каждый положительный элемент, который стоит перед отрицательным.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором *3 каждый положительный элемент, который стоит перед отрицательным</returns>
        public static int[] Variant4(int[] temp)
        {
        int positive;
            for (int i = 1 ; i < temp ; i++)
            positive = temp[i-1]; 
        {
            if (temp[i] < 0 && positive > 0)
            {
                temp[i-1] = temp[i-1] * 3
            }
           
        }
        return temp;
        }

        /// <summary>
        /// В массиве целых чисел найти разницу между средним арифметическим и значение минимального элемента.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Разница между средним арифметическим и значение минимального элемента</returns>
        public static double Variant5(int[] temp)
        {
           int diff;
        int minValue;
        int avg;

        for(int i = 0 ; i < temp.Length; i++) { 
         minValue = temp[0] ;


            if (minValue < temp[i]){
                    minValue = temp [i]
                        }
            
        }
        for(int i = 0 ; i < temp.Length; i++)
        {
           avg += temp[i] ;
        }
        int diff = (int)(avg / temp.Length);
        return diff;
    }

}