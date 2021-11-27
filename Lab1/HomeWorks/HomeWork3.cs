namespace Lab1.HomeWorks
{
    /// <summary>
    /// Метод калькулятор
    /// Исходные условия: Метод принимает два числа и знак операции.
    /// </summary>
    public class Homework3
    {
       
       
        { /// <summary>
        /// Метод калькулятора
        /// </summary>
        /// <param name="x">Первый операнд</param>
        /// <param name="y">Второй операнд</param>
        /// <param name="mathOperation">Знак операции</param>
        /// <returns>Результат вычисления</returns>
        public static double Calculator(double x, double y, char mathOperation = '+')
            {return x + y};
             public static double Calculator(double x, double y, char mathOperation = '-')
        {return x - y};
        public static double Calculator(double x, double y, char mathOperation = '/')
            {return x/y};
        public static double Calculator(double x, double y, char mathOperation = '*')
            {return x*y};
        {
            return Calculator(x, y, mathOperation);
            ///throw new System.Exception("Не реализован калькулятор");
        }
    }


}